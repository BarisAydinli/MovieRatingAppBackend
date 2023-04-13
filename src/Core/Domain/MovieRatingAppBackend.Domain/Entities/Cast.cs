namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Cast
{
    public ICollection<Film> Films { get; set; }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }

    public int CastType { get; set; }
}