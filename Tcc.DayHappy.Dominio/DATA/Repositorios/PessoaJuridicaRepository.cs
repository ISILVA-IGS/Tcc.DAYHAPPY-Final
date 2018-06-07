using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Usuario;
using Dapper;
using Tcc.DayHappy.DAL;

namespace Tcc.DayHappy.Data.Repositorios
{
    
   public  class PessoaJuridicaRepository : IRepository<PessoaJuridica>
    {
        private const string TableName = "CADASTRO_PESSOA_JURIDICA";
        protected readonly string ConnectionString;

        public PessoaJuridicaRepository()
        {
            Conexao conexao = new Conexao();
            ConnectionString = conexao.GetConexao();

        }

        protected virtual IDbConnection Connection => new SqlConnection(ConnectionString);

        public void Create(PessoaJuridica pessoaJuridica)
        {
          
            using (var connection = Connection)
            {
                connection.Execute(
                    $"INSERT INTO {TableName}(RAZAO_SOCIAL,NOME_REPRESENTANTE,NOME_FANTASIA," +
                    $"CNPJ_PES_JUR,INSCRICAO_ESTADUAL,SENHA_PES_JUR) VALUES(@RAZAO_SOCIAL,@NOME_REPRESENTANTE," +
                    $"@NOME_FANTASIA,@CNPJ,@INSCRICAO_ESTADUAL,@SENHA_PES_JUR)",
                    pessoaJuridica);
            }
        }

        public void Delete(PessoaJuridica pessoaJuridica)
        {
            using (var connection = Connection)
            {
                connection.Execute($"DELETE FROM {TableName} WHERE Id=@Id", new { id = 1 });
            }
        }

        public IEnumerable<PessoaJuridica> GetAll()
        {


            using (var connection = Connection)
            {

                return connection.Query<PessoaJuridica>($" select * FROM {TableName}");

            }
        }

        public PessoaJuridica GetById(int id)
        {
            using (var connection = Connection)
            {
                return connection.QueryFirstOrDefault<PessoaJuridica>($"SELECT * FROM {TableName} WHERE id=@Id",
                    new { Id = id });
            }
        }

        public void Update(PessoaJuridica pessoaJuridica)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"UPDATE {TableName} SET Name=@Name, Address=@Address, Phone=@Phone, Birthday=@Birthday," +
                    $" Admission=@Admission, Rg=@Rg, Cpf=@Cpf, RegistrationNumber=@RegistrationNumber," +
                    $" Education=@Education WHERE Id=@Id",
                    pessoaJuridica);
            }
        }

        public PessoaFisica Pesquisa()
        {
            using (var connection = Connection)
            {
                return connection.QueryFirstOrDefault<PessoaFisica>($"SELECT TOP 1 Id FROM {TableName} order by Id desc");
            }
        }
    }
}