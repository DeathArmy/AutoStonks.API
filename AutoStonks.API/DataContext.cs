using AutoStonks.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API
{
    public class DataContext : DbContext
    {
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<AdvertEquipment> AdvertEquipment { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Generation> Generations { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Many-To-Many --> AdverEquipment
            modelBuilder.Entity<AdvertEquipment>()
                .HasKey(ae => new { ae.AdvertId, ae.EquipmentId });
            modelBuilder.Entity<AdvertEquipment>()
                .HasOne(ae => ae.Advert)
                .WithMany(a => a.AdvertEquipments)
                .HasForeignKey(ae => ae.AdvertId);
            modelBuilder.Entity<AdvertEquipment>()
                .HasOne(ae => ae.Equipment)
                .WithMany(e => e.AdvertEquipments)
                .HasForeignKey(ae => ae.EquipmentId);

            modelBuilder.Seed();
        }
    }
}
