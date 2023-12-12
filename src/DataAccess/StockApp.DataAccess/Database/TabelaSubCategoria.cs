using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAccess.Database
{
    public partial class DatabaseService
    {
        public void CriarTabelaSubCategoria()
        {
            var sql = @"
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SubCategoria')
                BEGIN
                    CREATE TABLE SubCategoria (
                        Id int PRIMARY KEY IDENTITY,
                        CategoriaId int NOT NULL,
                        Nome varchar(100) NOT NULL,
                        Status bit DEFAULT 1,
                        DataCriacao date NOT NULL DEFAULT CURRENT_TIMESTAMP,
                        DataAlteracao date NOT NULL DEFAULT CURRENT_TIMESTAMP,
                        CONSTRAINT fk_SubCategoria_Categoria
                            FOREIGN KEY (CategoriaId)
                            REFERENCES Categorias(Id) ON DELETE CASCADE
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
