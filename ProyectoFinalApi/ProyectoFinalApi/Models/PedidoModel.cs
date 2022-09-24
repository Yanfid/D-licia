using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Pedido")]
    public class PedidoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_pedido { get; set; }
        [MaxLength(100)]
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public Double Precio_total { get; set; }
        [MaxLength(100)]
        public string Direccion_envio { get; set; }
        [MaxLength(100)]
        public string Nombre_envio { get; set; }
        public int Telefono { get; set; }
        public int Id_Producto { get; set; }
        [ForeignKey("Id_Producto")]
        public virtual ProductosModel? Productos { get; set; }
    }
}
