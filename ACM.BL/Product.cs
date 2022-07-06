namespace ACM.BL;

public class Product
{
    public Product()
    {
        
    }

    public Product(int productId)
    {
        ProductId = productId;
    }

    public int ProductId { get; set; }
    public static int ProductCount { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public decimal? CurrentPrice { get; set; }
    public bool Validate()
    {
        bool isValid = !string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null;

        return isValid;
    }
}