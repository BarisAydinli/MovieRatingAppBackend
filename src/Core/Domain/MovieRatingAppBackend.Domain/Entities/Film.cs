namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Film
{
    public List<Language> Languages { get; set; }
    public List<Cast> Casts { get; set; }
    public List<Crew> Crews { get; set; }
    public List<Studio> Studios { get; set; }
    public List<Country> Countries { get; set; }
    public List<Genre> Genres { get; set; }
    public List<Theme> Themes { get; set; }
    public List<AlternativeTitle> AlternativeTitles { get; set; }
    public List<Rating> Ratings { get; set; }
    public List<Review> Reviews { get; set; }
    public List<Watch> Watches { get; set; }
    public List<Like> Likes { get; set; }
    public List<List> Lists { get; set; }
    
    public string Name { get; set; }
    public string Motto { get; set; }
    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Watched => Watches.Count.ToString();
    public string Liked => Likes.Count.ToString();
    public string Appeared => Lists.Count.ToString();
    public string Duration { get; set; }
    public string PosterPath { get; set; }
    public string BackgroundImagePath { get; set; }
}