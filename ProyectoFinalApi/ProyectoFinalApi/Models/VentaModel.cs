using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Venta")]
    public class VentaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Venta { get; set; }
        public DateTime fecha { get; set; }
        public int Id_Pedido { get; set; }
        [ForeignKey("Id_Pedido")]
        public virtual PedidoModel? Pedido { get; set; }
    }
}
