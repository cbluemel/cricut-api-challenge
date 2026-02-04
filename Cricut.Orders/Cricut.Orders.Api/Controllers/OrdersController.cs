using Cricut.Orders.Api.Mappings;
using Cricut.Orders.Api.ViewModels;
using Cricut.Orders.Domain;
using Cricut.Orders.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cricut.Orders.Api.Controllers
{
    [Route("v1/orders")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrderDomain _orderDomain;

        public OrdersController(IOrderDomain orderDomain)
        {
            _orderDomain = orderDomain;
        }

        [HttpGet]
        [Route("customer/{customerId}")]
        public async Task<ActionResult<Order[]>> GetCustomerOrdersAsync([FromRoute] int customerId)
        {
            var customerOrders = await _orderDomain.GetAllOrdersForCustomerAsync(customerId);
            return Ok(customerOrders);
        }

        [HttpPost]
        public async Task<ActionResult<OrderViewModel>> CreateNewOrderAsync([FromBody] NewOrderViewModel newOrderVM)
        {
            var newOrder = newOrderVM.ToDomainModel();
            var savedOrder = await _orderDomain.CreateNewOrderAsync(newOrder);
            return Ok(savedOrder.ToViewModel());
        }
    }
}
