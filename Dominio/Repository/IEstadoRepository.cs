using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model;

namespace Dominio.Repository
{
    public interface IEstadoRepository
    {
        IEnumerable<Estado> Get();
        Estado GetById(int id); 
    }
}
