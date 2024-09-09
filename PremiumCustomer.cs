namespace e_commerce_system{
    public class PremiumCustomer : ICustomerDiscount{
        decimal ICustomerDiscount.ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * 0.90M; 
        }
    }
}