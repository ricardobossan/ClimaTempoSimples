using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model;

namespace Dominio.Repository
{
    public interface ICidadeRepository
    {
        IEnumerable<Cidade> Get();
        Cidade GetById(int id); 
    }
}
