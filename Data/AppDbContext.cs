using System.Collections.Generic;
using WebWomen.Models;
using Microsoft.EntityFrameworkCore;

namespace WebWomen.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Woman> Women => Set<Woman>(); // <--- ADD THIS LINE
        public DbSet<WomanRate> WomanRates => Set<WomanRate>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users"); // PostgreSQL table name

                // entity.HasKey(e => e.Username); // Set primary key (change to Id or Email if different)
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .HasColumnName("id")
                      .UseIdentityByDefaultColumn(); // SERIAL maps to Identity by default in EF Core

                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Username).HasColumnName("username");
                entity.Property(e => e.Password).HasColumnName("password");
                entity.Property(e => e.Role).HasColumnName("role");
                entity.Property(e => e.Email).HasColumnName("email");
            });

            // Woman Entity Configuration
            modelBuilder.Entity<Woman>(entity =>
            {
                entity.ToTable("womanv1");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .HasColumnName("id")
                      .UseIdentityByDefaultColumn(); // SERIAL maps to Identity by default in EF Core


                entity.Property(e => e.Name).HasColumnName("name").IsRequired();
                entity.Property(e => e.Avatar).HasColumnName("avatar");
                entity.Property(e => e.Age).HasColumnName("age");
                entity.Property(e => e.Status).HasColumnName("status");
                entity.Property(e => e.DateOfBirth).HasColumnName("dateofbirth");
                entity.Property(e => e.Country).HasColumnName("country");
                entity.Property(e => e.Race).HasColumnName("race");
                entity.Property(e => e.Email).HasColumnName("email");
            });

            modelBuilder.Entity<WomanRate>(entity =>
            {
                entity.ToTable("woman_rate");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id").UseIdentityAlwaysColumn();
                entity.Property(e => e.WomanId).HasColumnName("woman_id").IsRequired();
                entity.Property(e => e.Rate).HasColumnName("rate").IsRequired();
                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                // Foreign Key Relationship
                entity.HasOne(r => r.Woman)
                      .WithMany()
                      .HasForeignKey(r => r.WomanId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

        }
     }

}
