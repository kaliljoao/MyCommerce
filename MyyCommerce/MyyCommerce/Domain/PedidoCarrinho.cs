using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyyCommerce.Domain
{
    public class PedidoCarrinho
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }


        public List<ProdutoCarrinho> Produtos { get; set; }
    }

    public class ProdutoCarrinho
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
