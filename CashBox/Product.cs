using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBox
{
    
    public class ProductTest
    {
        public ProductTest() { }
        public void SetUp()
        {

        }
    }
    public class Product
    {
        private string name;
        private string sku;
        private int price;

        public Product(string sku, string name, int price)
        {
            this.sku = sku;
            this.name = name;
            this.price = price;
        }
        public string Name
        {
            get { return name; }
        }
        public string Sku
        {
            get { return sku; }
        }
        public int Price
        {
            get { return price; }
        }
        public override bool Equals(Object obj)
        {
            Product product = (Product)obj;
            return Sku==product.Sku;
        }
        
    }

}
