
using Dapper;
using System.Data.SQLite;

namespace CRUD_Dapper;

public static class InicializadorBd
{
    public static void Inicializar()
    {
        using var connection = new SQLiteConnection("Data Source=ProdutoCRUD.db");
        string criarTabela = @"CREATE TABLE IF NOT EXISTS Produtos(
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Nome TEXT NOT NULL,
                                Preco REAL NOT NULL
                              );";
        connection.Execute(criarTabela);        
    }
}
