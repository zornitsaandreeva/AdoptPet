namespace Adopt.Infrastructure.Data
{
    //using Adopt.Models;
    //using AdoptPet.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CurrentHome> CurrentHomes { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
