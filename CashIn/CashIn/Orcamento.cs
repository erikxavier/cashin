using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashIn
{
    public partial class Orcamento
    {
        public decimal Total
        {
            get
            {
                return this.Itensorcamento.Sum(i => i.Valor != null ? (decimal)i.Valor : 0);
            }
        }

        public void TotalChanged()
        {
            this.SendPropertyChanged("Total");
        }
    }
}
