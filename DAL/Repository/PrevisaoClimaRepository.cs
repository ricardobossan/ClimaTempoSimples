using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model;
using Dominio.Repository;

namespace DAL.Repository
{
    public class PrevisaoClimaRepository : IPrevisaoClimaRepository
    {
        private readonly Context _context;

        public PrevisaoClimaRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<PrevisaoClima> Get()
        {
            return _context.PrevisaoClimas.ToList();
        }

        public PrevisaoClima GetById(int id)
        {
            return _context.PrevisaoClimas.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
