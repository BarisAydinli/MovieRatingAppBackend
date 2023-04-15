using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Country : Entity
{
    public string Name { get; set; }
}