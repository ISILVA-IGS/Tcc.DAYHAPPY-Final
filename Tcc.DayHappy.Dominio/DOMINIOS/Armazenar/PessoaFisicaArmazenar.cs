using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.DAL
{
   public class PessoaFisicaArmazenar 
    {
        private readonly IRepository<PessoaFisica> _pessoaFisicaRepository;

        public PessoaFisicaArmazenar(IRepository<PessoaFisica> pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }

        public void Armazenar(int id, string nome, DateTime dataNasc, string sexo, string cpf, string rg, Contato contato, int cod_pes_fis)
        {
            var pessoaFisica = _pessoaFisicaRepository.GetById(id);

            if(pessoaFisica == null)
            {
                pessoaFisica = new PessoaFisica(nome, dataNasc, sexo, cpf, rg, contato, cod_pes_fis);
                _pessoaFisicaRepository.Create(pessoaFisica);
            }
            else
            {
                pessoaFisica.Update(nome, dataNasc, sexo, cpf, rg, contato, cod_pes_fis);
            }
        }

        public void Deletar(int id)
        {
            var pessoaFisica = _pessoaFisicaRepository.GetById(id);

            if (pessoaFisica.COD_PES_FIS == id)
            {
                _pessoaFisicaRepository.Delete(pessoaFisica);
            }

        }


    }
}
