using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.DAL
{
    /*
    public class FuncionarioArmazenar 
    {
        private readonly IRepository<Funcionario> _funcionarioRepository;

        public FuncionarioArmazenar(IRepository<Funcionario> funcionarioRepostory)
        {
            _funcionarioRepository = funcionarioRepostory;
        }

        public void Armazenar(int id, string nome, DateTime dataNasc, string sexo, string cpf, string rg, string nomeCargo,
            decimal salario, DateTime dataAdm, int contato1, string cep, string logradouro,
            string numero, string bairro, string cidade, int contato2, string email, string referencia)
        {
            var funcionario = _funcionarioRepository.GetById(id);

            if(funcionario == null)
            {
                funcionario = new Funcionario(nome,dataNasc,sexo,cpf,rg, nomeCargo,
                              salario,dataAdm, referencia,contato1,cep,logradouro,
                              numero,bairro, cidade, contato2,email);
                _funcionarioRepository.Save(funcionario);
            }
            else
            {
                funcionario.Update(nome, dataNasc, sexo, cpf, rg, nomeCargo,
                              salario, dataAdm, referencia, contato1, cep, logradouro,
                              numero, bairro, cidade, contato2, email);
            }
        }
    }
    */
}
