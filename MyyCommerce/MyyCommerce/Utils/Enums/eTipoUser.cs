﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyyCommerce.Utils.Enums
{
    public enum eTipoUser
    {
        [DefaultValue(0)]
        [Display(Name = "Admin")]
        Admin,

        [DefaultValue(1)]
        [Display(Name = "Cliente")]
        Cliente
    }
}
