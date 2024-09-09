namespace e_commerce_system{
    public class RegularCustomer : ICustomerDiscount{
        decimal ICustomerDiscount.ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * 0.95M; 
        }
    }
}