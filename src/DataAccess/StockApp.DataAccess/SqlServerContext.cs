namespace StockApp.DataAccess
{

    internal static class SqlServerContext
    {
        static string ConexaoSemBanco => @"Data Source=.\SQLEXPRESS;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
        static string ConexaoComBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=STOCKELETRO;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
    }
    
}
