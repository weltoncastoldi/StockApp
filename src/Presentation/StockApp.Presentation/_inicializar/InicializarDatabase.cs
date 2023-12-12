using StockApp.Busines.Interface.Database;
using StockApp.DataAccess.Database;

namespace StockApp.WindowsForms._inicializar
{
    internal class InicializarDatabase
    {
        private readonly IDataBaseService _databaseService;

        public InicializarDatabase()
        {
            _databaseService = new DatabaseService();
        }

        internal void Init()
        {
            _databaseService.CriarBanco();
            _databaseService.CriarTabelaCategoria();
            _databaseService.CriarTabelaSubCategoria();
        }
    }
}
