using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PasswordGenerator
{
    public class databaseContext : IdentityDbContext<IdentityUser>
    {
        public databaseContext(DbContextOptions<databaseContext> options) : base(options) { }

        // Add any additional DbSets if you have other entities
    }
}
