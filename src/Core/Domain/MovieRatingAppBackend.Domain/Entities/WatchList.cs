using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class WatchList : Entity
{
    public Guid MemberId { get; set; }
    public Member Member { get; set; }

    public Guid FilmId { get; set; }
    public Film Film { get; set; }
}