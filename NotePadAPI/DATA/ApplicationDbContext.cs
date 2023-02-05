using Microsoft.EntityFrameworkCore;

namespace NotePadAPI.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Note> Notes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(
                new Note()
                {
                    Id = 1,
                    Title = "Alınacaklar",
                    Content = "1.Bot \n 2. Kot",
                },
                new Note()
                {
                    Id = 2,
                    Title = "Görevler",
                    Content = "1.Ye \n 2. Dua et \n 3. Sev",
                },
                new Note()
                {
                    Id = 3,
                    Title = "Gez & Gör",
                    Content = "1. Muş \n 2. Van \n 3. Of",
                });
        }
    }
}
