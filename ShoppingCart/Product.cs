using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartTDD.ShoppingCart
{
    public class Product
    {
        public Dictionary<string, decimal> GenericProductList;

        public Product()
        {
            GenericProductList = new Dictionary<string, decimal>();
            GenericProductList.Add("DoveSoap",39.99m);
        }

        public decimal ProductPrice(string itemKey)
        {
            return GenericProductList.ContainsKey(itemKey) ? GenericProductList[itemKey] : 0;
        }
    }
}
