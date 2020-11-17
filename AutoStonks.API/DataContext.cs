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
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<AdvertDetails> AdvertDetails { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<AdvertEquipment> AdvertEquipment { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAdvert> UserAdverts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Generation> Generations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Many-To-Many --> AdverEquipment
            modelBuilder.Entity<AdvertEquipment>()
                .HasKey(ae => new {ae.AdvertId, ae.EquipmentId });
            modelBuilder.Entity<AdvertEquipment>()
                .HasOne(ae => ae.Advert)
                .WithMany(a => a.AdvertEquipments)
                .HasForeignKey(ae => ae.AdvertId);
            modelBuilder.Entity<AdvertEquipment>()
                .HasOne(ae => ae.Equipment)
                .WithMany(e => e.AdvertEquipments)
                .HasForeignKey(ae => ae.EquipmentId);
            //Many-To-Many --> UserAdvert
            modelBuilder.Entity<UserAdvert>()
                .HasKey(ua => new { ua.AdvertId, ua.UserId });
            modelBuilder.Entity<UserAdvert>()
                .HasOne(ua => ua.Advert)
                .WithMany(a => a.UserAdverts)
                .HasForeignKey(ua => ua.AdvertId);
            modelBuilder.Entity<UserAdvert>()
                .HasOne(ua => ua.User)
                .WithMany(u => u.UserAdverts)
                .HasForeignKey(ua => ua.UserId);
        }
    }
}
