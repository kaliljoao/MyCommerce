using System;
using MyCommerce.Domain;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace MyCommerce.Models
{
  public class ProdutoFormModel 
  {
      public Produto Produto { get; set; }
      public List<IFormFile> ProdutoImage { get; set; }
  }
}