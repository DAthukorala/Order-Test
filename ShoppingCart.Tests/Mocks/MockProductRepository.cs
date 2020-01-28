using ShoppingCart.DAL;

namespace ShoppingCart.Tests.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        public bool CheckInventory(string productId, int quantity)
        {
            return true;
        }
    }
}
