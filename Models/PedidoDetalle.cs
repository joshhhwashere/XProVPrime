using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrecosApi.Models
{
    public class PedidoDetalle
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey(nameof(Pedido))]
        public int PedidoId { get; set; }

        public Pedido Pedido { get; set; }

        [ForeignKey (nameof(Producto))]
        public int ProductoId { get; set; }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }        
        public decimal Costo { get; set; }
    }
}
