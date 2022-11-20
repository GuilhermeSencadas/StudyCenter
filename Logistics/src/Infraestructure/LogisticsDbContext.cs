using Microsoft.EntityFrameworkCore;
using Logistics.Domain.Subjects;
using Logistics.Infrastructure.Subjects;
using System.Collections.Generic;
using System;

namespace Logistics.Infrastructure
{
    public class LogisticsDbContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; } = null!;


        public LogisticsDbContext(DbContextOptions options) : base(options)
        {
            
        }
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite($"Data Source={DbPath}");
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SubjectEntityTypeConfiguration());
            
            // modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
            // modelBuilder.ApplyConfiguration(new FamilyEntityTypeConfiguration());
        }
    }
}