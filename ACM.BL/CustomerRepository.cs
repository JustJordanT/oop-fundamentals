namespace ACM.BL;

public class CustomerRepository
{
    public Customer Retrieve(int customerId)
    {
        // Creates the instance of the Customer class
        // Pass in the requested id
        Customer customer = new Customer(customerId);
        
        // Code that retrieves the define customer
        
        // temp hard-coded values to return
        // a populated customer

        if (customerId == 1)
        {
            customer.EmailAddress = "SteveJobs@apple.com";
            customer.FirstName = "Steve";
            customer.LastName = "Jobs";
        }

        return customer;
    }
    
    // Save the current customer.
    public bool Save()
    {
        // Code that triggers the save.
        return true;
    }
}