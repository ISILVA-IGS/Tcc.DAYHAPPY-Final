using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Eventos;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Dominio.Itinerarios
{
   public class Itinerario 
    {
        public int COD_ITINERARIO { get; private set; }
        public virtual Funcionario COD_FUNC { get; private set; }
        public string CAR_NUM_MODELO { get; private set; }
        public DateTime HORA_SAIDA_CAR { get; private set; }
        public virtual Evento COD_EVENTO { get; private set; }
      
        protected Itinerario() { }

        public Itinerario(string modeloCarro, DateTime horarioSaida, Evento evento, Funcionario funcionario)
        {

            ValidacaoValoresSetPropriedades(modeloCarro, horarioSaida, evento,funcionario);
        }
        private void ValidacaoValoresSetPropriedades( string modeloCarro, DateTime horarioSaida, Evento evento , Funcionario funcionario)
        {
            DomainException.Quando(string.IsNullOrEmpty(modeloCarro), "Modelo do Carro Digitado Invalido");
            DomainException.Quando(evento == null, "Orçamento não foi completado corretamente");
            DomainException.Quando(funcionario == null, "Orçamento não foi completado corretamente");
            //tratar data 


            COD_EVENTO = evento;
            CAR_NUM_MODELO = modeloCarro;
            HORA_SAIDA_CAR = horarioSaida;
        }
        public void Update(string modeloCarro, DateTime horarioSaida, Evento evento, Funcionario funcionario)
        {
            ValidacaoValoresSetPropriedades( modeloCarro, horarioSaida, evento,funcionario);
        }

    }
}
