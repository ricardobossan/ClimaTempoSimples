using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model;

namespace Dominio.Services
{
    public interface IPrevisaoClimaService
    {
        IEnumerable<PrevisaoClima> Get();
        IEnumerable<PrevisaoClima> GetChosenCity(int id);
        IEnumerable<PrevisaoClima> GetHjMax();
        IEnumerable<PrevisaoClima> GetHjMin();
    }
}
