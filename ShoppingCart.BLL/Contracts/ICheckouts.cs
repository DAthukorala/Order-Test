using ShoppingCart.Models;

namespace ShoppingCart.BLL.Contracts
{
    public interface ICheckouts
    {
        /// <summary>
        /// do payments and checkout products
        /// </summary>
        /// <param name="order">order information</param>
        /// <returns>order placement status message</returns>
        (bool isProductAvailable, bool paymentStatus) CheckoutOrder(Order order);

        /// <summary>
        /// Send an email to customer with product and shipping information
        /// </summary>
        /// <param name="order">order information</param>
        /// <returns>email sending status</returns>
        bool SendShippingInfo(Order order);
    }
}
