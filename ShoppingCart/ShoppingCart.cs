using System.Collections.Generic;
using System.Linq;

namespace CartTDD.ShoppingCart
{
    public class ShoppingCart:IShoppingCart
    {
        private readonly ICartCheckout _cartCheckout;
        private readonly Dictionary<string,int> _cartItems;
        private readonly Product itemList;

        public ShoppingCart( Product items, ICartCheckout cartCheckout)
        {
            _cartItems = new Dictionary<string, int>();
            itemList = items;
            _cartCheckout = cartCheckout;
        }

        public int GetCartTotalItemsCount()
        {
            return _cartItems.Count;
        }

        public int GetItemCount(string itmKey)
        {
            return _cartItems.ContainsKey(itmKey) ? _cartItems[itmKey] : 0; ;
        }

        public void AddItemToCart(string itemName,int quantity)
        {
            _cartItems.Add(itemName,quantity);
        }

        public decimal TotalPrice()
        {
            return _cartItems.Sum(item => _cartCheckout.CalculateTotalCartValue(itemList.ProductPrice(item.Key),item.Value));

        }

    }
}