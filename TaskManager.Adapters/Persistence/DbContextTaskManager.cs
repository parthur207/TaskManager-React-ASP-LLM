using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Entities;

namespace TaskManager.Adapters.Persistence
{
    public sealed class DbContextTaskManager : DbContext
    {
        public DbContextTaskManager(DbContextOptions<DbContextTaskManager> options) : base(options){}

        public DbSet<UserEntity> User { get; set; }
        public DbSet<TaskEntity> Task { get; set; }
        public DbSet<TaskCategoryEntity> TaskCategory { get; set; }


        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
            modelBuilder.Entity<TaskEntity>().HasKey(x => x.Id);
            modelBuilder.Entity<TaskCategoryEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<TaskEntity>()
                .HasOne(x => x.User)
                .WithMany(x => x.Tasks)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<TaskEntity>()
                .HasOne(x => x.Category)
                .WithMany(x => x.Tasks)
                .HasForeignKey(x => x.UserId);
    }
}
