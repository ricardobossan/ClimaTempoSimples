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
    public class CidadeService : ICidadeService
    {
        private ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
        {
            this._cidadeRepository = cidadeRepository;
        }

        public IEnumerable<Cidade> Get()
        {
            return _cidadeRepository.Get();
        }

        public Cidade GetById(int id)
        {
            return _cidadeRepository.GetById(id);
        }
    }
}
