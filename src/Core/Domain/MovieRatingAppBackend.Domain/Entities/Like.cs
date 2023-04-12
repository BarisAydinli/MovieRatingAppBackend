namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Like
{
    //public User User { get; set; }

    public Guid FilmId { get; set; }
    public Film Film { get; set; }
}