namespace MovieRatingAppBackend.Domain.Common;

public abstract class Entity
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime LastUpdatedAt { get; set; }
    public bool Active { get; set; }
}