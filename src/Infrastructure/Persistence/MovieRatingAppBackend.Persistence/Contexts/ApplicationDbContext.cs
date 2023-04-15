using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieRatingAppBackend.Domain.Entities;

namespace MovieRatingAppBackend.Persistence.Contexts;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<AlternativeTitle> AlternativeTitles { get; set; }
    public DbSet<Cast> Casts { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<List> Lists { get; set; }
    public DbSet<Rating> Rating { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<ReviewLike> ReviewLikes { get; set; }
    public DbSet<Studio> Studios { get; set; }
    public DbSet<SubReview> SubReviews { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Watch> Watches { get; set; }
    public DbSet<WatchList> WatchLists { get; set; }
    
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    
}