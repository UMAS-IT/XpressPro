using Microsoft.EntityFrameworkCore;
using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogBACClosedLoopTowers;
using Orion.Domain.EntityCatalogBACOpenLoopTowers;
using Orion.Domain.EntityCatalogGeneralProduct;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Domain.EntityItemGeneralProduct;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Domain.Marvair;
using Orion.Domain.Marvair.Catalog;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Catalog;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.PACE.Catalog;
using Orion.Domain.PACE.Item;
using Orion.Domain.UMAS.Catalog;
using Orion.Domain.UMAS.Item;
using Orion.Domain.UvResources.Related;

namespace Orion.DataAccess.DataBase
{
    public class GlobalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Spec> Specs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<DataSheet> DataSheets { get; set; }
        public DbSet<QuoteCompanies> QuoteCompanies { get; set; }



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
        public DbSet<CatalogC5> CatalogC5s { get; set; }
        public DbSet<CatalogC6> CatalogC6s { get; set; }
        public DbSet<CatalogC7> CatalogC7s { get; set; }
        #endregion

        #region American Wheatley Items
        public DbSet<ItemC1> ItemC1s { get; set; }
        public DbSet<ItemC2> ItemC2s { get; set; }
        public DbSet<ItemC3> ItemC3s { get; set; }
        public DbSet<ItemC4> ItemC4s { get; set; }
        public DbSet<ItemC5> ItemC5s { get; set; }
        public DbSet<ItemC6> ItemC6s { get; set; }
        public DbSet<ItemC7> ItemC7s { get; set; }
        #endregion

        #region American Wheatley Related
        public DbSet<CatalogC3ProductType> CatalogC3ProductTypes { get; set; }
        public DbSet<CatalogC1ProductType> CatalogC1ProductTypes { get; set; }

        #endregion



        #region Puroflux Catalogs
        public DbSet<CatalogD1> CatalogD1s { get; set; }
        public DbSet<CatalogD2> CatalogD2s { get; set; }
        #endregion

        #region Puroflux Items
        public DbSet<ItemD1> ItemD1s { get; set; }
        public DbSet<ItemD2> ItemD2s { get; set; }
        #endregion



        #region Groundfos Catalogs
        public DbSet<CatalogE1> CatalogE1s { get; set; }
        public DbSet<CatalogE2> CatalogE2s { get; set; }
        public DbSet<CatalogE3> CatalogE3s { get; set; }
        public DbSet<CatalogE4> CatalogE4s { get; set; }
        public DbSet<CatalogE5> CatalogE5s { get; set; }
        public DbSet<CatalogE6> CatalogE6s { get; set; }
        public DbSet<CatalogE7> CatalogE7s { get; set; }
        #endregion

        #region Groundfos Items
        public DbSet<ItemE1> ItemE1s { get; set; }
        public DbSet<ItemE2> ItemE2s { get; set; }
        public DbSet<ItemE3> ItemE3s { get; set; }
        public DbSet<ItemE4> ItemE4s { get; set; }
        public DbSet<ItemE5> ItemE5s { get; set; }
        public DbSet<ItemE6> ItemE6s { get; set; }
        public DbSet<ItemE7> ItemE7s { get; set; }
        #endregion



        #region UV Resources Catalogs
        public DbSet<CatalogF1> CatalogF1s { get; set; }
        #endregion

        #region UV Resources Items
        public DbSet<ItemF1> ItemF1s { get; set; }
        #endregion

        #region UV Resources Related
        public DbSet<CatalogF1ProductType> CatalogF1ProductTypes { get; set; }
        #endregion



        #region BAC Cooling Towers Catalogs
        public DbSet<CatalogG1> CatalogG1s { get; set; }
        public DbSet<CatalogG2> CatalogG2s { get; set; }
        public DbSet<CatalogG3> CatalogG3s { get; set; }
        public DbSet<CatalogG4> CatalogG4s { get; set; }
        public DbSet<CatalogG5> CatalogG5s { get; set; }
        public DbSet<CatalogG6> CatalogG6s { get; set; }
        #endregion

        #region BAC Cooling Towers Items
        public DbSet<ItemG1> ItemG1s { get; set; }
        public DbSet<ItemG2> ItemG2s { get; set; }
        public DbSet<ItemG3> ItemG3s { get; set; }
        public DbSet<ItemG4> ItemG4s { get; set; }
        public DbSet<ItemG5> ItemG5s { get; set; }
        public DbSet<ItemG6> ItemG6s { get; set; }
        #endregion



        #region BAC Closed Circuits Catalogs
        public DbSet<CatalogH1> CatalogH1s { get; set; }
        public DbSet<CatalogH2> CatalogH2s { get; set; }
        public DbSet<CatalogH3> CatalogH3s { get; set; }
        public DbSet<CatalogH4> CatalogH4s { get; set; }
        public DbSet<CatalogH5> CatalogH5s { get; set; }
        #endregion

