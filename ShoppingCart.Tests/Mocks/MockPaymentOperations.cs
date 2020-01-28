using ShoppingCart.BLL.Contracts;

namespace ShoppingCart.Tests.Mocks
{
    class MockPaymentOperations : IPaymentOperations
    {
        public bool ChargePayments(string creditCardNumber, decimal amount)
        {
            return true;
        }
    }
}
