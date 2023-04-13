using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRatingAppBackend.Domain.Entities;

namespace MovieRatingAppBackend.Persistence.EntityConfigurations;

public class FilmConfig : IEntityTypeConfiguration<Film>
{
    public void Configure(EntityTypeBuilder<Film> builder)
    {
        
    }
}