using Miasin.Services.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Miasin.Mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Author> Authors{get;set;}

        public DbSet<Post> Posts{get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
    }
}
