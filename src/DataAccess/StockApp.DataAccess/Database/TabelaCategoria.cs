using Dapper;
using Microsoft.Data.SqlClient;

namespace StockApp.DataAccess.Database
{
    public partial class DatabaseService
    {
        public void CriarTabelaCategoria()
        {
            var sql = @"
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Categorias')
                    BEGIN
                            CREATE TABLE Categorias
                            (
                              Id int PRIMARY KEY IDENTITY,
                              Nome varchar(100),
                              Status bit,
                              DataCriacao date,
                              DataAlteracao date,
                            );
                    END;";
            try
            {
                using (var conexao = new SqlConnection(SqlServerContext.ConexaoComBanco))
                {
                    conexao.Open();
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
