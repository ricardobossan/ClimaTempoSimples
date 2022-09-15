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

        public PrevisaoClima GetById(int id)
        {
            return _previsaoClimaRepository.GetById(id);
        }
    }
}
