using System;
using System.Data;
using ACM.BL;
using Xunit;

namespace ACM.BLTEST;

public class OrderRepositoryTests
{
    [Fact]
    public void RetrieveValid()
    {
        //arrage
        var orderRepository = new OrderRepository();
        var expected = new Order(1)
        {
            OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 22, 10, 00, 00, new TimeSpan(7,0,0))
        };
        
        // act
        var actual = orderRepository.Retrieve(1);
        
        // assert
        Assert.Equal(expected.OrderDate, actual.OrderDate);
    }
}