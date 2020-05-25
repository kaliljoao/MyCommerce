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
using MyyCommerce.Utils;
using MyyCommerce.Utils.Enums;

namespace MyyCommerce.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index(eCategoria? Categoria, int? page)
        {
            IQueryable<Produto> produtos = db.Produtos.Where(x => x.Ativo == true && x.QtdEstoque > 0).Include(x => x.Fotos);

            if (Categoria != null)
            {
                produtos = produtos.Where(x => x.Categoria == Categoria.Value);
            }

            HomeViewModel model = new HomeViewModel(produtos, new Pager(produtos.Count(), page), Categoria);
            return View(model);
        }

        [HttpPost]
        public IActionResult Filtrar(string busca, eCategoria? Categoria)
        {
            IQueryable<Produto> produtos = db.Produtos.Where(x => x.Ativo == true && x.QtdEstoque > 0).Include(x => x.Fotos);

            if (Categoria != null)
            {
                produtos = produtos.Where(x => x.Categoria == Categoria.Value);
            }
            if (busca != null)
            {
                produtos = produtos.Where(x => x.Nome.ToUpper().Contains(busca.ToUpper()));
            }

            HomeViewModel model = new HomeViewModel(produtos, new Pager(produtos.Count(), null), Categoria);

            return PartialView("_VitrinePartial", model);
        }

        public IActionResult OndeEncontrar()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
