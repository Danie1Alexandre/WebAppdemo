using Microsoft.EntityFrameworkCore;

namespace WebAppdemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PeopleModel> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 1, Name = "Neo", PhoneNumber = "05199999", CityId = 1 });
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 2, Name = "Mr.Smith", PhoneNumber = "08197777", CityId = 2 });
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 3, Name = "Morpheus", PhoneNumber = "07198888", CityId = 3 });
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 3, Name = "Trinity", PhoneNumber = "071234986", CityId = 4 });
        }



    }
}
