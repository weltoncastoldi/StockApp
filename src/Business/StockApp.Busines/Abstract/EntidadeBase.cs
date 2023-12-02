using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Busines.Abstract
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; }
        public DateTime DataAlteracao { get; }
    }
}
