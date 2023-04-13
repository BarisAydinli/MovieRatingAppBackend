using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class AlternativeTitle : Entity
{
    public Guid FilmId { get; set; }
    public Film Film { get; set; }

    public string Title { get; set; }
}