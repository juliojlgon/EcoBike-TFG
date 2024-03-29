﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Bicimad.Core.DomainObjects;

namespace Bicimad.Core
{
    public class EFRepository : DbContext, IRepository
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Bike> Bikes { get; set; }

        public DbSet<Station> Stations { get; set; }

        public DbSet<Slot> Slots { get; set; } 

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<UserHistory> UserHistories { get; set; }

        public DbSet<MetaConfig> MetaConfigs { get; set; }

        //public DbSet<ApiUser> ApiUsers { get; set; }

        public int Commit()
        {
            return SaveChanges();
        }

        //TODO: Preguntar esto.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}