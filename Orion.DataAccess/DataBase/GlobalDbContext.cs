using Microsoft.EntityFrameworkCore;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemCatalog;
using System.Security.Cryptography.X509Certificates;

namespace Orion.DataAccess.DataBase
{
    public class GlobalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Spec> Specs { get; set; }

        public DbSet<CatalogAirCooledChiller> CatalogAirCooledChillers { get; set; }
        public DbSet<ItemAirCooledChiller> ItemAirCooledChillers { get; set; }
        public DbSet<ItemAirCooledChillerCatalogAirCooledChiller> ItemAirCooledChillerCatalogAirCooledChillers { get; set; }

        public DbSet<CatalogPump> CatalogPumps { get; set; }
        public DbSet<ItemPumpCatalogPump> ItemPumpCatalogPumps { get; set; }
        public DbSet<ItemPump> ItemPumps { get; set; }

        public DbSet<CatalogUnit> CatalogUnits { get; set; }
        public DbSet<ItemUnitCatalogUnit> ItemUnitCatalogUnits { get; set; }
        public DbSet<ItemUnit> ItemUnits { get; set; }

        public DbSet<CatalogVfd> CatalogVfds { get; set; }
        public DbSet<ItemVfdCatalogVfd> ItemVfdCatalogVfds { get; set; }
        public DbSet<ItemVfd> ItemVfds { get; set; }

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
                        .HasMany(p => p.Quotes)
                        .WithOne(m => m.Project)
                        .HasForeignKey(m => m.ProjectId);
           
            #region Quote
            modelBuilder.Entity<Quote>()
            .HasOne(sf => sf.ItemUnit)
            .WithOne(x => x.Quote)
            .HasForeignKey<ItemUnit>(x => x.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasOne(sf => sf.ItemPump)
                        .WithOne(x => x.Quote)
                        .HasForeignKey<ItemPump>(x => x.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasOne(sf => sf.ItemVfd)
                        .WithOne(x => x.Quote)
                        .HasForeignKey<ItemVfd>(x => x.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasOne(sf => sf.ItemAirCooledChiller)
                        .WithOne(x => x.Quote)
                        .HasForeignKey<ItemAirCooledChiller>(x => x.QuoteId);
            #endregion

            #region Unit
            modelBuilder.Entity<ItemUnitCatalogUnit>()
            .HasKey(x => new { x.ItemId, x.CatalogId });

            modelBuilder.Entity<ItemUnitCatalogUnit>()
            .HasOne(x => x.ItemUnit)
            .WithMany(s => s.ItemUnitCatalogUnits)
            .HasForeignKey(sc => sc.ItemId);

            modelBuilder.Entity<ItemUnitCatalogUnit>()
            .HasOne(x => x.CatalogUnit)
            .WithMany(s => s.ItemUnitCatalogUnits)
            .HasForeignKey(sc => sc.CatalogId);
            #endregion

            #region Pump
            modelBuilder.Entity<ItemPumpCatalogPump>()
            .HasKey(x => new { x.ItemId, x.CatalogId });

            modelBuilder.Entity<ItemPumpCatalogPump>()
            .HasOne(x => x.ItemPump)
            .WithMany(s => s.ItemPumpCatalogPumps)
            .HasForeignKey(sc => sc.ItemId);

            modelBuilder.Entity<ItemPumpCatalogPump>()
            .HasOne(x => x.CatalogPump)
            .WithMany(s => s.ItemPumpCatalogPumps)
            .HasForeignKey(sc => sc.CatalogId);
            #endregion

            #region Air Cooled Chiller
            modelBuilder.Entity<ItemAirCooledChillerCatalogAirCooledChiller>()
            .HasKey(x => new { x.ItemId, x.CatalogId });

            modelBuilder.Entity<ItemAirCooledChillerCatalogAirCooledChiller>()
            .HasOne(x => x.ItemAirCooledChiller)
            .WithMany(s => s.ItemAirCooledChillerCatalogAirCooledChillers)
            .HasForeignKey(sc => sc.ItemId);

            modelBuilder.Entity<ItemAirCooledChillerCatalogAirCooledChiller>()
            .HasOne(x => x.CatalogAirCooledChiller)
            .WithMany(s => s.ItemAirCooledChillerCatalogAirCooledChillers)
            .HasForeignKey(sc => sc.CatalogId);
            #endregion

            #region Vfd
            modelBuilder.Entity<ItemVfdCatalogVfd>()
            .HasKey(x => new { x.ItemId, x.CatalogId });

            modelBuilder.Entity<ItemVfdCatalogVfd>()
            .HasOne(x => x.ItemVfd)
            .WithMany(s => s.ItemVfdCatalogVfds)
            .HasForeignKey(sc => sc.ItemId);

            modelBuilder.Entity<ItemVfdCatalogVfd>()
            .HasOne(x => x.CatalogVfd)
            .WithMany(s => s.ItemVfdCatalogVfds)
            .HasForeignKey(sc => sc.CatalogId);
            #endregion

            #region Titles
            modelBuilder.Entity<Title>(entry =>
            entry.HasOne(d => d.CatalogUnit)
            .WithMany(x => x.Titles).IsRequired(false)
            .HasForeignKey(y => y.CatalogUnitId)
            .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogPump)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogPumpId)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogAirCooledChiller)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogAirCooledChillerId)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogVfd)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogVfdId)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>()
                        .HasMany(p => p.Specs)
                        .WithOne(m => m.Title)
                        .HasForeignKey(m => m.TitleId);
            #endregion
        }
    }
}
