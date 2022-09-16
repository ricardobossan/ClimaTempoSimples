using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
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
            return _context.PrevisaoClimas.Include(c=> c.Cidade.Estado).ToList();
        }

        public PrevisaoClima GetById(int id)
        {
            return _context.PrevisaoClimas.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<PrevisaoClima> GetHjMax()
        {
            return _context.PrevisaoClimas
                .Where(c=> DbFunctions.TruncateTime(c.DataPrevisao) == DbFunctions.TruncateTime(DateTime.Now))
                .Include(c=> c.Cidade.Estado).ToList()
                .OrderByDescending(p=>p.TemperaturaMaxima)
                .Take(3)
                .ToList();
        }

        public IEnumerable<PrevisaoClima> GetHjMin()
        {
            return _context.PrevisaoClimas
                .Where(c=>DbFunctions.TruncateTime(c.DataPrevisao) == DbFunctions.TruncateTime(DateTime.Now))
                .Include(c=> c.Cidade.Estado)
                .ToList()
                .OrderBy(p=>p.TemperaturaMinima)
                .Take(3)
                .ToList();
        }
    }
}
