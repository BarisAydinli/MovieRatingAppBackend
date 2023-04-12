namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Review
{
    //public User User { get; set; }

    public Guid FilmId { get; set; }
    public Film Film { get; set; }

    public string Content { get; set; }

    public List<ReviewLike> ReviewLikes { get; set; }

    public string Likes => ReviewLikes.Count.ToString();
}