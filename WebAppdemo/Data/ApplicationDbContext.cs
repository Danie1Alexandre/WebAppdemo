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
                           

            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 1, Name = "Neo", PhoneNumber = "05199999", CityId = 1 });
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 2, Name = "Mr.Smith", PhoneNumber = "08197777", CityId = 2 });
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 3, Name = "Morpheus", PhoneNumber = "07198888", CityId = 3 });
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 4, Name = "Trinity", PhoneNumber = "071234986", CityId = 4 });

            modelBuilder.Entity<CityModel>().HasData(new CityModel { Id = 1, Name = "NewYork", CountryID = 1 });
            modelBuilder.Entity<CityModel>().HasData(new CityModel { Id = 2, Name = "LosAngeles", CountryID = 2 });
            modelBuilder.Entity<CityModel>().HasData(new CityModel { Id = 3, Name = "Moscow", CountryID = 3 });
            modelBuilder.Entity<CityModel>().HasData(new CityModel { Id = 4, Name = "Paris", CountryID = 4 });

            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { Id = 1, Name = "Usa" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { Id = 2, Name = "Usa" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { Id = 3, Name = "Russia" });
            modelBuilder.Entity<CountryModel>().HasData(new CountryModel { Id = 4, Name = "France" });
        }




    }
}
