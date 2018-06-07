using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.DAL;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Dominio.Storer
{
    public class PessoaJuridicaArmazenar 
    {
        private readonly IRepository<PessoaJuridica> _pessoaJuridicaRepository;

        public PessoaJuridicaArmazenar( IRepository<PessoaJuridica> pessoaJuridicaRepository)
        {
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
        }

        public void Armazenar(int id, string razaoSocial, string representante, string nomeFantasia, string cnpj, string inscEstadual)
        {
            var pessoaJuridica = _pessoaJuridicaRepository.GetById(id);

            if(pessoaJuridica == null)
            {
                pessoaJuridica = new PessoaJuridica(razaoSocial, representante, nomeFantasia, cnpj, inscEstadual);
                  _pessoaJuridicaRepository.Create(pessoaJuridica);
            }
            else
            {
                pessoaJuridica.Update(razaoSocial, representante, nomeFantasia, cnpj, inscEstadual);
            } 
               
        }

    }
}
