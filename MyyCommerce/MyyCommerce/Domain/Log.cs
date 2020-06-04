using System;
namespace MyyCommerce.Domain
{
    public class Log
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public String Mensagem { get; set; }
        public DateTime DataHora { get; set; }
    }
}
