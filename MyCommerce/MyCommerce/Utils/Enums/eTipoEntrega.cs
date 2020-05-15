using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyCommerce.Utils.Enums
{
    public enum eTipoEntrega
    {
        [DefaultValue(0)]
        [Display(Name = "Retirar na loja física")]
        Retirada,

        [DefaultValue(1)]
        [Display(Name = "Receber em casa até 20h")]
        Delivery

    }
}
