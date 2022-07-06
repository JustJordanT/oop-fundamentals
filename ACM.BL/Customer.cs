namespace ACM.BL;

public class Customer
{
    public Customer() : this(0)
    {
        
    }
    
    public Customer(int cutomerId)
    {
        CutomerId = cutomerId;
        AddressList = new List<Address>();
    }
    public int CutomerId { get; private set; }
    
    public string EmailAddress { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Address> AddressList { get; set; }

    public string FullName
    {
        get
        {
            string fullName = LastName;
            if (!string.IsNullOrWhiteSpace(FirstName))
            {
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ", ";
                }
                fullName += FirstName;
            }
            return fullName;
        }
    }
    public static int InstanceCount { get; set; }

    public bool Validate()
    {
        bool isValid = !string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress);

        return isValid;
    }
}