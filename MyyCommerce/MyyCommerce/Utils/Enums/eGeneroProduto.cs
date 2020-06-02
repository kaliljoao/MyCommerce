using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyyCommerce.Utils.Enums
{
    public enum eGeneroProduto
    {
        [DefaultValue(0)]
        [Display(Name = "Masculino")]
        Masculino,

        [DefaultValue(1)]
        [Display(Name = "Feminino")]
        Feminino,

        [DefaultValue(2)]
        [Display(Name = "Unissex")]
        Unissex,

        
    }
}
