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
    public class EstadoService : IEstadoService
    {
        private IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            this._estadoRepository = estadoRepository;
        }

        public IEnumerable<Estado> Get()
        {
            return _estadoRepository.Get();
        }

        public Estado GetById(int id)
        {
            return _estadoRepository.GetById(id);
        }
    }
}
