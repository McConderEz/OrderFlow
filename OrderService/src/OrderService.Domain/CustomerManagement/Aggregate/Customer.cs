using OrderService.Domain.Shared;
using OrderService.Domain.Shared.Ids;

namespace OrderService.Domain.CustomerManagement.Aggregate;

public class Customer: DomainEntity<CustomerId>
{
    //Ef core
    private Customer(CustomerId id) : base(id){}

    //TODO: Переделать в VO
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public DateTime? BirthDate { get; set; }
    
}