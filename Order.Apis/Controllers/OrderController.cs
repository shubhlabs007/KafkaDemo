using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.Apis.Models;
using System.Runtime.InteropServices;

namespace Order.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Orders> createOrder(Orders order)
        {
            if(order == null)
                throw new ArgumentNullException(nameof(Order));
            
            return Ok(order);
        }
    }
}
