using System;
using System.Collections.Generic;
using System.Linq;
using MyyCommerce.Domain;
using MyyCommerce.Utils;

namespace MyyCommerce.Models
{
    public class PedidosViewModel
    {
        public PedidosViewModel(IQueryable<Pedido> pedidos, Pager Pager)
        {
            this.Pager = Pager;
            this.Pedidos = pedidos.Skip((this.Pager.CurrentPage - 1) * this.Pager.PageSize).Take(this.Pager.PageSize).ToList();
        }


        public List<Pedido> Pedidos { get; set; }
        public Pager Pager { get; set; }
    }

    public class PedidosFilterModel
    {
        public string DataPedidoFilter { get; set; }
        public string ClienteIdFilter { get; set; }
    }

    public class NotificacaoModel
    {
        public string notificationCode { get; set; }
        public string notificationType { get; set; }
    }
}
