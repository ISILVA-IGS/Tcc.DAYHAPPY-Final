using System;
using System.Collections.Generic;
using System.Text;


namespace Tcc.DayHappy.Dominio.Usuario
{
   public class PessoaFisica 
    {
        public int COD_PES_FIS { get; private set; }
        public string NOME_PES_FIS { get; private set; }
        public DateTime NASC_PES_FIS { get; private set; }
        public string SEXO_PES_FIS { get; private set; }
        public string CPF_PES_FIS { get; private set; }
        public string RG_PES_FIS { get; private set; }
        public Contato Contato { get; private set; }




        protected PessoaFisica() {}

        public PessoaFisica(string nome, DateTime dataNasc, string sexo, string cpf, string rg, Contato contato, int cod_pes_fis)
        {
            ValidacaoValoresSetPropriedades(nome,dataNasc,sexo,cpf,rg,contato, cod_pes_fis);
           
        }
        //Lembrar de rever todos os tratamentos 
        private  void ValidacaoValoresSetPropriedades(string nome, DateTime dataNasc, string sexo, string cpf, string rg,Contato contato, int cod_pes_fis)
        {
            DomainException.Quando(string.IsNullOrEmpty(nome), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(sexo), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cpf), "Nome Representante Invalido");
            DomainException.Quando(cpf.Length <= 0, "Numero Invalido");
            DomainException.Quando(string.IsNullOrEmpty(rg), "Nome Representante Invalido");
            DomainException.Quando(cpf.Length <= 0, "Numero Invalido");
            DomainException.Quando(contato == null, "Preencher os campos corretamente");
            DomainException.Quando(cod_pes_fis <= 0, "ID INCORRETO");

            COD_PES_FIS = cod_pes_fis;
            NOME_PES_FIS = nome;
            NASC_PES_FIS = dataNasc;
            SEXO_PES_FIS = sexo;
            CPF_PES_FIS = cpf;
            RG_PES_FIS = rg;
          
        }

        public void Update(string nome, DateTime dataNasc, string sexo, string cpf, string rg , Contato contato, int cod_pes_fis)
        {
            ValidacaoValoresSetPropriedades(nome, dataNasc, sexo, cpf, rg,contato, cod_pes_fis);
        }
    }
}
