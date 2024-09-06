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
        public void AdicionarContrib(Produto p)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Produto>(p);
        }
        public List<Produto> ListarProdutos()
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.GetAll<Produto>().ToList();
        }
        public Produto BuscarProduto(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.Get<Produto>(id);
        }
        public void Editar(Produto p)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Update<Produto>(p);
        }
        public void Delete(int id) {
            using var connection = new SQLiteConnection(_connectionString);
            Produto novoProduto = BuscarProduto(id);
            connection.Delete<Produto>(novoProduto);
        }
    }
}
