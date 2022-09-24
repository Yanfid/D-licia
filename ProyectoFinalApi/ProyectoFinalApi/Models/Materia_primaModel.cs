using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Materia_Prima")]
    public class Materia_primaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_MPrima { get; set; }
        public DateTime FechaVencimiento { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Id_Medida { get; set; }
        public int Id_Empleado { get; set; }
        [ForeignKey("Id_Medida")]
        public virtual Uni_MedidaModel Uni_Medida { get; set; }
        [ForeignKey("Id_Empleado")]
        public virtual EmpleadoModel Empleado { get; set; }
    }
}
