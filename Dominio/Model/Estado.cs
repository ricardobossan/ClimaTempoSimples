using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class Estado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Nome", TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [Column("Uf", TypeName = "VARCHAR")]
        [StringLength(2)]
        public string UF { get; set; }
    }
}
