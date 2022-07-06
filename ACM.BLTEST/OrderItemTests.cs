using ACM.BL;
using Xunit;

namespace ACM.BLTEST;

public class OrderItemTests
{
   [Fact]
   public void ProductQuantityTest()
   {
      // arrange 
      var oderItem = new OrderItem() { Quantity = 3 };

      var expected = 3.0;
      
      // actual
      var actual = oderItem.Quantity;
      
      // assert
      Assert.Equal(expected, actual);
   }

   [Fact]
   public void ProductCurrentPriceTest()
   {
      // arrange 
      var orderItem = new OrderItem() { PurchasePrice = 12 };

      var expected = 12;
      
      // actual 
      var actual = orderItem.PurchasePrice;
      
      // assert
      Assert.Equal(expected, actual);
   }
}