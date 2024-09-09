namespace e_commerce_system{
    public class CustomerServices : ICustomerServices{
        private readonly ICustomerDiscount _customerDiscount;
        public CustomerServices(ICustomerDiscount customerDiscount){
            _customerDiscount = customerDiscount;
        }
        public decimal GetFinalAmount(decimal totalAmount)
        {
            return _customerDiscount.ApplyDiscount(totalAmount);
        }
    }
}