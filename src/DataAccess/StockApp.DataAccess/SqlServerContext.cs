namespace StockApp.DataAccess
{

    internal static class SqlServerContext
    {
        internal static string ConexaoSemBanco => @"server=localhost; Integrated Security=True; User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
        internal static string ConexaoComBanco => @"server=localhost;Initial Catalog=StockApp;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
    }
    
}
