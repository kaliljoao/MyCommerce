using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyyCommerce.Utils.Enums
{
    public enum eCategoria
    {
        [DefaultValue(0)]
        [Display(Name = "Camisa")]
        Camisa,

        [DefaultValue(1)]
        [Display(Name = "Bermuda")]
        Bermuda,

        [DefaultValue(2)]
        [Display(Name = "Acessório")]
        Acessorio,

        [DefaultValue(3)]
        [Display(Name = "Calçados")]
        Calcado
    }
}
