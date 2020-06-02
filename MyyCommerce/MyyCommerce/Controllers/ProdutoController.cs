using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyyCommerce.Data;
using MyyCommerce.Domain;
using MyyCommerce.Models;
using MyyCommerce.Utils;

namespace MyyCommerce.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        private readonly ApplicationDbContext db;
        private ApplicationUser applicationUser = new ApplicationUser();
        private readonly UserManager<ApplicationUser> _userManager;


        public ProdutoController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            db = context;
            _userManager = userManager;
        }

        public IActionResult Index(int? page)
        {
            return View(GetProdutoModel(page));
        }

        public IActionResult GetEmpty()
        {
            return PartialView("_ProdutoFormPartial", new ProdutoFormModel() { Produto = new Produto() { Ativo = true } });
        }

        public IActionResult Filtrar(ProdutoFilterModel filterModel)
        {
            HttpContext.Session.SetComplexData("FilterModelProduto", filterModel);

            ModelState.Clear();

            return PartialView("_ProdutoTablePartial", GetProdutoModel(1));
        }

        [HttpGet]
        public IActionResult OpenExisting(int id)
        {
            Produto Produto = db.Produtos.Where(x => x.Id == id).Include(x => x.Fotos).FirstOrDefault();
            return PartialView("_ProdutoFormPartial", new ProdutoFormModel() { Produto = Produto });
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(ProdutoFormModel model)
        {

            if (model.Produto.Fotos == null)
                model.Produto.Fotos = new List<ProdutoImage>();

            if (model.Produto.Id == 0)
            {
                db.Attach(model.Produto);
            }
            else
            {
                db.Update(model.Produto);
            }



            db.SaveChanges();

            string path = "Uploads/" + model.Produto.Id;
            if (!Directory.Exists("wwwroot/" + path))
                Directory.CreateDirectory("wwwroot/" + path);

            if (model.ProdutoImage != null)
                foreach (IFormFile file in model.ProdutoImage)
                {
                    file.FileName.Replace(" ", "_");
                    var filePath = path + "/" + file.FileName;

                    ProdutoImage image = new ProdutoImage();

                    using (var stream = new FileStream("wwwroot/" + filePath, FileMode.Create))
                    {
                        model.ProdutoImage[0].CopyTo(stream);
                        stream.Close();
                    }

                    image.ProdutoId = model.Produto.Id;
                    image.Path = filePath;
                    model.Produto.Fotos.Add(image);
                }

            db.SaveChanges();

            ModelState.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Detalhar(int id)
        {
            Produto Produto = db.Produtos.Where(x => x.Id == id).Include(x => x.Fotos).FirstOrDefault();
            ProdutoDetalheModel model = new ProdutoDetalheModel();
            model.Produto = Produto;
            model.ProdutoBack = db.Produtos.Where(x => x.Id == id - 1).FirstOrDefault();
            model.ProdutoForward = db.Produtos.Where(x => x.Id == id + 1).FirstOrDefault();

            return View("_DetalhamentoProduto", model);
        }

        public IActionResult Deletar(int id)
        {
            applicationUser.DeletarProduto(id); // Mudar pra usuário logado
            ModelState.Clear();
            return PartialView("_ProdutoTablePartial", GetProdutoModel(HttpContext.Session.GetInt32("ProdutoPage")));
        }

        public IActionResult DeletarFoto(int id)
        {
            ProdutoImage Foto = db.ProdutosImages.Where(x => x.Id == id).FirstOrDefault();
            int produtoId = Foto.ProdutoId;
            db.Remove(Foto);
            db.SaveChanges();

            Produto Produto = db.Produtos.Where(x => x.Id == produtoId).Include(x => x.Fotos).FirstOrDefault();
            return PartialView("_ProdutoFormPartial", new ProdutoFormModel() { Produto = Produto });
        }

        public ProdutoViewModel GetProdutoModel(int? page)
        {
            if (page == null)
            {
                page = 1;
            }

            IQueryable<Produto> produtos = db.Produtos;

            ProdutoFilterModel filterModel = HttpContext.Session.GetComplexData<ProdutoFilterModel>("FilterModelProduto");
            if (filterModel != null)
            {
                if (filterModel.FilterNome != null)
                {
                    produtos = produtos.Where(x => x.Nome.ToUpper().Contains(filterModel.FilterNome.ToUpper()));
                }

                if (filterModel.FilterCategoria != null)
                {
                    produtos = produtos.Where(x => x.Categoria == filterModel.FilterCategoria);
                }

                if (filterModel.FilterAtivo != null)
                {
                    produtos = produtos.Where(x => x.Ativo == filterModel.FilterAtivo);
                }

                if (filterModel.FilterGenero != null)
                {
                    produtos = produtos.Where(x => x.Genero == filterModel.FilterGenero);
                }
            }

            return new ProdutoViewModel(produtos, new Pager(produtos.Count(), page));
        }

        public IActionResult AdicionarNoCarrinho(int ProdutoId, int Quantidade)
        {
            PedidoCarrinho carrinho = HttpContext.Session.GetObjectFromJson<PedidoCarrinho>("CarrinhoDb");
            if (carrinho == null)
                carrinho = new PedidoCarrinho() { Produtos = new List<ProdutoCarrinho>() };

            var produtoEmCarrinho = carrinho.Produtos.Where(x => x.ProdutoId == ProdutoId).FirstOrDefault();
            if (produtoEmCarrinho != null)
            {
                produtoEmCarrinho.Quantidade += Quantidade;
            }
            else
            {
                ProdutoCarrinho produtoCarrinho = new ProdutoCarrinho() { ProdutoId = ProdutoId, Quantidade = Quantidade };
                carrinho.Produtos.Add(produtoCarrinho);
            }

            //var produto = db.Produtos.Where(x => x.Id == ProdutoId).FirstOrDefault();
            //produto.QtdEstoque -= Quantidade;
            //db.Update(produto);
            //db.SaveChanges();

            PedidoCarrinho pedidoCarrinho = db.PedidosCarrinho.Where(x => x.UserId == _userManager.GetUserAsync(HttpContext.User).Result.Id)
                .Include(x => x.Produtos)
                .FirstOrDefault();

            if (pedidoCarrinho == null)
            {
                carrinho.UserId = _userManager.GetUserAsync(HttpContext.User).Result.Id;
                db.Add(carrinho);
            }
            else
            {
                carrinho.Produtos.ForEach(prod => {
                    pedidoCarrinho.Produtos.ForEach(p => {
                        if(prod.ProdutoId == p.ProdutoId)
                        {
                            p.Quantidade = prod.Quantidade;
                        }
                    });
                });
                db.Update(pedidoCarrinho);
            }
            db.SaveChanges();


            HttpContext.Session.SetInt32("CartNumber", carrinho.Produtos.Count());
            HttpContext.Session.SetComplexData("CarrinhoDb", carrinho);
            return Ok(carrinho.Produtos.Count().ToString());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
