using ACM.BL;
using Xunit;

namespace ACM.BLTEST;

public class CustomerTests
{
    [Fact]
    public void FullNameTestValid()
    {
        // Arr

        Customer customer = new Customer
        {
            FirstName = "Steve",
            LastName = "Jobs"
        };

        string expected = "Jobs, Steve";
        
        //--act
        string actual = customer.FullName;
        
        //--Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void FullFirstNameEmtpy()
    {
        // Arr
        Customer customer = new Customer
        {
            LastName = "Jobs"
        };

        string expected = "Jobs";
        
        //--act
        string actual = customer.FullName;
        
        //--Assert
        Assert.Equal(expected, actual);
    }

    
    [Fact]
    public void FullLastNameEmtpy()
    {
        // Arr
        Customer customer = new Customer
        {
            FirstName = "Steve"
        };

        string expected = "Steve";
        
        //--act
        string actual = customer.FullName;
        
        //--Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StaticTest()
    {
        var c1 = new Customer() { FirstName = "Bill" };
        Customer.InstanceCount += 1;

        var c2 = new Customer() { FirstName = "Waz" };
        Customer.InstanceCount += 1;

        var c3 = new Customer() { FirstName = "Zucks" };
        Customer.InstanceCount += 1;
    }

    [Fact]
    public void ValidateValid()
    {
        //arrange
        var customer = new Customer()
        {
            LastName = "Smith",
            EmailAddress = "BillySmith@aol.com"
        };

        var expected = true;

        //act
        var actual = customer.Validate();

        //assert
        Assert.Equal(expected, actual);

    }
   
    [Fact]
    public void ValidateValidMissingLastName()
    {
        //arrange
        var customer = new Customer()
        {
            EmailAddress = "BillySmith@aol.com"
        };

        var expected = false;

        //act
        var actual = customer.Validate();

        //assert
        Assert.Equal(expected, actual);

    }
}