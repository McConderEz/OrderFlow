namespace OrderService.Domain.Shared;

/// <summary>
/// Класс для реализации доменных событий сущности
/// </summary>
/// <typeparam name="TId"></typeparam>
public abstract class DomainEntity<TId> : Entity<TId> where TId: BaseId<TId>
{
    protected DomainEntity(TId id) : base(id){}

    private readonly List<IDomainEvent> _domainEvents = [];

    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    protected void AddDomainEvent(IDomainEvent @event) => _domainEvents.Add(@event);

    public void ClearDomainEvents() => _domainEvents.Clear();
}