using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyyCommerce.Data;
using MyyCommerce.Domain;
using MyyCommerce.Models;

namespace MyyCommerce.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, ApplicationDbContext applicationDbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            db = applicationDbContext;
        }

        //public IActionResult Perfil()
        //{
        //    ApplicationUser user = db.Users.Where(x => x.Id == this.User.FindFirstValue(ClaimTypes.NameIdentifier)).FirstOrDefault();
        //    return View(user);
        //}

        //[HttpPost]
        //public IActionResult Salvar(ApplicationUser model)
        //{
        //    ApplicationUser user = db.Users.Where(x => x.Id == this.User.FindFirstValue(ClaimTypes.NameIdentifier)).FirstOrDefault();
        //    user.Nome = model.Nome;
        //    user.Sobrenome = model.Sobrenome;
        //    user.Telefone = model.Telefone;
        //    user.Email = model.Email;
        //    user.Cep = model.Cep;
        //    user.Endereco = model.Endereco;
        //    user.Numero = model.Numero;
        //    user.Complemento = model.Complemento;
        //    db.Update(user);
        //    db.SaveChanges();
        //    return Ok();
        //}

        public IActionResult Index()
        {
            return View(GetClienteModel());
        }

        public IActionResult GetEmpty()
        {
            return PartialView("_UsersFormPartial", new ApplicationUser());
        }

        [HttpGet]
        public IActionResult OpenExisting(string id)
        {
            ApplicationUser ClienteUser = db.Users.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("_UsersFormPartial", ClienteUser);
        }


        public async Task<IActionResult> Adicionar(ApplicationUser model)
        {
            ApplicationUser user = db.Users.Where(x => x.Id == model.Id).FirstOrDefault();

            if (user == null)  //Adicionar
            {
                model.UserName = model.Email;
                model.TipoUser = Utils.Enums.eTipoUser.Admin;
                var result = await _userManager.CreateAsync(model, model.Senha);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(model, "Admin");
                }
                Log log = new Log();
                log.DataHora = DateTime.Now;
                log.UserId = _userManager.GetUserAsync(HttpContext.User).Result.Id;
                log.Mensagem = "Usuario " + model.Nome + " criado";

                db.Add(log);
            }
            else  //Editar
            {
                user.Nome = model.Nome;
                user.Telefone = model.Telefone;
                db.Update(user);
                Log log = new Log();
                log.DataHora = DateTime.Now;
                log.UserId = _userManager.GetUserAsync(HttpContext.User).Result.Id;
                log.Mensagem = "Usuario " + model.Nome + " editado";

                db.Add(log);
            }

            

            db.SaveChanges();
            ModelState.Clear();
            return PartialView("_UsersTablePartial", GetClienteModel());
        }

        public IActionResult Deletar(string id)
        {
            ApplicationUser ClienteUser = db.Users.Where(x => x.Id == id).FirstOrDefault();
            db.Remove(ClienteUser);

            Log log = new Log();
            log.DataHora = DateTime.Now;
            log.UserId = _userManager.GetUserAsync(HttpContext.User).Result.Id;
            log.Mensagem = "Usuario " + ClienteUser.Nome + " deletado";

            db.Add(log);

            db.SaveChanges();
            ModelState.Clear();
            return PartialView("_UsersTablePartial", GetClienteModel());
        }

        public UsersViewModel GetClienteModel()
        {
            ApplicationUser loggedUser = _userManager.GetUserAsync(HttpContext.User).Result;
            UsersViewModel model = new UsersViewModel() { Users = db.Users.ToList() };
            model.Users.Remove(loggedUser);
            return model;
        }

    }
}
