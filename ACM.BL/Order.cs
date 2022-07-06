using System.Data;

namespace ACM.BL;

public class Order
{
    public Order()
    {
        
    }

    public Order(int orderId)
    {
        OrderId = orderId;
    }

    public DateTimeOffset? OrderDate { get; set; }
    public int OrderId { get; set; }
    
    public bool Validate()
    {
        var isValid = true;
        // bool isValid = !string.IsNullOrWhiteSpace(Name) || double.IsNaN(CurrentPrice);

        return isValid;
    }
}