using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyyCommerce.Data;
using MyyCommerce.Domain;
using MyyCommerce.Models;
using MyyCommerce.Utils;
using MyyCommerce.Utils.Enums;

namespace MyyCommerce.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpClientFactory _clientFactory;
        IConfiguration _configuration;

        public CheckoutController(ApplicationDbContext context, IHttpClientFactory clientFactory, IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            db = context;
            _clientFactory = clientFactory;
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await GetChekoutModel());
        }


        public async Task<IActionResult> FazerCheckout(CheckoutViewModel model)
        {
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);
            var pedido = new Pedido()
            {
                ApplicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier),
                Cep = model.CepEntrega,
                Complemento = model.ComplementoEntrega,
                DataEntrega = DateTime.ParseExact(model.DataEntrega, "dd/MM/yyyy", CultureInfo.CurrentCulture),
                Endereco = model.EnderecoEntrega,
                DataPedido = DateTime.Now,
                Numero = model.NumEntrega,
                TipoEntrega = model.TipoEntrega,
            };

            var carrinho = HttpContext.Session.GetObjectFromJson<PedidoCarrinho>("CarrinhoDb");

            pedido.Produtos = new List<ProdutoPedido>();
            foreach (var item in carrinho.Produtos)
            {
                ProdutoPedido produtoPedido = new ProdutoPedido() {
                    ProdutoId = item.ProdutoId,
                    Quantidade = item.Quantidade,
                };

                pedido.Produtos.Add(produtoPedido);
            }
            db.Add(pedido);
            db.SaveChanges();

            var client = _clientFactory.CreateClient();


            foreach (var produto in carrinho.Produtos)
            {
                var produtoEstoque = db.Produtos.Where(x => x.Id == produto.ProdutoId).FirstOrDefault();
                if (produtoEstoque != null)
                {
                    produtoEstoque.QtdEstoque -= produto.Quantidade;
                    db.Update(produtoEstoque);
                }
            }
            db.SaveChanges();

            db.PedidosCarrinho.Remove(db.PedidosCarrinho.Where(x => x.UserId == user.Id).FirstOrDefault());
            db.SaveChanges();

            PedidoCarrinho carrinhoSession = HttpContext.Session.GetObjectFromJson<PedidoCarrinho>("CarrinhoDb");
            carrinhoSession.Produtos = new List<ProdutoCarrinho>();
            HttpContext.Session.SetObjectAsJson("CarrinhoDb", carrinhoSession);

            return RedirectToAction("ConfirmarCompra", "Checkout", new { id = pedido.Id});
        }

        public async Task<IActionResult> RemoverProduto(int id, int Quantidade)
        {
            PedidoCarrinho carrinho = HttpContext.Session.GetObjectFromJson<PedidoCarrinho>("CarrinhoDb");
            if (carrinho == null)
                carrinho = new PedidoCarrinho();

            PedidoCarrinho carrinhoDb = db.PedidosCarrinho.Where(x => x.UserId == carrinho.UserId).Include(x => x.Produtos).FirstOrDefault();
            if (carrinho.Produtos != null)
            {
                if (carrinho.Produtos.Where(x => x.ProdutoId == id).FirstOrDefault().Quantidade - Quantidade > 0)
                {
                    carrinho.Produtos.Where(x => x.ProdutoId == id).FirstOrDefault().Quantidade -= Quantidade;
                    carrinhoDb.Produtos.Where(x => x.ProdutoId == id).FirstOrDefault().Quantidade -= Quantidade;
                }
                else
                {
                    carrinho.Produtos.Remove(carrinho.Produtos.Where(x => x.ProdutoId == id).FirstOrDefault());
                    db.ProdutosCarrinho.Remove(carrinhoDb.Produtos.Where(x => x.ProdutoId == id).FirstOrDefault());
                    carrinhoDb.Produtos.Remove(carrinhoDb.Produtos.Where(x => x.ProdutoId == id).FirstOrDefault());
                }
            }
            HttpContext.Session.SetObjectAsJson("CarrinhoDb", carrinho);

           
            db.Update(carrinhoDb);
            db.SaveChanges();


            return PartialView("_CheckoutProdutosPartial", await GetChekoutModel());
        }

        public async Task<CheckoutViewModel> GetChekoutModel()
        {
            var model = new CheckoutViewModel()
            {
                ValorTotal = 0,
                PrecoEntrega = 0,
                PrecoFinal = 0,
                ProdutoString = ""
            };

            if (HttpContext.Session.GetObjectFromJson<PedidoCarrinho>("CarrinhoDb") != null)
            {
                model.Carrinho = HttpContext.Session.GetObjectFromJson<PedidoCarrinho>("CarrinhoDb");
            }
            else
            {
                model.Carrinho = new PedidoCarrinho() { Produtos = new List<ProdutoCarrinho>()  };
            }

            int i = 1;
            foreach (var item in model.Carrinho.Produtos)
            {
                item.Produto = db.Produtos.Where(x => x.Id == item.ProdutoId).FirstOrDefault();
                if (item.Produto != null)
                {
                    model.ValorTotal += item.Quantidade * item.Produto.Valor;
                    model.PrecoFinal = model.ValorTotal;
                    model.ProdutoString += "&itemId" + i + "=" + item.Produto.Id + "&itemDescription" + i + "=" + item.Produto.Nome + "&itemAmount" + i + "=" + item.Produto.Valor + "&itemQuantity" + i + "=" + item.Quantidade;
                    i++;
                }
            }

          
            return model;
        }

        public IActionResult ConfirmarCompra(int Id)
        {
            Pedido pedido = db.Pedido.Where(x => x.Id == Id).Include(x => x.Produtos).FirstOrDefault();
            var user = db.Users.Where(x => x.Id == this.User.FindFirstValue(ClaimTypes.NameIdentifier)).FirstOrDefault();

            foreach (var item in pedido.Produtos)
            {
                item.Produto = db.Produtos.Where(x => x.Id == item.ProdutoId).FirstOrDefault();
            }

            return View(pedido);
        }

    }
}
