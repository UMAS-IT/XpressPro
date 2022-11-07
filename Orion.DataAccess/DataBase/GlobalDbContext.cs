using Microsoft.EntityFrameworkCore;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;

namespace Orion.DataAccess.DataBase
{
    public class GlobalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Spec> Specs { get; set; }

        public DbSet<CatalogA1> CatalogA1s { get; set; }
        public DbSet<ItemA1> ItemA1s { get; set; }

        public DbSet<CatalogA2> CatalogA2s { get; set; }
        public DbSet<ItemA2> ItemA2s { get; set; }

        public DbSet<CatalogA3> CatalogA3s { get; set; }
        public DbSet<ItemA3> ItemA3s { get; set; }

        public DbSet<CatalogA4> CatalogA4s { get; set; }
        public DbSet<ItemA4> ItemA4s { get; set; }

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
                        .HasMany(p => p.ItemA1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemA2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemA3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemA4s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Items
            //modelBuilder.Entity<ItemUnitCatalogUnit>()
            //.HasKey(x => new { x.ItemId, x.CatalogId });

            //modelBuilder.Entity<ItemUnitCatalogUnit>()
            //.HasOne(x => x.ItemUnit)
            //.WithMany(s => s.ItemUnitCatalogUnits)
            //.HasForeignKey(sc => sc.ItemId);

            //modelBuilder.Entity<ItemUnitCatalogUnit>()
            //.HasOne(x => x.CatalogUnit)
            //.WithMany(s => s.ItemUnitCatalogUnits)
            //.HasForeignKey(sc => sc.CatalogId);
            #endregion

            #region Pump
            //modelBuilder.Entity<ItemPumpCatalogPump>()
            //.HasKey(x => new { x.ItemId, x.CatalogId });

            //modelBuilder.Entity<ItemPumpCatalogPump>()
            //.HasOne(x => x.ItemPump)
            //.WithMany(s => s.ItemPumpCatalogPumps)
            //.HasForeignKey(sc => sc.ItemId);

            //modelBuilder.Entity<ItemPumpCatalogPump>()
            //.HasOne(x => x.CatalogPump)
            //.WithMany(s => s.ItemPumpCatalogPumps)
            //.HasForeignKey(sc => sc.CatalogId);
            #endregion

            #region Air Cooled Chiller
            //modelBuilder.Entity<ItemAirCooledChillerCatalogAirCooledChiller>()
            //.HasKey(x => new { x.ItemId, x.CatalogId });

            //modelBuilder.Entity<ItemAirCooledChillerCatalogAirCooledChiller>()
            //.HasOne(x => x.ItemAirCooledChiller)
            //.WithMany(s => s.ItemAirCooledChillerCatalogAirCooledChillers)
            //.HasForeignKey(sc => sc.ItemId);

            //modelBuilder.Entity<ItemAirCooledChillerCatalogAirCooledChiller>()
            //.HasOne(x => x.CatalogAirCooledChiller)
            //.WithMany(s => s.ItemAirCooledChillerCatalogAirCooledChillers)
            //.HasForeignKey(sc => sc.CatalogId);
            #endregion

            #region Vfd
            //modelBuilder.Entity<ItemVfdCatalogVfd>()
            //.HasKey(x => new { x.ItemId, x.CatalogId });

            //modelBuilder.Entity<ItemVfdCatalogVfd>()
            //.HasOne(x => x.ItemVfd)
            //.WithMany(s => s.ItemVfdCatalogVfds)
            //.HasForeignKey(sc => sc.ItemId);

            //modelBuilder.Entity<ItemVfdCatalogVfd>()
            //.HasOne(x => x.CatalogVfd)
            //.WithMany(s => s.ItemVfdCatalogVfds)
            //.HasForeignKey(sc => sc.CatalogId);
            #endregion

            #region Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogA1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogA1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogA2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogA2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogA3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogA3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogA4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogA4Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemA1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemA1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemA2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemA2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemA3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemA3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemA4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemA4Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>()
                        .HasMany(p => p.Specs)
                        .WithOne(m => m.Title)
                        .HasForeignKey(m => m.TitleId);
            #endregion
        }
    }
}
