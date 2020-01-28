namespace ShoppingCart.DAL
{
    public interface IProductRepository
    {
        /// <summary>
        /// check inventory for product availability
        /// </summary>
        /// <param name="productId">product to check</param>
        /// <param name="quantity">quantity needed</param>
        /// <returns>availability status</returns>
        bool CheckInventory(string productId, int quantity);
    }
}
