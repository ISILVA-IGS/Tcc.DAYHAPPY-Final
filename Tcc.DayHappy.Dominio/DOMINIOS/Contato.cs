using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio
{
   public class Contato
    {
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Contato_1 { get; private set; }
        public string Contato_2 { get; private set; }
        public string Email { get; private set; }
        public string PONTO_REFERENCIA { get; private set; }
        public string Cep { get; private set; }
        public int CODPESFIS { get; private set; }
        public int CODPESJUR { get; private set; }
        public int CODFUNC { get; private set; }
    
        protected Contato() { }

        public Contato(string complemento,string referencia, string contato1, string cep, string logradouro,
            string numero, string bairro, string cidade, string contato2, string email,int cODPESFIS,int cODPESJUR, int cODFUNC)
        {
           ValidadcaoESetValores(contato1, cep, logradouro, numero, bairro, cidade, contato2, email);
            CODPESFIS = cODPESFIS;
            CODPESJUR = cODPESJUR;
            CODFUNC = cODFUNC;
            Complemento = complemento;
            PONTO_REFERENCIA = referencia;
        }

        public Contato(string complemento, string referencia, string contato1, string contato2, string cep, string logradouro,
          string numero, string bairro, string cidade, string email, int cODPESJUR)
        {
            ValidadcaoESetValores(contato1, cep, logradouro, numero, bairro, cidade, contato2, email);
            CODPESJUR = cODPESJUR;
            Complemento = complemento;
            PONTO_REFERENCIA = referencia;
          
        }


        public void ValidadcaoESetValores(string contato1, string cep, string logradouro, string numero, string bairro, string cidade, string contato2, string email)
        {
            DomainException.Quando(string.IsNullOrEmpty(cep), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(logradouro), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(numero), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(bairro), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cidade), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(contato1.ToString()), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(contato1.ToString()), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(email), "Nome Representante Invalido");

            Contato_1 = contato1;
            Contato_2 = contato2;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Email = email;


        }

        public void Update(string referencia, string contato1, string cep, string logradouro,
            string numero, string bairro, string cidade, string contato2, string email)
        {
            ValidadcaoESetValores(contato1, cep, logradouro, numero, bairro, cidade, contato2, email);
            PONTO_REFERENCIA = referencia;
        }

    }
}
