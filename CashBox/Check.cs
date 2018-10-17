using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBox
{
    public abstract class Check
    {
        private Order order;
        public Check(Order order)
        {
            this.order = order;
        }
        public abstract void Execute();
        
        
        
    }
}
