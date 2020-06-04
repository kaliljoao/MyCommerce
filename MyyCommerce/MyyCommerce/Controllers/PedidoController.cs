using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyyCommerce.Data;
using MyyCommerce.Domain;
using MyyCommerce.Models;
using MyyCommerce.Utils;

namespace MyyCommerce.Controllers
{
    [Authorize]
    public class PedidoController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;


        public PedidoController (ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            db = context;
            _userManager = userManager;
        }

        public IActionResult Index(int? page)
        {
            return View(GetPedidoModel(page));
        }

        [HttpPost]
        public IActionResult Filtrar(string DataPedidoFilter, string ClienteIdFilter)
        {
            var filterModel = new PedidosFilterModel()
            {
                ClienteIdFilter = ClienteIdFilter,
                DataPedidoFilter = DataPedidoFilter
            };

            HttpContext.Session.SetComplexData("FilterModelPedido", filterModel);

            ModelState.Clear();

            return PartialView("_PedidosTablePartial", GetPedidoModel(1));
        }

        [HttpGet]
        public IActionResult Detalhar(int id)
        {
            Pedido Pedido = db.Pedido.Where(x => x.Id == id).Include(x => x.ApplicationUser).Include(x => x.Produtos).FirstOrDefault();

            foreach (var item in Pedido.Produtos)
            {
                item.Produto = db.Produtos.Where(x => x.Id == item.ProdutoId).FirstOrDefault();
            }

            return PartialView("_PedidoDetalhePartial", Pedido);
        }

        public PedidosViewModel GetPedidoModel (int? page)
        {
            IQueryable<Pedido> pedidos = db.Pedido.Include(x => x.ApplicationUser);

            if (User.IsInRole("Cliente"))
            {
                pedidos = pedidos.Where(x => x.ApplicationUserId == _userManager.GetUserAsync(HttpContext.User).Result.Id);
            }
            else
            {
                ViewBag.ApplicationUserId = new SelectList(db.Users.OrderBy(x => x.Nome).ToList(), "Id", "Nome");
            }

            PedidosFilterModel filterModel = HttpContext.Session.GetComplexData<PedidosFilterModel>("FilterModelPedido");
            if (filterModel != null)
            {
                if (filterModel.DataPedidoFilter != null)
                {
                    pedidos = pedidos.Where(x => x.DataPedido.Date == DateTime.ParseExact(filterModel.DataPedidoFilter, "dd/MM/yyyy", CultureInfo.CurrentCulture));
                }
                

                if (filterModel.ClienteIdFilter != null)
                {
                    pedidos = pedidos.Where(x => x.ApplicationUserId == filterModel.ClienteIdFilter);
                }
            }

            PedidosViewModel model = new PedidosViewModel(pedidos, new Pager(pedidos.Count(), page));
            return model;
        }

        public IActionResult PagarPedido(int id)
        {
            Pedido Pedido = db.Pedido.Where(x => x.Id == id).FirstOrDefault();
            Pedido.StatusPagamento = Utils.Enums.eStatusPagamento.Pago;

            if(Pedido.TipoEntrega == Utils.Enums.eTipoEntrega.Delivery)
                Pedido.StatusPedido = Utils.Enums.eStatusPedido.Pago;
            else
                Pedido.StatusPedido = Utils.Enums.eStatusPedido.EsperandoRetirada;

            db.Update(Pedido);
            db.SaveChanges();
            return PartialView("_PedidosTablePartial", GetPedidoModel(1));
        }

        public IActionResult Entregar(int id)
        {
            Pedido Pedido = db.Pedido.Where(x => x.Id == id).FirstOrDefault();
            Pedido.StatusPedido = Utils.Enums.eStatusPedido.EmRota;
            db.Update(Pedido);
            db.SaveChanges();
            return PartialView("_PedidosTablePartial", GetPedidoModel(1));
        }

        public IActionResult Retirar(int id)
        {
            Pedido Pedido = db.Pedido.Where(x => x.Id == id).FirstOrDefault();
            Pedido.StatusPedido = Utils.Enums.eStatusPedido.Retirado;
            db.Update(Pedido);
            db.SaveChanges();
            return PartialView("_PedidosTablePartial", GetPedidoModel(1));
        }

        public IActionResult Receber(int id)
        {
            Pedido Pedido = db.Pedido.Where(x => x.Id == id).FirstOrDefault();
            Pedido.StatusPedido = Utils.Enums.eStatusPedido.Entregue;
            db.Update(Pedido);
            db.SaveChanges();
            return PartialView("_PedidosTablePartial", GetPedidoModel(1));
        }

        public IActionResult Cancelar(int id)
        {
            Pedido Pedido = db.Pedido.Where(x => x.Id == id).Include(x => x.Produtos).FirstOrDefault();

            Pedido.Produtos.ForEach(produto => {
                Produto p = db.Produtos.Where(x => x.Id == produto.ProdutoId).FirstOrDefault();
                p.QtdEstoque += produto.Quantidade;
                db.Update(p);
            });

            Pedido.StatusPedido = Utils.Enums.eStatusPedido.Cancelado;
            Pedido.StatusPagamento = Utils.Enums.eStatusPagamento.Cancelada;
            db.Update(Pedido);
            db.SaveChanges();
            return PartialView("_PedidosTablePartial", GetPedidoModel(1));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
