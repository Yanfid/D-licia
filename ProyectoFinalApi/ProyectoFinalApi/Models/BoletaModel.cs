using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Boleta")]
    public class BoletaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Boleta { get; set; }
        public int Id_Venta { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        [ForeignKey("Id_Venta")]
        public virtual VentaModel? Venta { get; set; }
    }
}
