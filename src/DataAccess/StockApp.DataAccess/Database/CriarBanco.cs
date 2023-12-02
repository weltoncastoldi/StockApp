using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAccess.Database
{
    public static class CriarBanco
    {
        public static void Executar()
        {
            var sql = @"
                        IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'StockApp')
                        BEGIN
                          CREATE DATABASE StockApp
                         END
                        ";
        }
    }
}
