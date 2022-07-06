namespace ACM.BL;

public class AddressRepository
{
    public Address Retrieve(int addressId)
    {
        // Creates the instance of the Customer class
        // Pass in the requested id
        Address address = new Address(addressId);
        
        // Code that retrieves the define customer
        
        // temp hard-coded values to return
        // a populated customer

        if (addressId == 1)
        {
            address.AddressType = 1;
            address.StreetAddress1 = "My Street 1";
            address.StreetAddress2 = "My Street 2";
            address.City = "St Paul";
            address.State = "Minnesota";
            address.Country = "USA";
            address.PostalCode = "55033";
        }

        return address;
    }

    public IEnumerable<Address> RetrieveByCustomerId(int customerId)
    {
        var addressList = new List<Address>();
        Address address = new Address(1)
        {
            AddressType = 1,
            StreetAddress1 = "My Steet 1",
            StreetAddress2 = "My Street 2",
            City = "Houston",
            State = "Texas",
            PostalCode = "77070",
            Country = "USA"
        };
        addressList.Add(address);

        new Address(2)
        {
            AddressType = 2,
            StreetAddress1 = "My Steet 1",
            StreetAddress2 = "My Street 2",
            City = "Corpus Christi",
            State = "Texas",
            PostalCode = "78418",
            Country = "USA"
        };
        return addressList;
    }

    // Save the current customer.
    public bool Save(Address address)
    {
        // Code that triggers the save.
        return true;
    }
}