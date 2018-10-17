using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBox
{
    interface IDBStock
    {
        void Insert(Product product);
        Product Find(string sku);
        bool Deleted(string sku, int quantity);
    }
}
