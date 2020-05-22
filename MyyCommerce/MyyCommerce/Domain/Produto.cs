using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyyCommerce.Utils.Enums;

namespace MyyCommerce.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public eCategoria Categoria { get; set; }
        public List<ProdutoImage> Fotos { get; set; }



        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Descricao { get; set; }



        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Ingredientes { get; set; }

        
        public double Valor { get; set; }
        public int QtdEstoque { get; set; }
        public bool Ativo { get; set; }

    }
}
