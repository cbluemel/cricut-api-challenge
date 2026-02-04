using Cricut.Orders.Domain.Models;

namespace Cricut.Orders.Domain
{
    public interface IOrderDomain
    {
        Task<Order> CreateNewOrderAsync(Order order);
        Task<Order[]> GetAllOrdersForCustomerAsync(int customerId);
    }

    public class OrderDomain : IOrderDomain
    {
        private readonly IOrderStore _orderStore;

        public OrderDomain(IOrderStore orderStore)
        {
            _orderStore = orderStore;
        }

        public async Task<Order> CreateNewOrderAsync(Order order)
        {
            var updatedOrder = await _orderStore.SaveOrderAsync(order);
            return updatedOrder;
        }

        public async Task<Order[]> GetAllOrdersForCustomerAsync(int customerId)
        {
            var orders = await _orderStore.GetAllOrdersForCustomerAsync(customerId);
            return orders;
        }
    }
}
