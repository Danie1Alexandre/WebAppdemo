using Microsoft.EntityFrameworkCore;

namespace WebAppdemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PeopleModel> People { get; set; }
        public DbSet<CityModel> City { get; set; }
        public DbSet<CountryModel> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeopleModel>()
                .HasOne(p => p.City)
                .WithMany(ci => ci.People)
                .HasForeignKey(p => p.CityId);


            modelBuilder.Entity<CityModel>()
                .HasOne(ci => ci.Country)
                .WithMany(co => co.Cyties)
                .HasForeignKey(ci => ci.CountryID);
                           

            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 1, Name = "Naruto", Skills = "Shadow Clones", CityId = 1 });
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 2, Name = "Sasuke", Skills = "Fireball", CityId = 1 });
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 3, Name = "Gaara", Skills = "Shield of Sand", CityId = 2 });
    

            modelBuilder.Entity<CityModel>().HasData(new CityModel { Id = 1, Name = "Konohagakure, Hidden In The Leaf", CountryID = 1 });
            modelBuilder.Entity<CityModel>().HasData(new CityModel { Id = 2, Name = "Sunagakure, Hidden In The Sand", CountryID = 2 });

            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { Id = 1, Name = "the Land of Fire" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { Id = 2, Name = "the Land of Wind" });


        }




    }
}
