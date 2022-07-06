using System.Reflection.Metadata.Ecma335;

namespace ACM.BL;

public class OrderItem
{

    public OrderItem()
    {
        
    }

    public OrderItem(int orderItemId)
    {
        OrderItemId = orderItemId;
    }

    public int OrderItemId { get; set; }
    public int Quantity { get; set; }
    public decimal? PurchasePrice { get; set; }
    
    public bool Validate()
    {
        // var isValid = true;
        bool isValid = Quantity == null || PurchasePrice == null;

        return isValid;
    }

    public OrderItem Retrieve()
    {
        return new OrderItem();
    }

    public List<OrderItem> Retrieve(string orderItem)
    {
        return new List<OrderItem>();
    }

    public bool Save()
    {
        return true;
    }
}