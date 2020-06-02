using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyyCommerce.Domain;

namespace MyyCommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<ProdutoImage> ProdutosImages { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<ProdutoPedido> ProdutosPedido { get; set; }
        public virtual DbSet<PedidoCarrinho> PedidosCarrinho { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
