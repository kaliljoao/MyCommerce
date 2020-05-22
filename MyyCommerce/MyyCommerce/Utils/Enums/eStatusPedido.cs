using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyyCommerce.Utils.Enums
{
    public enum eStatusPedido
    {
        [DefaultValue(0)]
        [Display(Name = "Pagamento Pendente")]
        PagamentoPendente,

        [DefaultValue(1)]
        [Display(Name = "Pago")]
        Pago,

        [DefaultValue(2)]
        [Display(Name = "Em Rota")]
        EmRota,

        [DefaultValue(3)]
        [Display(Name = "Entregue")]
        Entregue,

        [DefaultValue(4)]
        [Display(Name = "Cancelado")]
        Cancelado,

    }
}
