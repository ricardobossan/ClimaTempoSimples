using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class Cidade
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Column("Nome", TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

    }
}
