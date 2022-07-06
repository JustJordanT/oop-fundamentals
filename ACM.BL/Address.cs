namespace ACM.BL;

public class Address
{
    public Address()
    {
        
    }

    public Address(int addressId)
    {
        AddressId = addressId;
    }
    
    public int AddressId { get; set; }
    public int AddressType { get; set; }
    public string StreetAddress1 { get; set; }
    public string StreetAddress2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }

    public bool Vailidate()
    {
        bool isValid = false;
        
        return isValid;
    }
}    