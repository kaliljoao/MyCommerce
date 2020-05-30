using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

        public PedidoController (ApplicationDbContext context)
        {
            db = context;
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
                pedidos = pedidos.Where(x => x.ApplicationUserId == this.User.FindFirstValue(ClaimTypes.NameIdentifier));
            }

            ViewBag.ApplicationUserId = new SelectList(db.Users.OrderBy(x => x.Nome).ToList(), "Id", "Nome");

            PedidosViewModel model = new PedidosViewModel(pedidos, new Pager(pedidos.Count(), page));
            return model;
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
