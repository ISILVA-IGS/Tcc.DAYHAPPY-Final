using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Eventos;
using Tcc.DayHappy.Dominio.Itinerarios;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.DAL
{
    public class ItinerarioArmazenar
    {
        private readonly IRepository<Itinerario> _itinerarioRepository;

        public ItinerarioArmazenar(IRepository<Itinerario> itinerarioRepository)
        {
            _itinerarioRepository = itinerarioRepository;
        }

        public void Armazenar(int id ,string modeloCarro, DateTime horarioSaida, Evento evento, Funcionario funcionario)
        {
            var itinerario = _itinerarioRepository.GetById(id);

            if(itinerario == null)
            {
                itinerario = new Itinerario(modeloCarro, horarioSaida, evento, funcionario);
              //  _itinerarioRepository.Save(itinerario);
            }
            else
            {
                itinerario.Update(modeloCarro, numCarro, horarioSaida, evento);
            }
        }
    }
}
