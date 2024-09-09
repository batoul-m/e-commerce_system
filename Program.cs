using Microsoft.Extensions.DependencyInjection;
namespace e_commerce_system;
internal class Program
{
    private static void Main(string[] args)
    {
        //Set up th DI
        var ServicesProvider = new ServiceCollection()
            .AddTransient<ICustomerServices,CustomerServices>()                         
            .AddTransient<RegularCustomer>()  
            .AddTransient<PremiumCustomer>()                     
            .AddTransient<VIPCustomer>()
            .BuildServiceProvider();
        ICustomerDiscount discount ; 
        
        Console.WriteLine("Choose you customer type {Regular , VIP , Premium}");
        var choice = Console.ReadLine();
        if(string.IsNullOrEmpty(choice))
            throw new Exception("Choice ca not empty");

        Console.WriteLine("enter the total amount");
        var totalAmount = decimal.Parse(Console.ReadLine());
        if(totalAmount < 0)
            throw new Exception("Toatl Amount must be pos");

        switch(choice?.ToLower()){
            case "regular":
                //discount = ServicesProvider.GetRequiredService<RegularCustomer>();
                discount = ServicesProvider.GetRequiredService<RegularCustomer>();                   

                break;
            case "vip":
                discount = ServicesProvider.GetRequiredService<VIPCustomer>();                   
                break;
            case "premium":
                discount = ServicesProvider.GetRequiredService<PremiumCustomer>();                   
                break;
            default:
                Console.WriteLine("Unknown customer type.");
            return;


        }
        var customerServices = new CustomerServices(discount);
        var finalAmount = customerServices.GetFinalAmount(totalAmount);
        Console.WriteLine($"Final amount after discount: {finalAmount}");

    }
}