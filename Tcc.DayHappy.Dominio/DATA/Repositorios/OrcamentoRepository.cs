using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tcc.DayHappy.DAL
{
    /*
    public class OrcamentoRepository : Repository<Orcamento>
    {
        public OrcamentoRepository(ApplicationDbContext context) : base(context)
        {

        }
        public override Orcamento GetById(int id)
        {
            var query = _context.Set<Orcamento>().Include(e => e.Id).Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }

        public override IEnumerable<Orcamento> All()
        {
            var query = _context.Set<Orcamento>().Include(p => p.Id).OrderBy(c => c.DataEvento);

            return query.Any() ? query.ToList() : new List<Orcamento>();
        }



    }
    */
}
