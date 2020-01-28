using ShoppingCart.BLL.Contracts;

namespace ShoppingCart.Tests.Mocks
{
    class MockCommunications : ICommunications
    {
        public bool SendEmail(string toAddress, string body, string subject)
        {
            return true;
        }
    }
}
