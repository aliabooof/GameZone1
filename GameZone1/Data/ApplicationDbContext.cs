﻿using GameZone.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GameZone.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        public DbSet<Game>          Games  { get; set; }
        public DbSet<Category>      Categories  { get; set; }
        public DbSet<Device>        Devices { get; set; }
        public DbSet<GameDevice>    GameDevices  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
     
        }
    }
}
