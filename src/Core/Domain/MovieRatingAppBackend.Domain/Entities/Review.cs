using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Review : Entity
{
    public Guid MemberId { get; set; }
    public Member Member { get; set; }
    
    public Guid FilmId { get; set; }
    public Film Film { get; set; }
    
    public ICollection<ReviewLike> ReviewLikes { get; set; }

    public string Content { get; set; }
    public string Likes => ReviewLikes.Count.ToString();
}