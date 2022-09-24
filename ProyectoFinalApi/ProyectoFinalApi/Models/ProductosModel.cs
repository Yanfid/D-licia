using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Productos")]
    public class ProductosModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Producto { get; set; }
        [MaxLength(60)]
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_MPrima { get; set; }
        [ForeignKey("Id_Categoria")]
        public virtual CategoriaModel? Categoria { get; set; }
        [ForeignKey("Id_MPrima")]
        public virtual Materia_primaModel? Materia_Prima { get; set; }
    }
}
