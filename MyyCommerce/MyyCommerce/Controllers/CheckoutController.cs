using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IHttpClientFactory _clientFactory;
        IConfiguration _configuration;

        public CheckoutController(ApplicationDbContext context, IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            db = context;
            _clientFactory = clientFactory;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            return View(await GetChekoutModel());
        }

        [HttpPost]
        public async Task<IActionResult> FazerCheckout(CheckoutViewModel model)
        {
            ApplicationUser user = db.Users.Where(x => x.TipoUser == eTipoUser.Cliente && x.Id == this.User.FindFirstValue(ClaimTypes.NameIdentifier)).FirstOrDefault();
            var pedido = new Pedido()
            {
                ApplicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier),
                Cep = model.CepEntrega,
                Complemento = model.ComplementoEntrega,
                DataEntrega = Convert.ToDateTime(model.DataEntrega),
                Endereco = model.EnderecoEntrega,
                DataPedido = DateTime.Now,
                Numero = model.NumEntrega,
                TipoEntrega = model.TipoEntrega,

            };

            var carrinho = HttpContext.Session.GetObjectFromJson<List<ProdutoPedido>>("Carrinho");
            
            db.Attach(pedido);
            foreach (var item in carrinho)
            {
                item.PedidoId = pedido.Id;
                db.Attach(item);
            }
            db.SaveChanges();

            var client = _clientFactory.CreateClient();

           
            foreach (var produto in carrinho)
            {
                var produtoEstoque = db.Produtos.Where(x => x.Id == produto.ProdutoId).FirstOrDefault();
                if (produtoEstoque != null)
                {
                    produtoEstoque.QtdEstoque -= produto.Quantidade;
                    db.Update(produtoEstoque);
                }
            }
            db.SaveChanges();


            return Ok(pedido.Id);
        }

        public IActionResult RemoverProduto(int id, int Quantidade)
        {
            List<ProdutoPedido> carrinho = HttpContext.Session.GetObjectFromJson<List<ProdutoPedido>>("Carrinho");
            if (carrinho == null)
                carrinho = new List<ProdutoPedido>();

            var produtoEmCarrinho = carrinho.Where(x => x.ProdutoId == id).FirstOrDefault();
            if (produtoEmCarrinho != null)
            {
                produtoEmCarrinho.Quantidade -= Quantidade;
            }
            HttpContext.Session.SetObjectAsJson("Carrinho", carrinho);

            return PartialView("_CheckoutProdutosPartial", GetChekoutModel());
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
                model.Carrinho = new PedidoCarrinho();
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
