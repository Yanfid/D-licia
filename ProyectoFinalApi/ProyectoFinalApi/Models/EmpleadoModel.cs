using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Empleado")]
    public class EmpleadoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Empleado { get; set; }
        [MaxLength(50)]
        public string Nombres { get; set; }
        [MaxLength(50)]
        public string Apellidos { get; set; }
        [MaxLength(200)]
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Id_Cargo { get; set; }
        [ForeignKey("Id_Cargo")]
        public virtual CargoModel? Cargo { get; set; }

    }
}
    