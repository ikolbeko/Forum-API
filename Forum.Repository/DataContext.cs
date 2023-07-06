using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Forum.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Forum.Repository
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicMessage> TopicMessages { get; set; }
        public DbSet<TopicCategory> TopicCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Topic>().ToTable("Topic");
            modelBuilder.Entity<TopicMessage>().ToTable("TopicMessage");
            modelBuilder.Entity<TopicCategory>().ToTable("TopicCategory");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}