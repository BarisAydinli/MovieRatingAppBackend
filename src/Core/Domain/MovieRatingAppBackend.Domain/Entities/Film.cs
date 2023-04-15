using MovieRatingAppBackend.Domain.Common;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Film : Entity
{
    public ICollection<Language> Languages { get; set; }
    public ICollection<Cast> Casts { get; set; }
    public ICollection<Studio> Studios { get; set; }
    public ICollection<Country> Countries { get; set; }
    public ICollection<Genre> Genres { get; set; }
    public ICollection<Theme> Themes { get; set; }
    public ICollection<AlternativeTitle> AlternativeTitles { get; set; }
    public ICollection<Rating> Ratings { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<Watch> Watches { get; set; }
    public ICollection<Like> Likes { get; set; }
    public ICollection<List> Lists { get; set; }

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

