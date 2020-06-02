using MyyCommerce.Domain;
using MyyCommerce.Utils.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyyCommerce.Models
{
    public class CheckoutViewModel
    {
        public PedidoCarrinho Carrinho { get; set; }
        public List<ProdutoPedido> Produtos { get; set; }
        public double ValorTotal { get; set; }
        public double PrecoEntrega { get; set; }
        public double PrecoFinal { get; set; }
        public eTipoEntrega TipoEntrega { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string CepEntrega { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string BairroEntrega { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string EnderecoEntrega { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string NumEntrega { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string ComplementoEntrega { get; set; }

        public string DataEntrega { get; set; }
        public string NumeroCartao { get; set; }
        public string ValidadeCartaoMes { get; set; }
        public string ValidadeCartaoAno { get; set; }
        public string CvvCartao { get; set; }
        public string NomeCartao { get; set; }
        public string CpfCartao { get; set; }
        public string DataNascimentoCartao { get; set; }
        public string TelefoneCartao { get; set; }
        public string CepPagamento { get; set; }
        public string EstadoPagamento { get; set; }
        public string CidadePagamento { get; set; }
        public string BairroPagamento { get; set; }
        public string EnderecoPagamento { get; set; }
        public string NumeroPagamento { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string ComplementoPagamento { get; set; }
        public string PagseguroSession { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Observacao { get; set; }
        public string ProdutoString { get; set; }
        public string creditCardToken { get; set; }
        public string senderHash { get; set; }
    }

}
