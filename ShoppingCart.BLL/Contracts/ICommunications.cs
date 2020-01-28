namespace ShoppingCart.BLL.Contracts
{
    public interface ICommunications
    {
        /// <summary>
        /// send an email using system configurations
        /// </summary>
        /// <param name="toAddress">address to send email to</param>
        /// <param name="body">email body</param>
        /// <param name="subject">email subject</param>
        /// <returns></returns>
        bool SendEmail(string toAddress, string body, string subject);
    }
}
