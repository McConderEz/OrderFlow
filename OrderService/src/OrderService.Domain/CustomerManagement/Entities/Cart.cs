using OrderService.Domain.Shared;
using OrderService.Domain.Shared.Ids;

namespace OrderService.Domain.CustomerManagement.Entities;

public class Cart: DomainEntity<CartId>
{
    //Ef core
    private Cart(CartId id) : base(id)
    {
    }
    
    //TODO: Реализовать
    //TODO: Переделать в VO
    
}