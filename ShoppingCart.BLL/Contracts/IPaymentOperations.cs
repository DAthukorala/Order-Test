namespace ShoppingCart.BLL.Contracts
{
    public interface IPaymentOperations
    {
        /// <summary>
        /// deduct the give amunt from the credit card
        /// </summary>
        /// <param name="creditCardNumber">card number</param>
        /// <param name="amount">amount to charge</param>
        /// <returns>operation status</returns>
        bool ChargePayments(string creditCardNumber, decimal amount);
    }
}
