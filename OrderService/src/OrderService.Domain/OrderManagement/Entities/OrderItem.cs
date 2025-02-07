using OrderService.Domain.Shared;
using OrderService.Domain.Shared.Ids;

namespace OrderService.Domain.OrderManagement.Entities;

public class OrderItem: Entity<OrderItemId>
{
    //TODO: Переделать в VO
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    
    
}