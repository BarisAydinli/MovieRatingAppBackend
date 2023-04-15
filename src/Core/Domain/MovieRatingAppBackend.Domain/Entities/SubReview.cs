using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class SubReview : Entity
{
    public Guid MemberId { get; set; }
    public Member Member { get; set; }
    
    public Guid ReviewId { get; set; }
    public Review Review { get; set; }

    public string Content { get; set; }
}