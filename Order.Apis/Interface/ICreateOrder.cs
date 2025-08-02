using Order.Apis.Models;

namespace Order.Apis.Interface
{
    public interface ICreateOrder
    {
        public string CreateOrder(Orders order);
    }
}
