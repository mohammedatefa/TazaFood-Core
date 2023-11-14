namespace TazaFood_Core.Models.Order_Aggregate
{
    public class ProductOrderItem
    {
        public ProductOrderItem() { }
        
            
        
        public ProductOrderItem(int productId, string productName, string imageUrl)
        {
            ProductId = productId;
            ProductName = productName;
            ImageUrl = imageUrl;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }

    }
}