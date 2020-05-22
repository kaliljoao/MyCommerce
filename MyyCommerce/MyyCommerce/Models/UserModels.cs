using System;
using System.Collections.Generic;
using MyyCommerce.Domain;

namespace MyyCommerce.Models
{
    public class UsersViewModel
    {
        public List<ApplicationUser> Users { get; set; }
    }

    public class UserFormModel
    {
        public ApplicationUser User { get; set; }
    }
}
