namespace Order.Apis.Models
{
    public class Orders : BaseOrder
    {
        public long? Id { get; set; }
        public string? UserName { get; set; }
        public List<Product>? Products { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
