using OrderService.Domain.Shared;
using OrderService.Domain.Shared.Ids;

namespace OrderService.Domain.OrderManagement.Aggregate;

public class Order: DomainEntity<OrderId>
{
    
    //TODO: Реализовать

    //Ef core
    private Order(OrderId id) : base(id){}

}