using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Tcc.DayHappy.Dominio;
using Dapper;
using Tcc.DayHappy.DAL;

namespace Tcc.DayHappy.Data.Repositorios
{
   public  class ContatoRepository : IRepository<Contato>
    {
        private const string TableName = "CONTATO";
        protected readonly string ConnectionString;

        public ContatoRepository()
        {
            Conexao conexao = new Conexao();
            ConnectionString = conexao.GetConexao();
        }

        protected virtual IDbConnection Connection => new SqlConnection(ConnectionString);

        public void Create(Contato contato)
        {
            if (contato.CODPESFIS == 0)
                
            using (var connection = Connection)
            {
                connection.Execute(
                    $"INSERT INTO {TableName}(CEP,LOGRADOURO,NUMERO,COMPLEMENTO,BAIRRO,CIDADE,PONTO_REFERENCIA,CONTATO_1,CONTATO_2,EMAIL,CODPESJUR) VALUES(@CEP,@LOGRADOURO,@NUMERO,@COMPLEMENTO,@BAIRRO,@CIDADE,@PONTO_REFERENCIA,@CONTATO_1,@CONTATO_2,@EMAIL,@CODPESJUR)",
                    contato);
            }
        }

        public void Delete(Contato contato)
        {
            using (var connection = Connection)
            {
                connection.Execute($"DELETE FROM {TableName} WHERE Id=@Id", new { id = 1 });
            }
        }

        public IEnumerable<Contato> GetAll()
        {


            using (var connection = Connection)
            {

                       return connection.Query<Contato>($" select * FROM {TableName}");
               

            }
        }

        public Contato GetById(int id)
        {
            using (var connection = Connection)
            {
                return connection.QueryFirstOrDefault<Contato>($"SELECT * FROM {TableName} WHERE id=@Id",
                    new { Id = id });
            }
        }

        public void Update(Contato contato)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"UPDATE {TableName} SET Name=@Name, Address=@Address, Phone=@Phone, Birthday=@Birthday, Admission=@Admission, Rg=@Rg, Cpf=@Cpf, RegistrationNumber=@RegistrationNumber, Education=@Education WHERE Id=@Id",
                    contato);
            }
        }
    }
}