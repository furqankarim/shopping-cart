namespace CartTDD.ShoppingCart
{
    public interface ICartCheckout
    {
        decimal CalculateTotalCartValue(decimal unitPrice,int quantity);
    }

}
