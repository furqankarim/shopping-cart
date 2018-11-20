using System;

namespace CartTDD.ShoppingCart
{
    public interface IShoppingCart
    {
        int GetCartTotalItemsCount();
        int GetItemCount(string Key);
        void AddItemToCart(string itemName,int quantity);
        decimal TotalPrice();
    }
}