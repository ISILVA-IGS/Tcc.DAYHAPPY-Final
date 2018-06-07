using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Itinerarios;
using Tcc.DayHappy.Dominio.Produtos;

namespace Tcc.DayHappy.Data.Repositorios
{
    /*
    public class ItinerarioRepository 
    {

        private const string TableName = "Produtos";
        protected readonly string ConnectionString;


        public ItinerarioRepository(ApplicationDbContext context) : base(context)
        {

        }
        public override Itinerario GetById(int id)
        {
            var query = _context.Set<Itinerario>().Include(e => e.Id).Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }

        public override IEnumerable<Itinerario> All()
        {
            var query = _context.Set<Itinerario>().Include(p => p.Id).OrderBy(c => c.Orcamento.DataEvento);

            return query.Any() ? query.ToList() : new List<Itinerario>();
        }



    }
    */
}
