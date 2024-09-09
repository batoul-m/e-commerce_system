namespace e_commerce_system{
    public class Customer{
        public int Id { get; set;}
        public string Name { get; set;}
        public int Number { get; set;}
        public Customer(int id,string name,int number) {
            Id = id < 0 ? id : throw new ArgumentException("Customer id can not be 0");
            Name = name.Length < 0 ? name : throw new ArgumentException("Customer name can not be empty");
            Number = number < 0 ? number : throw new ArgumentException("Customer number can not be 0");
        }
    }
}