using Microsoft.EntityFrameworkCore;
using NonProfitManager.Models;

namespace NonProfitManager.Data
{
    public class NonProfitManagerDbContext : DbContext
    {
        public NonProfitManagerDbContext(DbContextOptions<NonProfitManagerDbContext> options):
            base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>(entity =>
            {
                entity.Property(o => o.OrganizationId).ValueGeneratedOnAdd();

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(u => u.UserId).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.Property(a => a.AnimalId).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<AdoptedAnimal>(entity =>
            {
                entity.Property(a => a.AdoptedAnimalId).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<Transport>(entity =>
            {
                entity.Property(t => t.TransportId).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(p => p.PhotoId).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(r => r.RoleId).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<Survey>(entity =>
            {
                entity.Property(s => s.SurveyId).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(q => q.QuestionId).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<UserAnswer>(entity =>
            {
                entity.Property(ua => ua.UserAnswerId).ValueGeneratedOnAdd();

            });
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AdoptedAnimal> AdoptedAnimals { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Question> Questions { get; set; } 
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<Survey> Surveys { get; set; }
    }
}
