namespace ACM.BL;

public class ProductRepository
{
   public Product Retrieve(int productId)
   {
      // Creates the instance.
      // Pass in the requested id
      Product product = new Product(1);

      if (productId == 1)
      {
         product.CurrentPrice = 12.50M;
         product.ProductDescription = "Building Material";
         product.ProductName = "Lumber";
      }

      return product;

   }
   
   // Save the current customer.
   public bool Save(Product product)
   {
      // Code that triggers the save.
      return true;
   }
}