using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRatingAppBackend.Domain.Entities;

namespace MovieRatingAppBackend.Persistence.EntityConfigurations;

public class AlternativeTitleConfig : IEntityTypeConfiguration<AlternativeTitle>
{
    public void Configure(EntityTypeBuilder<AlternativeTitle> builder)
    {
        throw new NotImplementedException();
    }
}