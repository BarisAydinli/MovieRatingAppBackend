using Microsoft.EntityFrameworkCore;

namespace MovieRatingAppBackend.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    
    
}