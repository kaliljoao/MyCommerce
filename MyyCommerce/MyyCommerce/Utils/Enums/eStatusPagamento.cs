using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyyCommerce.Utils.Enums
{
    public enum eStatusPagamento
    {
        [DefaultValue(0)]
        [Display(Name = "Aguardando pagamento")]
        AguardandoPagamento,

        [DefaultValue(1)]
        [Display(Name = "Em análise")]
        EmAnalise,

        [DefaultValue(2)]
        [Display(Name = "Paga")]
        Pago,

        [DefaultValue(3)]
        [Display(Name = "Disponível")]
        Disponível,

        [DefaultValue(4)]
        [Display(Name = "Em disputa")]
        EmDisputa,

        [DefaultValue(5)]
        [Display(Name = "Devolvida")]
        Devolvida,

        [DefaultValue(6)]
        [Display(Name = "Cancelada")]
        Cancelada

    }
}
