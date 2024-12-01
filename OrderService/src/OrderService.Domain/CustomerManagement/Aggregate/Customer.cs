using OrderService.Domain.Shared;
using OrderService.Domain.Shared.Ids;

namespace OrderService.Domain.CustomerManagement.Aggregate;

public class Customer: DomainEntity<CustomerId>
{
    //Ef core
    private Customer(CustomerId id) : base(id){}

}