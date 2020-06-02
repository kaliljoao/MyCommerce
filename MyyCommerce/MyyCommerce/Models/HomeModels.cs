using System;
using System.Collections.Generic;
using System.Linq;
using MyyCommerce.Domain;
using MyyCommerce.Utils;
using MyyCommerce.Utils.Enums;

namespace MyyCommerce.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {

        }

        public HomeViewModel(IQueryable<Produto> produtos, Pager Pager, eCategoria? Categoria)
        {
            this.Pager = Pager;
            this.Produtos = produtos.ToList();
            this.Categoria = Categoria;
        }
        public List<Produto> Produtos { get; set; }
        public Pager Pager { get; set; }
        public eCategoria? Categoria { get; set; }
    }
}
