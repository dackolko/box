using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBox
{
    public class TestOrder
    {
        Order order = new Order();
        
        public void SetUp()
        {
           
        }
        public void TestAddFirst()
        {
            Product clock = new Product("1","clock", 10 );
            Product clock2 = new Product("1", "clock", 20);
            order.AddItem(clock, 1);
            Debug.Assert(order.Total()==10, "Its Ok" );
            Debug.Assert(order.GetItemProduct(clock) == 1, "Its Ok");
            Debug.Assert(order.GetTotalProduct(clock) == 10, "Its Ok");
            order.AddItem(clock2, 1);
            Debug.Assert(order.Total()==20);

        }
    }
    public class Order
    {
        public int id { get; set; }
        private Dictionary<Product, int> items = new Dictionary<Product, int>();
        
        
        public void AddItem(Product product, int quantity)
        {
            foreach(var item in items)
            {
                if (item.Key.Equals(product))
                {
                    items.Remove(item.Key);
                    break;
                }

            }
            items[product] = quantity;
        }
        public int GetItemProduct(Product product)
        {
            int count = 0;
            foreach(var item in items)
            {
                if (item.Key == product) count += item.Value;
            }
            return count;
        }
        public int GetTotalProduct(Product product)
        {
            int total = 0;
            foreach(var item in items)
            {
                if (item.Key == product) total += item.Key.Price;
            }
            return total;
        }
        public int Total()
        {
            int total = 0;
            foreach(var item in items)
            {
                total += item.Key.Price * item.Value;
            }
            return total;
        }

    }
}
