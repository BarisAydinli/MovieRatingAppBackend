using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieRatingAppBackend.Domain.Entities;
using MovieRatingAppBackend.Infrastructure.Identity.Models;

namespace MovieRatingAppBackend.Persistence.Contexts;

public class ApplicationDbContext : IdentityDbContext<User,Role,Guid>
{
    public DbSet<AlternativeTitle> AlternativeTitles { get; set; } = null!;
    public DbSet<Cast> Casts { get; set; } = null!;
    public DbSet<Country> Countries { get; set; } = null!;
    public DbSet<Film> Films { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;
    public DbSet<Language> Languages { get; set; } = null!;
    public DbSet<Like> Likes { get; set; } = null!;
    public DbSet<List> Lists { get; set; } = null!;
    public DbSet<Rating> Rating { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
    public DbSet<ReviewLike> ReviewLikes { get; set; } = null!;
    public DbSet<Studio> Studios { get; set; } = null!;
    public DbSet<SubReview> SubReviews { get; set; } = null!;
    public DbSet<Theme> Themes { get; set; } = null!;
    public DbSet<Watch> Watches { get; set; } = null!;
    public DbSet<WatchList> WatchLists { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    
}