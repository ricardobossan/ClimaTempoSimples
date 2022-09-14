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
        public int Id;

        //! Apesar de string, deve ser enumerado
        [Required]
        [Column("Clima", TypeName = "Varchar(15)")]
        public string Clima;

        [Required]
        public float TemperaturaMinima;

        [Required]
        public float TemperaturaMaxima;

        [Required]
        public DateTime DataPrevisao;

        [Required]
        public int CidadeId;
        public Cidade Cidade;
    }
}
