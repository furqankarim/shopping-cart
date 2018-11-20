using CartTDD.ShoppingCart;
using NUnit.Framework;

namespace ShoppingCartTDD
{
    [TestFixture]
    public class ShoppingCartTest
    {
        private IShoppingCart _iShoppingCart;

        [SetUp]
        public void SetupShoppingCart()
        {
            _iShoppingCart = new ShoppingCart(new Product(), new CartCheckout());
        }

        [Test]
        public void Ensure_shopping_cart_is_empty()
        {           
            Assert.AreEqual(0, _iShoppingCart.GetCartTotalItemsCount());
        }

        [TestCase("DoveSoap", 5,199.95)]
        public void Add_5_Dove_Soaps_to_shopping_cart_and_ensure_correct_price(string item, int quantity,double priceExpected)
        {
            _iShoppingCart.AddItemToCart(item, quantity);
            Assert.AreEqual(1, _iShoppingCart.GetCartTotalItemsCount());
            Assert.AreEqual(5, _iShoppingCart.GetItemCount(item));
            Assert.AreEqual(decimal.Parse(priceExpected.ToString()), _iShoppingCart.TotalPrice());
        }
    }
}
