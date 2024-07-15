using AdoptMyPetBackend.Pets.Domain.Model.Entities;
using AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs;
using AdoptMyPetBackend.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace AdoptMyPetBackend.Shared.Persistence.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<PetType> types { get; set; }
        public DbSet<Pet> pets { get; set; }

        public readonly IConfiguration _configuration;

        public AppDbContext(DbContextOptions options, IConfiguration configuration):base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL(_configuration.GetConnectionString("Default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PetType>()
                .HasMany(p => p.Pets)
                .WithOne(p => p.Type)
                .HasForeignKey(p => p.PetTypeId)
                .IsRequired();

            modelBuilder.UseSnakeCaseNamingConventions();
        }

    }
}
