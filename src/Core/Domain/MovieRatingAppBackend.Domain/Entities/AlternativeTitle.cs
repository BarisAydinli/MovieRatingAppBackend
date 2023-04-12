namespace MovieRatingAppBackend.Domain.Entities;

public sealed class AlternativeTitle
{
    public Guid FilmId { get; set; }
    public Film Film { get; set; }

    public Guid LanguageId { get; set; }
    public Language Language { get; set; }
    
    public string Title { get; set; }
}