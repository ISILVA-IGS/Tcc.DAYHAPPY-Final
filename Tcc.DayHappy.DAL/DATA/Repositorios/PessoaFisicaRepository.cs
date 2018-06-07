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
    
   public class PessoaFisicaRepository : IRepository<PessoaFisica>
    {
        private const string TableName = "CADASTRO_PESSOA_FISICA";
        protected readonly string ConnectionString;

        public PessoaFisicaRepository()
        {
            Conexao conexao = new Conexao();
            ConnectionString = conexao.GetConexao();
        }

        protected virtual IDbConnection Connection => new SqlConnection(ConnectionString);

        public void Create(PessoaFisica pessoaFisica)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"INSERT INTO {TableName}(NOME_PES_FIS,SEXO_PES_FIS,NASC_PES_FIS,CPF_PES_FIS,RG_PES_FIS,SENHA_PES_FIS) VALUES(@NOME_PES_FIS,@SEXO_PES_FIS,@NASC_PES_FIS,@CPF_PES_FIS,@RG_PES_FIS,@SENHA_PES_FIS)",
                    pessoaFisica);
            }
        }

        public void Delete(PessoaFisica pessoaFisica)
        {
            using (var connection = Connection)
            {
                connection.Execute($"DELETE FROM {TableName} WHERE Id=@Id", new { id = 1 });
            }
        }

        public IEnumerable<PessoaFisica> GetAll()
        {


            using (var connection = Connection)
            {

                return connection.Query<PessoaFisica>($" select * FROM {TableName}");

            }
        }

        public PessoaFisica GetById(int id)
        {
            using (var connection = Connection)
            {
                return connection.QueryFirstOrDefault<PessoaFisica>($"SELECT * FROM {TableName} WHERE id=@Id",
                    new { Id = id });
            }
        }

        public void Update(PessoaFisica produto)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"UPDATE {TableName} SET Name=@Name, Address=@Address, Phone=@Phone, Birthday=@Birthday, Admission=@Admission, Rg=@Rg, Cpf=@Cpf, RegistrationNumber=@RegistrationNumber, Education=@Education WHERE Id=@Id",
                    produto);
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