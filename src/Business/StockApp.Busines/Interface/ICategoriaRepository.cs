using StockApp.Busines.Entties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Busines.Interface
{
    public interface ICategoriaRepository
    {
        bool Incluir(Categoria categoria);
        bool Atualizar (Categoria categoria);
        bool Deletar (int id);
        bool Ativar(int id);
        bool Inativar (int id);
        Categoria ObterPorId (int id);
        List<Categoria> ObterTodos (int id);
        List<Categoria> ObterTodosAtiva();
    }
}

