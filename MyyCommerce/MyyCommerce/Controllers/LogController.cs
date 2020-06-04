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
    public class LogController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;

        public LogController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            db = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(GetLogViewModel());
        }

        public LogViewModel GetLogViewModel()
        {
            return new LogViewModel() { Logs = db.Logs.Include(x => x.User).ToList() };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
