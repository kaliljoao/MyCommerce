using System;
using MyyCommerce.Domain;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using MyyCommerce.Utils;
using MyyCommerce.Utils.Enums;
using Microsoft.AspNetCore.Mvc;

namespace MyyCommerce.Models
{
    public class ProdutoFormModel 
    {
        public Produto Produto { get; set; }
        public List<IFormFile> ProdutoImage { get; set; }
    }

    public class ProdutoViewModel
    {
        public ProdutoViewModel(IQueryable<Produto> produtos, Pager Pager)
        {
            this.Pager = Pager;
            this.Produtos = produtos.Skip((this.Pager.CurrentPage - 1) * this.Pager.PageSize).Take(this.Pager.PageSize).ToList();
        }

        public List<Produto> Produtos { get; set; }
        public Pager Pager { get; set; }
    }

    public class ProdutoFilterModel
    {
        public string FilterNome { get; set; }
        public eCategoria? FilterCategoria { get; set; }
        public eGeneroProduto? FilterGenero{ get; set; }
        public bool? FilterAtivo { get; set; }
    }


    public class ProdutoDetalheModel
    {
        public Produto ProdutoBack { get; set; }
        public Produto ProdutoForward { get; set; }
        public Produto Produto { get; set; }
        public List<FileResult> Imagens { get; set; }
    }
}