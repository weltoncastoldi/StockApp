﻿using Dapper;
using Microsoft.Data.SqlClient;
using StockApp.Busines.Interface.Database;

namespace StockApp.DataAccess.Database
{
    public partial class DatabaseService : IDataBaseService
    {

        public void CriarBanco()
        {
            var sql = @"
                        IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'StockApp')
                        BEGIN
                          CREATE DATABASE StockApp
                         END
                        ";
            try
            {
                using (var conexao = new SqlConnection(SqlServerContext.ConexaoSemBanco))
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
