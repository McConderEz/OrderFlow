﻿namespace OrderService.Domain.Shared;

/// <summary>
/// Класс сущности в рамках DDD с переопределёнными базовыми операциями
/// </summary>
/// <typeparam name="TId"></typeparam>
public abstract class Entity<TId>
    where TId: notnull
{
    public TId Id { get; private set; }
    public DateTime CreatedAt { get; set; }
    
    //Ef core
    protected Entity(){}

    protected Entity(TId id) => Id = id;

    public override bool Equals(object? obj)
    {
        if(obj is not Entity<TId> other)
            return false;
        
        if (!ReferenceEquals(this, other) ||
            !EqualityComparer<TId>.Default.Equals(Id, other.Id))
            return false;

        return true;
    }

    public override int GetHashCode()
    {
        return (GetType().ToString() + Id).GetHashCode();
    }

    public static bool operator ==(Entity<TId>? a, Entity<TId>? b)
    {
        if (a is null && b is null)
            return true;

        if (a is null || b is null)
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(Entity<TId> a, Entity<TId> b) => !(a == b);
}