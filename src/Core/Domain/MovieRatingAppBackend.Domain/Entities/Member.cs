using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Member : Entity
{
    public string Firstname { get; set; }
    public string LastName { get; set; }
}