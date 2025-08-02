using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.Apis.Interface;
using Order.Apis.Models;
using System.Runtime.InteropServices;

namespace Order.Apis.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ICreateOrder _createOrder;

        public OrderController(ICreateOrder createOrder)
        {
             _createOrder = createOrder;
        }
        [HttpPost]
        public ActionResult<Orders> createOrder(Orders order)
        {
            if(order == null)
                throw new ArgumentNullException(nameof(Order));

            var orderResult = _createOrder.CreateOrder(order);
            return Ok(orderResult);
        }
    }
}
