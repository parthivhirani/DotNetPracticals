namespace Practical07.DIP
{
    // low level module (Customer class)
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        //tight coupling
        private CustomerRepository _csRepo = new CustomerRepository();
    }

    // high level module (CustomerRepository class)
    // high level module(CustomerRepository class) is dependent on low level module(Customer class)
    // this violates rule of DIP
    public class CustomerRepository
    {
        public void AddCustomer(Customer cs)
        {
            // business logic
        }

        public void DeleteCustomer(Customer cs)
        {
            // business logic
        }

        public void EditCustomer(Customer cs)
        {
            // business logic
        }

        public void GetAllCustomer()
        {
            // business logic
        }
    }
}