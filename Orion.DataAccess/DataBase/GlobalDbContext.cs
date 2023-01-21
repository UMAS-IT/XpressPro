using Microsoft.EntityFrameworkCore;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;

namespace Orion.DataAccess.DataBase
{
    public class GlobalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Spec> Specs { get; set; }

        #region Quantech Catalogs
        public DbSet<CatalogA1> CatalogA1s { get; set; }
        public DbSet<CatalogA2> CatalogA2s { get; set; }
        public DbSet<CatalogA3> CatalogA3s { get; set; }
        public DbSet<CatalogA4> CatalogA4s { get; set; }
        #endregion

        #region Quantech Items
        public DbSet<ItemA1> ItemA1s { get; set; }
        public DbSet<ItemA2> ItemA2s { get; set; }
        public DbSet<ItemA3> ItemA3s { get; set; }
        public DbSet<ItemA4> ItemA4s { get; set; }

        #endregion

        #region ABB Catalogs
        public DbSet<CatalogB1> CatalogB1s { get; set; }
        public DbSet<CatalogB2> CatalogB2s { get; set; }
        public DbSet<CatalogB3> CatalogB3s { get; set; }
        public DbSet<CatalogB4> CatalogB4s { get; set; }
        public DbSet<CatalogB5> CatalogB5s { get; set; }
        #endregion

        #region ABB Items
        public DbSet<ItemB1> ItemB1s { get; set; }
        public DbSet<ItemB2> ItemB2s { get; set; }
        public DbSet<ItemB3> ItemB3s { get; set; }
        public DbSet<ItemB4> ItemB4s { get; set; }
        public DbSet<ItemB5> ItemB5s { get; set; }
        #endregion


        #region American Wheatley Catalogs
        public DbSet<CatalogC1> CatalogC1s { get; set; }
        public DbSet<CatalogC2> CatalogC2s { get; set; }
        public DbSet<CatalogC3> CatalogC3s { get; set; }
        public DbSet<CatalogC4> CatalogC4s { get; set; }
        #endregion

        #region American Wheatley Items
        public DbSet<ItemC1> ItemC1s { get; set; }
        public DbSet<ItemC2> ItemC2s { get; set; }
        public DbSet<ItemC3> ItemC3s { get; set; }
        public DbSet<ItemC4> ItemC4s { get; set; }
        #endregion


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

            modelBuilder.Entity<Title>()
                        .HasMany(p => p.Specs)
                        .WithOne(m => m.Title)
                        .HasForeignKey(m => m.TitleId);

            #region Quantech Quote Items
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

            #region ABB Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemB1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemB2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemB3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemB4s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemB5s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region American Wheatley Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemC1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemC2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemC3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemC4s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion



            #region Quantech Catalog Titles
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
            #endregion

            #region Quantech Item Titles
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
            #endregion



            #region ABB Catalog Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogB1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogB1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogB2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogB2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogB3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogB3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogB4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogB4Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogB5)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogB5Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion

            #region ABB Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemB1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemB1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemB2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemB2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemB3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemB3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemB4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemB4Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemB5)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemB5Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region American Wheatley Catalog Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogC1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogC1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogC2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogC2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogC3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogC3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.CatalogC4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.CatalogC4Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion

            #region Quantech Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemC1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemC1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemC2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemC2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemC3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemC3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemC4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemC4Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion
        }
    }
}
