using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model;
using Dominio.Repository;

namespace DAL.Repository
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly Context _context;

        public CidadeRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Cidade> Get()
        {
            return _context.Cidades.ToList();
        }

        public Cidade GetById(int id)
        {
            return _context.Cidades.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
