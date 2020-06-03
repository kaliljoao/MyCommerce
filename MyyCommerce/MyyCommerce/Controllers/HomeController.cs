using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyyCommerce.Data;
using MyyCommerce.Domain;
using MyyCommerce.Models;
using Microsoft.AspNetCore.Http;
using MyyCommerce.Utils;
using MyyCommerce.Utils.Enums;
using Microsoft.AspNetCore.Identity;

namespace MyyCommerce.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            db = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(eCategoria? Categoria, int? page)
        {

            if(HttpContext.Session.GetObjectFromJson<PedidoCarrinho>("CarrinhoDb") == null)
                HttpContext.Session.SetComplexData("CarrinhoDb", db.PedidosCarrinho.Where(x => x.UserId == _userManager.GetUserAsync(HttpContext.User).Result.Id)
                    .Include(x => x.Produtos)
                );

            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Pedido");
            }

            if (Categoria != null)
            {
                IQueryable<Produto> produtos = db.Produtos.Where(x => x.Ativo == true && x.QtdEstoque > 0).Include(x => x.Fotos);
            
                if (Categoria != null)
                {
                    produtos = produtos.Where(x => x.Categoria == Categoria.Value);
                }

                HomeViewModel model = new HomeViewModel(produtos, new Pager(produtos.Count(), page), Categoria);
                return View(model);
            }
            else
            {
                IQueryable<Produto> produtos = db.Produtos.Where(x => x.Ativo == true && x.QtdEstoque > 0).Include(x => x.Fotos);
                return View(new HomeViewModel());
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
