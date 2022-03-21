using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAnnotations.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {



    }
            public DbSet<DataAnnotations.Models.Client> Client { get; set; }

        public DbSet<DataAnnotations.Models.Room> Room { get; set; }
}
}