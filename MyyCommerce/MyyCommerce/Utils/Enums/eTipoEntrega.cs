using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyyCommerce.Utils.Enums
{
    public enum eTipoEntrega
    {
        [DefaultValue(0)]
        [Display(Name = "Retirar na loja física")]
        Retirada,

        [DefaultValue(1)]
        [Display(Name = "Receber por Delivery")]
        Delivery

    }
}
