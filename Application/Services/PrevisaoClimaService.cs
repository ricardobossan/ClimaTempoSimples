using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model;
using Dominio.Repository;
using Dominio.Services;

namespace Application.Services
{
    public class PrevisaoClimaService : IPrevisaoClimaService
    {
        private IPrevisaoClimaRepository _previsaoClimaRepository;

        public PrevisaoClimaService(IPrevisaoClimaRepository previsaoClimaRepository)
        {
            this._previsaoClimaRepository = previsaoClimaRepository;
        }

        public IEnumerable<PrevisaoClima> Get()
        {
            return _previsaoClimaRepository.Get();
        }

        public IEnumerable<PrevisaoClima> GetChosenCity(int id)
        {
IEnumerable<PrevisaoClima> previsoes =  _previsaoClimaRepository.GetChosenCity(id);
foreach(PrevisaoClima p in previsoes)
            {
                p.DayOfWeek = p.DataPrevisao.DayOfWeek.ToString();
            }
            return previsoes;
        }

        public IEnumerable<PrevisaoClima> GetHjMax()
        {
            return _previsaoClimaRepository.GetHjMax();
        }

        public IEnumerable<PrevisaoClima> GetHjMin()
        {
            return _previsaoClimaRepository.GetHjMin();
        }
    }
}
