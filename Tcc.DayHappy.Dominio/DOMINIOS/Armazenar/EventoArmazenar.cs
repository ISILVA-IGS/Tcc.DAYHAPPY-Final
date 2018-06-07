using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Eventos;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.DAL
{
    public class EventoArmazenar
    {
        private readonly IRepository<Evento> _eventoRepository;
        private readonly IRepository<PessoaFisica> _pessoaFisicaRepository;
        private readonly IRepository<PessoaJuridica> _pessoaJuridicaRepository;

        public EventoArmazenar(IRepository<Evento> orcamentoRepository,
            IRepository<PessoaFisica> pessoaFisicaRepository,
            IRepository<PessoaJuridica> pessoaJuridicaRepository)
        {
            _eventoRepository = orcamentoRepository;
            _pessoaFisicaRepository = pessoaFisicaRepository;
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
        }
        public void  Armazenar(int id, DateTime dataEvento, DateTime horarioInicio, DateTime horarioTermino, string tipoEvento
            , decimal valorFrete, decimal valorTotalServ, decimal valorTotalProd, DateTime dataValidadeOrc, string statusOrc, PessoaFisica pessoaFisica, PessoaJuridica pessoaJuridica, string obsEvento)
        {
             

            var evento = _eventoRepository.GetById(id);

            if(evento == null)
            {
                evento = new Evento(dataEvento, horarioInicio, horarioTermino, tipoEvento
            , valorFrete, valorTotalServ, valorTotalProd, dataValidadeOrc, statusOrc, pessoaFisica, pessoaJuridica, obsEvento);
              //  _orcamentoRepository.Save(orcamento);

            }
            else
            {
                evento.Update(dataEvento, horarioInicio, horarioTermino,  tipoEvento
            ,  valorFrete,  valorTotalServ,  valorTotalProd, dataValidadeOrc, statusOrc, pessoaFisica, pessoaJuridica,obsEvento);
            }
        }

    }
}
