using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Studio : Entity
{
    public string Name { get; set; }
}