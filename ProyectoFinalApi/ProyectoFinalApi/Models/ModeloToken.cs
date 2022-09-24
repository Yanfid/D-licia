using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("GenerarToken")]
    public class ModeloToken
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [MaxLength(20)]
        [Required]
        public string usuario { get; set; }

        [MaxLength(10)]
        [Required]
        public string contraseña { get; set; }

        [Required]
        public bool Token { get; set; }


    }
}
