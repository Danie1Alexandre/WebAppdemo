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
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 1, Name = "Naruto", Skills = "Shadow Clones" });
            modelBuilder.Entity<PeopleModel>().HasData(new PeopleModel { Id = 2, Name = "Sasuke", Skills = "Fireball" });
        }



    }
}
