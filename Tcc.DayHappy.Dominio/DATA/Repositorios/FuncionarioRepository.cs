using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Data.Repositorios
{
    /*
    public class FuncionarioRepository : Repository<Funcionario>
    {
        public FuncionarioRepository(ApplicationDbContext context) : base(context)
        {

        }

        public override Funcionario GetById(int id)
        {
            var query = _context.Set<Funcionario>().Include(p => p.Id).Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }

        public override IEnumerable<Funcionario> All()
        {
            var query = _context.Set<Funcionario>()
                .Include(i => i.Id)
                .OrderBy(c => c.Nome);

            return query.Any() ? query.ToList() : new List<Funcionario>();
        }


    }
    */
}
