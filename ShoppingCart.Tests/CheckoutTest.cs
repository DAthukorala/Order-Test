using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart.BLL.Contracts;
using ShoppingCart.BLL.Implementations;
using ShoppingCart.Models;
using ShoppingCart.Tests.Mocks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CheckoutTest
    {
        private ICheckouts _checkouts;
        private Order _order;

        [TestInitialize]
        public void StartUp()
        {
            //used mock objects here, since there is nothing to test at the moment for all three mock implementations 
            _checkouts = new Checkouts(new MockProductRepository(), new MockPaymentOperations(), new MockCommunications());
            _order = new Order
            {
                Cost = 200,
                Quantity = 2,
                Customer = new Customer
                {
                    Name = "Danny",
                    Address = "Test address",
                    CreditCardNumber = "1234-12334-344",
                    Email = "danny@danny.com"
                },
                Product = new Product
                {
                    Description = "Test product description",
                    Id = "pd23234"
                }
            };
        }

        [TestMethod]
        public void TestCheckout()
        {
            var status = _checkouts.CheckoutOrder(_order);
            Assert.IsTrue(status.isProductAvailable, "product not available status fail");
            Assert.IsTrue(status.paymentStatus, "Unsuccessful payment transaction status fail");
        }

        [TestMethod]
        public void TestEmail()
        {
            var status = _checkouts.SendShippingInfo(_order);
            Assert.IsTrue(status, "email sending failed");
        }
    }
}
