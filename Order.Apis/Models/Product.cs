namespace Order.Apis.Models
{
    public class Product : BaseProduct
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public Double Price { get; set; }

    }
}
