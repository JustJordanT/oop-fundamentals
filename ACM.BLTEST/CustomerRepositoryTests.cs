using ACM.BL;
using Xunit;

namespace ACM.BLTEST;

public class CustomerRepositoryTests
{
    [Fact]
    public void RetrieveValid()
    {
        //arrage
        var customerRepository = new CustomerRepository();
        var expected = new Customer(1)
        {

            EmailAddress = "SteveJobs@apple.com",
            FirstName = "Steve",
            LastName = "Jobs"
        };
        
        // act
        var actual = customerRepository.Retrieve(1);
        
        // assert
        Assert.Equal(expected.CutomerId, actual.CutomerId);
        Assert.Equal(expected.EmailAddress, actual.EmailAddress);
        Assert.Equal(expected.FirstName, actual.FirstName);
        Assert.Equal(expected.FirstName, actual.FirstName);
        Assert.Equal(expected.LastName, actual.LastName);
    }

    // [Fact]
    // public void RetrieveInvalidId()
    // {
    //     // arrage
    //     var customerRepository = new CustomerRepository();
    //     var expected = new Customer(2)
    //     {
    //
    //         EmailAddress = "BillGates@Microsoft.com",
    //         FirstName = "Bill",
    //         LastName = "Gates"
    //     };
    //     
    //     // act
    //     var actual = customerRepository.Retrieve(1);
    //     
    //     // assert
    //     Assert.Equal(expected.CutomerId, actual.CutomerId);
    //     Assert.Equal(expected.EmailAddress, actual.EmailAddress);
    //     Assert.Equal(expected.FirstName, actual.FirstName);
    //     Assert.Equal(expected.FirstName, actual.FirstName);
    //     Assert.Equal(expected.LastName, actual.LastName); 
    // }
}