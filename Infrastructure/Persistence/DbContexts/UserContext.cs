using AuthenticationAndAuthorization.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndAuthorization.Infrastructure.Persistence.DbContexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base (options) { }
        public DbSet<User> Users => Set<User>();
    }
}
