using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyCommerce.Utils.Enums
{
    public enum eCategoria
    {
        [DefaultValue(0)]
        [Display(Name = "Pães Sourdoughs")]
        PaesSourdough,

        [DefaultValue(1)]
        [Display(Name = "Pães clássicos")]
        PaesClassicos,

        [DefaultValue(2)]
        [Display(Name = "Mercado")]
        Mercado,

        [DefaultValue(3)]
        [Display(Name = "Empório Slow")]
        Emporio
    }
}
