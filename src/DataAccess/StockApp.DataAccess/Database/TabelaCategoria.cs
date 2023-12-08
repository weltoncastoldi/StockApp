using Dapper;
using Microsoft.Data.SqlClient;

namespace StockApp.DataAccess.Database
{
    public partial class DatabaseService
    {
        public void CriarTabelaCategoria()
        {
            var sql = @"
                        CREATE TABLE Categorias
                        (
                          Id int,
                          Nome varchar(100)
                        )
                       ";
            try
            {
                using (var conexao = new SqlConnection(SqlServerContext.ConexaoComBanco))
                {
                    //conexao.Open();
                    var resultado = conexao.Execute(sql);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
