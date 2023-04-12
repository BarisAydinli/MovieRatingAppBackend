namespace MovieRatingAppBackend.Domain.Entities;

public sealed class List
{
    //public User User { get; set; }
    
    public List<Film> Films { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
}