using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Produtos;
using Dapper;
using System.Data;
using Tcc.DayHappy.DAL;

namespace Tcc.DayHappy.Data.Repositorios
{
   public  class ProdutoRepository :  IRepository<Produto>
    {
      private const string TableName = "CADASTRO_PRODUTO";
        protected readonly string ConnectionString;

        public ProdutoRepository()
        {
            Conexao conexao = new Conexao();
            ConnectionString = conexao.GetConexao();
        }

        protected virtual IDbConnection Connection => new SqlConnection(ConnectionString);

        public void Create(Produto produto)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"INSERT INTO {TableName}(NOME_PROD,VALOR_LOCACAO_PROD,VALOR_CUSTO_PROD,FAIXA_ETARIA_INDICADA,DATA_COMPRA,DESCRICAO_PROD) VALUES(@NomeProduto,@ValorLocacao, @ValorCusto,@FaixaEtaria,@DataCompra,@Descricao,@CheckListPecas)",
                    produto);
            }
        }

        public void Delete(Produto produto)
        {
            using (var connection = Connection)
            {
                connection.Execute($"DELETE FROM {TableName} WHERE Id=@Id", new { id = 1 });
            }
        }

        public IEnumerable<Produto> GetAll()
        {  

            
            using (var connection = Connection)
            {
                
                var r = connection.Query<Produto>($" select * FROM {TableName}");
                connection.Close();
                return r;

            }
        }

        public Produto GetById(int id)
        {
            using (var connection = Connection)
            {
                return connection.QueryFirstOrDefault<Produto>($"SELECT * FROM {TableName} WHERE id=@Id",
                    new { Id = id });
            }
        }

        public void Update(Produto produto)
        {
            using (var connection = Connection)
            {
                connection.Execute(
                    $"UPDATE {TableName} SET Name=@Name, Address=@Address, Phone=@Phone, Birthday=@Birthday, Admission=@Admission, Rg=@Rg, Cpf=@Cpf, RegistrationNumber=@RegistrationNumber, Education=@Education WHERE Id=@Id",
                    produto);
            }
        }
    }
}
