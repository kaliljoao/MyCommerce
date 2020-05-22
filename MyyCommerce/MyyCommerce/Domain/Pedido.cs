using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyyCommerce.Utils.Enums;

namespace MyyCommerce.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public eTipoEntrega TipoEntrega { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Cep { get; set; }



        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Endereco { get; set; }



        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Numero { get; set; }



        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Complemento { get; set; }

        
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public eStatusPedido StatusPedido { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<ProdutoPedido> Produtos { get; set; }

        public bool isFinalizado { get; set; }
    }
}
