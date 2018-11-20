namespace CartTDD.ShoppingCart
{
    public class CartCheckout:ICartCheckout 
    {
        public decimal CalculateTotalCartValue(decimal unitPrice, int quantity)
        {
            return quantity * unitPrice;
        }
    }
}
