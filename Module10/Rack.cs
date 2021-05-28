using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Rack<T> where T : Product
    {
        public static int numberOfProducts;
        public List<T> products;

        public Rack()
        {
            products = new List<T>();
        }

        public void AddProduct(T product)
        {
            numberOfProducts++;
            products.Add(product);
        }
    }
}
