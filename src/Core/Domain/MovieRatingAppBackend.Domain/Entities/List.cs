using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class List : Entity
{
    public Guid MemberId { get; set; }
    public Member Member { get; set; }
    
    public ICollection<Film> Films { get; set; }

    public ICollection<ListLike> ListLikes { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public string Likes => ListLikes.Count.ToString();
}