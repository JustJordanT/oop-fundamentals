using ACM.BL;
using Xunit;

namespace ACM.BLTEST;

public class ProductRepositoryTests
{
    [Fact]
    public void RetrieveValid()
    {
        //arrage
        var productRepository = new ProductRepository();
        var expected = new Product(1)
        {

            ProductName = "Lumber",
            ProductDescription = "Building Material",
            CurrentPrice = 12.50M
        };
        
        // act
        var actual = productRepository.Retrieve(1);
        
        // assert
        Assert.Equal(expected.ProductName, actual.ProductName);
        Assert.Equal(expected.ProductDescription, actual.ProductDescription);
        Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
    }
}