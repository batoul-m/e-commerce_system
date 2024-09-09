namespace e_commerce_system{
    public class VIPCustomer : ICustomerDiscount{
        decimal ICustomerDiscount.ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * 0.80M; // 20% discount
        }
    }
}