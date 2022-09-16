using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model;

namespace Dominio.Repository
{
    public interface IPrevisaoClimaRepository
    {
        IEnumerable<PrevisaoClima> Get();
        PrevisaoClima GetById(int id);
        IEnumerable<PrevisaoClima> GetHjMax();
        IEnumerable<PrevisaoClima> GetHjMin();
    }
}
