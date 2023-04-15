using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class ReviewLike : Entity
{
    public Guid MemberId { get; set; }
    public Member Member { get; set; }
    
    public Guid ReviewId { get; set; }
    public Review Review { get; set; }   
}