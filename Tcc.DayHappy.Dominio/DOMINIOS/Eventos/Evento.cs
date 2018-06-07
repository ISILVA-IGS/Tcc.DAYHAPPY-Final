using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Dominio.Eventos

{
   public class Evento
    {
        public int COD_ORCAMENTO { get; private set; }
        public virtual PessoaFisica COD_PES_FIS { get; private set; }
        public virtual PessoaJuridica COD_PES_JUR { get; private set; }
        public DateTime DATA_EVENTO { get; private set; }
        public DateTime HORA_INICIO_EVENTO { get; private set; }
        public DateTime HORA_FIM_EVENTO { get; private set; }
        public string TIPO_EVENTO { get; private set; }
        public decimal VALOR_FRETE { get; private set; }
        public decimal VALOR_TOTAL_SERVICO { get; private set; }
        public decimal VALOR_TOTAL_PRODUTO { get; private set; }
        public DateTime DataValidadeOrc { get; private set; }
        public string OBS_EVENTO { get; private set; }

        protected Evento() { }

        public Evento(DateTime dataEvento, DateTime horarioInicio, DateTime horarioTermino, string tipoEvento
            , decimal valorFrete, decimal valorTotalServ, decimal valorTotalProd, DateTime dataValidadeOrc, string statusOrc, PessoaFisica pessoaFisica, PessoaJuridica pessoaJuridica, string obsEvento)
        {
            ValidacaoValoresSetPropriedades( dataEvento, horarioInicio, horarioTermino, tipoEvento
           , valorFrete, valorTotalServ, valorTotalProd, dataValidadeOrc, statusOrc,pessoaFisica, pessoaJuridica,obsEvento);
        }

        //Lembrar dos tratamentos das DATAS DE EVENTO HORARIO e VALIDADE DE ORCAMENTO e STATUS ORCAMENTO
        private void ValidacaoValoresSetPropriedades(DateTime dataEvento,DateTime horarioInicio,DateTime horarioTermino, string tipoEvento
            ,Decimal valorFrete,Decimal valorTotalServ,Decimal valorTotalProd, DateTime dataValidadeOrc, string statusOrc, PessoaFisica pessoaFisica, PessoaJuridica pessoaJuridica,string obsEvento)
        {

            DomainException.Quando(valorFrete < 0, "Valor Frete Invalido");
            DomainException.Quando(valorTotalProd < 0, "Valor Frete Invalido");
            DomainException.Quando(valorTotalServ < 0, "Valor Frete Invalido");
            DomainException.Quando(pessoaFisica == null, "Cliente Invalido");
            DomainException.Quando(pessoaJuridica == null, "Cliente Invalido");

            DATA_EVENTO = dataEvento;
            HORA_INICIO_EVENTO = horarioInicio;
            HORA_FIM_EVENTO = horarioTermino;
            TIPO_EVENTO = tipoEvento;
            VALOR_FRETE = valorFrete;
            VALOR_TOTAL_SERVICO = valorTotalServ;
            VALOR_TOTAL_PRODUTO = valorTotalProd;
            DataValidadeOrc = dataValidadeOrc;
            OBS_EVENTO = obsEvento;

        }

        public void Update( DateTime dataEvento, DateTime horarioInicio, DateTime horarioTermino, string tipoEvento
            , decimal valorFrete, decimal valorTotalServ, decimal valorTotalProd, DateTime dataValidadeOrc, string statusOrc,PessoaFisica pessoaFisica,PessoaJuridica pessoaJuridica,string obsEvento)
        {
            ValidacaoValoresSetPropriedades( dataEvento, horarioInicio, horarioTermino,  tipoEvento
            ,  valorFrete,  valorTotalServ,  valorTotalProd, dataValidadeOrc, statusOrc, pessoaFisica, pessoaJuridica,obsEvento);
        }

    }
}
