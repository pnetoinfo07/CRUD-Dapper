using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;

namespace CRUD_Dapper
{
    public class ProdutoRepository
    {
        public readonly string _connectionString;
        public ProdutoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Produto p)
        {
            using var connection = new SQLiteConnection(_connectionString);
            string commandInsert = @"INSERT INTO Produtos (Nome,Preco) 
                                     VALUES (@Nome,@Preco)";
            connection.Execute(commandInsert, p);
        }

        public void AdicionarContrib(Produto p)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Produto>(p);
        }
    }
}
