using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Usuario
{
    public class Funcionario 
    {
        public int COD_FUNC { get; private set; }
        public string NOME_FUNC { get; private set; }
        public DateTime NASC_FUNC { get; private set; }
        public string SEXO_FUNC { get; private set; }
        public string CPF_FUNC { get; private set; }
        public virtual Contato Contato { get; private set; }
        public string CARGO_FUNC { get; private set; }
        public decimal SAL_FUNC { get; private set; }
        public DateTime DATA_ADMISSAO_FUNC { get; private set; }
        public string SENHA_FUNC { get; private set; }

        protected Funcionario() { }

        public Funcionario (string nome, DateTime dataNasc, string sexo, string cpf,string nomeCargo, 
            decimal salario,DateTime dataAdm,string senha,Contato contato)

        {
            ValidacaoValoresSetPropriedades(nome,dataNasc,sexo,cpf,nomeCargo,salario, dataAdm,senha,contato);
            
        }
        //Lembrar de rever todos os tratamentos 
        private void ValidacaoValoresSetPropriedades(string nome, DateTime dataNasc, string sexo, string cpf, string nomeCargo,
            decimal salario, DateTime dataAdm, string senha, Contato contato)
        {
            DomainException.Quando(string.IsNullOrEmpty(nome), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(sexo), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cpf), "Nome Representante Invalido");
            DomainException.Quando(cpf.Length <= 0, "Numero Invalido");
            DomainException.Quando(string.IsNullOrEmpty(senha), "Nome Representante Invalido");
            DomainException.Quando(cpf.Length <= 0, "Numero Invalido");
            DomainException.Quando(string.IsNullOrEmpty(nomeCargo), "Cargo Digitado Invalido");
            DomainException.Quando(salario <= 0, "Salario invalido");

            NOME_FUNC = nome;
            NASC_FUNC = dataNasc;
            SEXO_FUNC = sexo;
            CPF_FUNC = cpf;
            SENHA_FUNC = senha;
            CARGO_FUNC = nomeCargo;
            SAL_FUNC = salario;
            DATA_ADMISSAO_FUNC = dataAdm;

        }
         
        public void Update(string nome, DateTime dataNasc, string sexo, string cpf, string nomeCargo,
            decimal salario, DateTime dataAdm, string senha, Contato contato)

        {
            ValidacaoValoresSetPropriedades(nome, dataNasc, sexo, cpf, nomeCargo, salario, dataAdm, senha, contato);

        }

    }
}
