using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Enum;

namespace Dominio.Model
{
    public class PrevisaoClima
    {
        [Key]
        public int Id { get; set; }

        //! Apesar de string, deve ser enumerado
        [Required]
        [Column("Nome", TypeName = "VARCHAR")]
        [StringLength(15)]
        public string Clima { get; set; }

        [Required]
        public float TemperaturaMinima { get; set; }

        [Required]
        public float TemperaturaMaxima { get; set; }

        [Required]
        public DateTime DataPrevisao { get; set; }

        [Required]
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
    }
}
