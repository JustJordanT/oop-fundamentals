namespace ACM.BL;

public class OrderRepository
{
   public Order Retrieve(int orderId)
   {
      // Creates the instance.
      // Pass in the requested id
      Order order = new Order(1);

      if (orderId == 1)
      {
         order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 22, 10, 00, 00, new TimeSpan(7,0,0));
      }

      return order;

   }
   
   // Save the current customer.
   public bool Save(Order order)
   {
      // Code that triggers the save.
      return true;
   }
}