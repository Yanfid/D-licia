using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Uni_Medida")]
    public class Uni_MedidaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Medida { get; set; }
        [MaxLength(100)]
        public string T_Medida { get; set; }
    }
}