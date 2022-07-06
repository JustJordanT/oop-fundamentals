using ACM.BL;
using Xunit;

namespace ACM.BLTEST;

public class ProductTests
{
    [Fact]
    public void NameTest()
    {
        // arrange
        var product = new Product() { ProductName = "Lumber" };

        var expected = "Lumber";
        
        // actual
        var actual = product.ProductName;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void DescriptionTest()
    {
        // arrange
        var product = new Product() { ProductDescription = "Building material" };

        var expected = "Building material";
        
        // actual
        var actual = product.ProductDescription;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void ValidateValid()
    {
        // arrange
        var product = new Product()
        {
            ProductName = "Lumber",
            CurrentPrice = 12
        };

        var expected = true;
        
        // actual
        var actual = product.Validate();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void ValidateMissingName()
    {
        // arrange
        var product = new Product()
        {
            CurrentPrice = 12
        };

        var expected = false;
        
        // actual
        var actual = product.Validate();
        
        // assert
        Assert.Equal(expected, actual);
    }

}