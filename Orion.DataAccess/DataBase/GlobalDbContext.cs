using Microsoft.EntityFrameworkCore;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemCatalog;

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

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemUnits)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemPumps)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemAirCooledChillers)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemVfds)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<ItemUnitCatalogUnit>()
            .HasKey(x => new { x.ItemUnitId, x.CatalogUnitId });
            
            modelBuilder.Entity<ItemPumpCatalogPump>()
            .HasKey(x => new { x.ItemPumpId, x.CatalogPumpId });
            
            modelBuilder.Entity<ItemAirCooledChillerCatalogAirCooledChiller>()
            .HasKey(x => new { x.ItemAirCooledChillerId, x.CatalogAirCooledChillerId });

            modelBuilder.Entity<ItemVfdCatalogVfd>()
            .HasKey(x => new { x.ItemVfdId, x.CatalogVfdId });

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
        }
    }
}
