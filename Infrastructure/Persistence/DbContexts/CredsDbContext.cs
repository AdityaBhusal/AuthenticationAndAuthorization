using AuthenticationAndAuthorization.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndAuthorization.Infrastructure.Persistence.DbContexts
{
    public class CredsDbContext : DbContext
    {
        public CredsDbContext(DbContextOptions<CredsDbContext> options): base(options) { }

        public DbSet<UserCreds> userCreds => Set<UserCreds>();
    }
}
