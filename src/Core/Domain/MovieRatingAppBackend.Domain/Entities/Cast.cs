using MovieRatingAppBackend.Domain.Common;
using MovieRatingAppBackend.Domain.Enums;

namespace MovieRatingAppBackend.Domain.Entities;

public sealed class Cast : Entity
{
    public ICollection<Film> Films { get; set; }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }

    public CastType CastType { get; set; }
}