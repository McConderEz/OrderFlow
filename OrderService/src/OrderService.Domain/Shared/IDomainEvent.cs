using MediatR;

namespace OrderService.Domain.Shared;

/// <summary>
/// Класс-маркер для идентификации доменных событий
/// </summary>
public interface IDomainEvent : INotification;
