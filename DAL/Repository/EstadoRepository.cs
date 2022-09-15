using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model;
using Dominio.Repository;

namespace DAL.Repository
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly Context _context;

        public EstadoRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Estado> Get()
        {
            return _context.Estados.ToList();
        }

        public Estado GetById(int id)
        {
            return _context.Estados.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
