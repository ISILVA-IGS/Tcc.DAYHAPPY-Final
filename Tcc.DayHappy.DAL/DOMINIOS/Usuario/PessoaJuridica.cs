using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Usuario
{
    public class PessoaJuridica 
    {
        public int COD_PES_JUR  { get; private set; }
        public string RAZAO_SOCIAL { get; private set; }
        public string NOME_REPRESENTANTE { get; private set; }
        public string NOME_FANTASIA { get; private set; }
        public string CNPJ { get; private set; }
        public string INSCRICAO_ESTADUAL { get; private set; }
        public virtual Contato Contato { get; private set; }


        protected PessoaJuridica() { }

        public PessoaJuridica(string razaoSocial,string representante, string nomeFantasia, string cnpj, string inscEstadual ,Contato contato,int cod_pes_jur)
        {
            ValidacaoValoresSetPropriedades(razaoSocial,representante,nomeFantasia,  cnpj, inscEstadual,contato, cod_pes_jur);

        }

        //Lembrar dos tratamentos de rever todos
        private void ValidacaoValoresSetPropriedades(string razaoSocial, string representante, string nomeFantasia, string cnpj, string inscEstadual, Contato contato,int cod_pes_jur)
        {
            DomainException.Quando(string.IsNullOrEmpty(representante), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(nomeFantasia), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cnpj), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(inscEstadual), "Nome Representante Invalido");
            DomainException.Quando(contato == null, "Preencher as infomaçoes corretamente");
            DomainException.Quando(cod_pes_jur <= 0, "ID INCORRETO");

            COD_PES_JUR = cod_pes_jur;
            RAZAO_SOCIAL = razaoSocial;
            NOME_REPRESENTANTE = representante;
            NOME_FANTASIA = nomeFantasia;
            CNPJ = cnpj;
            INSCRICAO_ESTADUAL = inscEstadual;

           

        }

        public void Update(string razaoSocial, string representante, string nomeFantasia, string cnpj, string inscEstadual,Contato contato, int cod_pes_jur)
        {
            ValidacaoValoresSetPropriedades(razaoSocial, representante, nomeFantasia, cnpj, inscEstadual,contato, cod_pes_jur);
        }

    }
}
