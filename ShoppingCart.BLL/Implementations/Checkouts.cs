using ShoppingCart.Models;
using ShoppingCart.DAL;
using ShoppingCart.BLL.Contracts;

namespace ShoppingCart.BLL.Implementations
{
    public class Checkouts : ICheckouts
    {
        private IProductRepository _productRepository;
        private IPaymentOperations _paymentOperations;
        private ICommunications _communications;

        public Checkouts(IProductRepository productRepository, IPaymentOperations paymentOperations, ICommunications communications)
        {
            _productRepository = productRepository;
            _paymentOperations = paymentOperations;
            _communications = communications;
        }

        public (bool isProductAvailable, bool paymentStatus) CheckoutOrder(Order order)
        {
            bool isProductAvailable, paymentStatus = false;
            isProductAvailable = _productRepository.CheckInventory(order.Product?.Id, order.Quantity);
            if (isProductAvailable)
            {
                paymentStatus = _paymentOperations.ChargePayments(order.Customer?.CreditCardNumber, order.Cost);
            }
            return (isProductAvailable, paymentStatus);
        }

        public bool SendShippingInfo(Order order)
        {            
            var message = PrepareMessage(order);
            var status = _communications.SendEmail(order.Customer.Email, message.body, message.subject);
            return status;
        }

        private (string subject, string body) PrepareMessage(Order order)
        {
            var subject = $"Shipping details for {order.Product.Description}";
            var body = $"We have shipped {order.Quantity} items to {order.Customer.Address}";
            return (subject, body);
        }
    }
}