using System;
using System.Collections.Generic;
using LoginFormASPCore6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LoginFormASPCore6.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LocalAssets> LocalAssets { get; set; }
        public DbSet<LocalUpgradeInfo> LocalUpgradeInfo { get; set; }
        public DbSet<LocalIssueTracking> LocalIssueTracking { get; set; }
        public DbSet<LocalHardwares> LocalHardwares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=XIA-GUOGRA-LT\\SQLEXPRESS;Initial Catalog=V330_NTWC;User Id=sa;Password=MD123!@#;TrustServerCertificate=true");
            optionsBuilder.LogTo(msg =>
            {
                Console.WriteLine(msg);
            }, Microsoft.Extensions.Logging.LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
