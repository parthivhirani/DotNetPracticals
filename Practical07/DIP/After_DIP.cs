namespace Practical07.ISP
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
    }

    // creating interface to define methods
    public interface ICustomerRepository
    {
        void AddCustomer(Customer cs);
        void EditCustomer(Customer cs);
        void DeleteCustomer(Customer cs);

        void GetAllCustomers();
    }

    // implementing ICustomerRepository interface in the class
    // now CustomerRepository class is not dependent on Customer class
    // satisfying the rule of DIP
    public class CustomerRepository : ICustomerRepository
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

        public void GetAllCustomers()
        {
            // business logic
        }
    }
}