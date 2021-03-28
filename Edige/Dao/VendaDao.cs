using Edige.Model;
using System.Collections.Generic;

namespace Edige.Dao
{
    public class VendaDao
    {
        private IList<Venda> Vendas { get; set; }

        public VendaDao()
        {
            Vendas = new List<<Venda>();
        }
    }
}
