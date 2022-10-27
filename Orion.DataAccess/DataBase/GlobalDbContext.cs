using Microsoft.EntityFrameworkCore;
using Orion.Domain.Entity;
using Orion.Domain.EntityAirCooledChiller;
using Orion.Domain.EntityAirCooledCondenser;
using Orion.Domain.EntityAirHandler;
using Orion.Domain.EntityPump;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.DataBase
{
    public class GlobalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Spec> Specs { get; set; }

        public DbSet<CatalogAirCooledChiller> CatalogAirCooledChillers { get; set; }
        public DbSet<ItemAirCooledChiller> ItemAirCooledChillers { get; set; }
        public DbSet<ItemAirCooledChillerCatalogAirCooledChiller> ItemAirCooledChillerCatalogAirCooledChillers { get; set; }
        public DbSet<UnitItemAirCooledChiller> UnitItemAirCooledChillers { get; set; }

        public DbSet<CatalogPump> CatalogPumps { get; set; }
        public DbSet<ItemPumpCatalogPump> ItemPumpCatalogPumps { get; set; }
        public DbSet<ItemPump> ItemPumps { get; set; }
        public DbSet<UnitItemPump> UnitItemPumps { get; set; }

        public DbSet<CatalogAirHandler> CatalogAirHandlers { get; set; }
        public DbSet<ItemAirHandlerCatalogAirHandler> ItemAirHandlerCatalogAirHandlers { get; set; }
        public DbSet<ItemAirHandler> ItemAirHandlers { get; set; }
        public DbSet<UnitItemAirHandler> UnitItemAirHandlers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #region Local Server
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = OrionDb; Trusted_Connection = True; ");
            #endregion
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasMany(p => p.Projects)
                        .WithOne(m => m.User)
                        .HasForeignKey(m => m.UserId);

            modelBuilder.Entity<Project>()
                        .HasMany(p => p.Units)
                        .WithOne(m => m.Project)
                        .HasForeignKey(m => m.ProjectId);

            modelBuilder.Entity<UnitItemAirCooledChiller>()
            .HasKey(x => new { x.UnitId, x.ItemAirCooledChillerId });

            modelBuilder.Entity<ItemAirCooledChillerCatalogAirCooledChiller>()
            .HasKey(x => new { x.ItemAirCooledChillerId, x.CatalogAirCooledChillerId });

            modelBuilder.Entity<UnitItemPump>()
            .HasKey(x => new { x.UnitId, x.ItemPumpId });

            modelBuilder.Entity<ItemPumpCatalogPump>()
            .HasKey(x => new { x.ItemPumpId, x.CatalogPumpId });

            modelBuilder.Entity<UnitItemAirHandler>()
            .HasKey(x => new { x.UnitId, x.ItemAirHandlerId });

            modelBuilder.Entity<ItemAirHandlerCatalogAirHandler>()
            .HasKey(x => new { x.ItemAirHandlerId, x.CatalogAirHandlerId });

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemAirCooledChiller)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemAirCooledChillerId)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemPump)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemPumpId)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemAirHandler)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemAirHandlerId)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>()
                        .HasMany(p => p.Specs)
                        .WithOne(m => m.Title)
                        .HasForeignKey(m => m.TitleId);
        }
    }
}
