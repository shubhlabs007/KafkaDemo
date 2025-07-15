namespace Order.Apis.Models
{
    public class Order : BaseOrder
    {
        public string UserName { get; set; }
        public List<Product> {get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
