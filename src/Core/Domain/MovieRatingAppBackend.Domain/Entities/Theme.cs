using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Theme : Entity
{
    public string Name { get; set; }
}