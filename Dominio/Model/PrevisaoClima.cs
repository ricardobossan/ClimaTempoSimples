using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public float TemperaturaMaxima;

        [Required]
        public DateTime DataPrevisao;

        [Required]
        public int CidadeId;
        public Cidade Cidade;
    }
}
