using Microsoft.EntityFrameworkCore;
using Planomic.Models;
using System;
using System.IO;

namespace Planomic.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Habit> Habits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "planomic.db");
            options.UseSqlite($"Filename={dbPath}");
        }
    }
}