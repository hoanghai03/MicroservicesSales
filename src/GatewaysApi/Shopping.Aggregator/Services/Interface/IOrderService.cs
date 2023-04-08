using Shopping.Aggregator.Models;

namespace Shopping.Aggregator.Services.Interface
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
