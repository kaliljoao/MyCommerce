using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyCommerce.Data;
using MyCommerce.Models;
using MyCommerce.Utils.Enums;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyCommerce.Domain
{
    public class ApplicationUser : IdentityUser<string>
    {
        #region Construtor

        ApplicationDbContext db = new ApplicationDbContext();
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUser () { }
        public ApplicationUser(UserManager<ApplicationUser> userManager, ApplicationDbContext applicationDbContext)
        {
            _userManager = userManager;
            db = applicationDbContext;
        }

        #endregion

        #region Atributos comum aos dois usuários

        [NotMapped]
            public string Senha { get; set; }
            public eTipoUser TipoUser { get; set; }

        #endregion

        #region Atributos usuário CLIENTE

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }

            #endregion

        #region Métodos sobre Admin

        public async void Adicionar()
        {
            ApplicationUser user = db.Users.Where(x => x.Id == this.Id).FirstOrDefault();
            if (user == null)  
            {
                var result = await _userManager.CreateAsync(this, this.Senha);
                if (result.Succeeded)
                {
                    try
                    {
                        if (this.TipoUser == eTipoUser.Admin)
                            await _userManager.AddToRoleAsync(this, "Admin");
                        else
                            await _userManager.AddToRoleAsync(this, "Cliente");
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
                db.SaveChanges();
            }
        }

        public void Editar( )
        {
            try
            {
                db.Update(this);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Deletar()
        {
            try
            {
                db.Remove(this);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<ApplicationUser> ListarTodos()
        {
            return db.Users.ToList();
        }

        #endregion

        #region Métodos sobre Produto
        
        public List<Produto> ListarProdutos () {

            if (this.TipoUser == eTipoUser.Admin)
            {
                return db.Produtos.ToList();
            }
            return null;
        }

        public async void AdicionarProduto (ProdutoFormModel produtoModel) 
        {
            if (produtoModel.Produto.Fotos == null)
                produtoModel.Produto.Fotos = new List<ProdutoImage>();
            foreach (IFormFile file in produtoModel.ProdutoImage)
            {
                ProdutoImage image = new ProdutoImage();

                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    image.Image = memoryStream.ToArray();
                }
                image.Produto = produtoModel.Produto;
                produtoModel.Produto.Fotos.Add(image);
            }
            produtoModel.Produto.Ativo = true;
            
            try 
            {
                db.Add(produtoModel.Produto);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeletarProduto (int produtoId) {
            try 
            {
                db.Add(db.Produtos.Where(x => x.Id == produtoId).FirstOrDefault());
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void EditarProduto (Produto produto) {
            try 
            {
                db.Update(produto);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
   
        #region Métodos sobre Cliente 

        public List<Pedido> ListarPedidos () 
        {
            if (this.TipoUser == eTipoUser.Admin)
            {
                return db.Pedido.ToList();
            }
            else 
            {
                return db.Pedido.Where(x => x.ApplicationUserId == this.Id).ToList();
            }
        }

        #endregion
    }
}