        #region BAC Closed Circuits Items
        public DbSet<ItemH1> ItemH1s { get; set; }
        public DbSet<ItemH2> ItemH2s { get; set; }
        public DbSet<ItemH3> ItemH3s { get; set; }
        public DbSet<ItemH4> ItemH4s { get; set; }
        public DbSet<ItemH5> ItemH5s { get; set; }
        #endregion



        #region Marvair Catalogs
        public DbSet<CatalogI1> CatalogI1s { get; set; }
        public DbSet<CatalogI2> CatalogI2s { get; set; }
        #endregion

        #region Marvair Items
        public DbSet<ItemI1> ItemI1s { get; set; }
        public DbSet<ItemI2> ItemI2s { get; set; }
        #endregion



        #region PACE AHU Catalogs
        public DbSet<CatalogJ1> CatalogJ1s { get; set; }
        #endregion

        #region PACE AHU Items
        public DbSet<ItemJ1> ItemJ1s { get; set; }
        #endregion



        #region Multiaqua Catalogs
        public DbSet<CatalogK1> CatalogK1s { get; set; }
        public DbSet<CatalogK2> CatalogK2s { get; set; }
        public DbSet<CatalogK3> CatalogK3s { get; set; }
        #endregion

        #region Multiaqua Items
        public DbSet<ItemK1> ItemK1s { get; set; }
        public DbSet<ItemK2> ItemK2s { get; set; }
        public DbSet<ItemK3> ItemK3s { get; set; }
        #endregion



        #region General Product Catalogs
        public DbSet<CatalogL1> CatalogL1s { get; set; }
        #endregion

        #region General Product Items
        public DbSet<ItemL1> ItemL1s { get; set; }
        #endregion



        #region UMAS AHU Catalogs
        public DbSet<CatalogM1> CatalogM1s { get; set; }
        #endregion

        #region UMAS AHU Items
        public DbSet<ItemM1> ItemM1s { get; set; }
        #endregion


        #region ABOVEAIR Catalogs
        public DbSet<CatalogN1> CatalogN1s { get; set; }
        #endregion

        #region ABOVEAIR Items
        public DbSet<ItemN1> ItemN1s { get; set; }
        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #region Local Server
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = OrionDb; Trusted_Connection = True; ");

            //optionsBuilder.UseSqlServer("Server=tcp:airtreatment.database.windows.net,1433;Initial Catalog=OrionDb;Persist Security Info=False;User ID=airtreatmentAdb;Password=airtreatment2022.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            #endregion
        }
        //User ID = umasAdb; Password=Umas2022.;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasOne(sf => sf.Permission)
                        .WithOne(x => x.User)
                        .HasForeignKey<Permission>(x => x.UserId);

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

            modelBuilder.Entity<Company>()
                        .HasMany(p => p.Products)
                        .WithOne(m => m.Company)
                        .HasForeignKey(m => m.CompanyId);

            modelBuilder.Entity<Product>()
                        .HasMany(p => p.DataSheets)
                        .WithOne(m => m.Product)
                        .HasForeignKey(m => m.ProductId);

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.DataSheet)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.DataSheetId)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<QuoteCompanies>()
            .HasKey(x => new { x.QuoteId, x.CompanyId });

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

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemC5s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemC6s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemC7s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region American Wheatley Item Titles
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

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemC5)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemC5Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemC6)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemC6Id)
                        .OnDelete(DeleteBehavior.Restrict));
            
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemC7)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemC7Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Puroflux Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemD1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemD2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Puroflux Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemD1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemD1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemD2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemD2Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Groundfos Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemE1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemE2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemE3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemE4s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemE5s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemE6s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemE7s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Groundfos Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemE1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemE1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemE2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemE2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemE3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemE3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemE4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemE4Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemE5)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemE5Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemE6)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemE6Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemE7)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemE7Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region UV Resources Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemF1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region UV Resources Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemF1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemF1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region BAC Cooling Towers Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemG1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemG2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemG3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemG4s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemG5s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemG6s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region BAC Cooling Towers Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemG1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemG1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemG2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemG2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemG3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemG3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemG4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemG4Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemG5)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemG5Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemG6)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemG6Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region BAC Closed Circuits Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemH1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemH2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemH3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemH4s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemH5s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region BAC Closed Circuits Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemH1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemH1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemH2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemH2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemH3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemH3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemH4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemH4Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemH5)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemH5Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Marvair Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemI1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemI2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Marvair Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemI1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemI1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemI2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemI2Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region PACE AHU Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemJ1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region PACE AHU Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemJ1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemJ1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Multiaqua Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemK1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemK2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemK3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Multiaqua Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemK1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemK1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemK2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemK2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemK3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemK3Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region General Product Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemL1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region General Product Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemL1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemL1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region UMAS AHU Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemM1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region UMAS AHU Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemM1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemM1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region AVOBEAIR Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemN1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region AVOBEAIR Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemN1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemN1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion
        }
    }
}
