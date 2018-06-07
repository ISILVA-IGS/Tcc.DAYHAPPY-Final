using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.DAL;

namespace Tcc.DayHappy.Dominio.Armazenar
{
     public class ContatoArmazenar
    {
        private readonly IRepository<Contato> _contatoRepository;


        public ContatoArmazenar(IRepository<Contato> repository)
        {
            _contatoRepository = repository;
        }

        public void ArmazenarPF(string complemento,string referencia, string contato1, string cep, string logradouro,
            string numero, string bairro, string cidade, string contato2, string email,int fk)
        {
           

            
              var contato = new Contato(complemento,referencia,contato1, cep, logradouro, numero, bairro, cidade, contato2, email,fk);
                _contatoRepository.Create(contato);
            
          
        }
        public void ArmazenarPJ(string complemento, string referencia, string contato1, string contato2, string cep, string logradouro,
                                string numero, string bairro, string cidade, string email, int fk)
        {



            var contato = new Contato(complemento, referencia, contato1, contato2, cep, logradouro, numero, bairro, cidade, email, fk);
            _contatoRepository.Create(contato);


        }





    }
}
