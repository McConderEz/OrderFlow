using OrderService.Domain.Shared;

namespace OrderService.Domain.OrderManagement.Events;

public record OrderCreatedEvent() : IDomainEvent;
