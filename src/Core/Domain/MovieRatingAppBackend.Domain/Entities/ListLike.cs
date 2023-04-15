using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class ListLike : Entity
{
    public Guid MemberId { get; set; }
    public Member Member { get; set; }
    
    public Guid ListId { get; set; }
    public List List { get; set; }   
}