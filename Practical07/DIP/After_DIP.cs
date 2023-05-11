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
        void AddCustomer(DataAccesFactory daf);
        void EditCustomer(DataAccesFactory daf);
        void DeleteCustomer(DataAccesFactory daf);

        void GetAllCustomers();
    }

    // implementing ICustomerRepository interface in the class
    // now CustomerRepository class is not dependent on Customer class
    // satisfying the rule of DIP
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(DataAccesFactory cs)
        {
            // business logic
        }

        public void DeleteCustomer(DataAccesFactory daf)
        {
            // business logic
        }

        public void EditCustomer(DataAccesFactory daf)
        {
            // business logic
        }

        public void GetAllCustomers()
        {
            // business logic
        }
    }

    // DataAccessFactory class which constructor creates instance of Customer class
    public class DataAccesFactory
    {
        public DataAccesFactory()
        {
            Customer cs = new Customer();
            cs.CustomerId = 1;
            cs.FirstName = "Parthiv";
            cs.LastName = "Hirani";
            cs.DoB = new DateTime(2002, 3, 29);
        }
    }
}