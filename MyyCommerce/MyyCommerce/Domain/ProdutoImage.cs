using System;
namespace MyyCommerce.Domain
{
    public class ProdutoImage
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
