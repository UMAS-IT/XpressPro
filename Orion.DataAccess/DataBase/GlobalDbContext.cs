using Microsoft.EntityFrameworkCore;
using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AERCO.Catalog;
using Orion.Domain.AERCO.Item;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Baldor.Catalog;
using Orion.Domain.Baldor.Item;
using Orion.Domain.Condair.Catalog;
using Orion.Domain.Condair.Item;
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
using Orion.Domain.EnviroTec.Catalog;
using Orion.Domain.EnviroTec.Item;
using Orion.Domain.LYNC.Catalog;
using Orion.Domain.LYNC.Item;
using Orion.Domain.Marvair;
using Orion.Domain.Marvair.Catalog;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Catalog;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.Nortek.Catalog;
using Orion.Domain.Nortek.Item;
using Orion.Domain.NYLE.Catalog;
using Orion.Domain.NYLE.Item;
using Orion.Domain.PACE.Catalog;
using Orion.Domain.PACE.Item;
using Orion.Domain.PlasmaAir.Catalog;
using Orion.Domain.PlasmaAir.Item;
using Orion.Domain.Polaris.Catalog;
using Orion.Domain.Polaris.Item;
using Orion.Domain.PVI.Catalog;
using Orion.Domain.PVI.Item;
using Orion.Domain.Robur.Catalog;
using Orion.Domain.Robur.Item;
using Orion.Domain.UMAS.Catalog;
using Orion.Domain.UMAS.Item;
using Orion.Domain.UvResources.Related;
using Orion.Domain.Valent.Catalog;
using Orion.Domain.Valent.Item;
using Orion.Domain.Whalen.Catalog;
using Orion.Domain.Whalen.Item;

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



        #region AERCO Catalogs
        public DbSet<CatalogO1> CatalogO1s { get; set; }
        public DbSet<CatalogO2> CatalogO2s { get; set; }
        #endregion

        #region AERCO Items
        public DbSet<ItemO1> ItemO1s { get; set; }
        public DbSet<ItemO2> ItemO2s { get; set; }
        #endregion



        #region Baldor Catalogs
        public DbSet<CatalogP1> CatalogP1s { get; set; }
        #endregion

        #region Baldor Items
        public DbSet<ItemP1> ItemP1s { get; set; }
        #endregion



        #region Condair Catalogs
        public DbSet<CatalogQ1> CatalogQ1s { get; set; }
        public DbSet<CatalogQ2> CatalogQ2s { get; set; }
        public DbSet<CatalogQ3> CatalogQ3s { get; set; }
        public DbSet<CatalogQ4> CatalogQ4s { get; set; }
        #endregion

        #region Condair Items
        public DbSet<ItemQ1> ItemQ1s { get; set; }
        public DbSet<ItemQ2> ItemQ2s { get; set; }
        public DbSet<ItemQ3> ItemQ3s { get; set; }
        public DbSet<ItemQ4> ItemQ4s { get; set; }
        #endregion



        #region Enviro-Tec Catalogs
        public DbSet<CatalogR1> CatalogR1s { get; set; }
        public DbSet<CatalogR2> CatalogR2s { get; set; }
        public DbSet<CatalogR3> CatalogR3s { get; set; }
        public DbSet<CatalogR4> CatalogR4s { get; set; }
        #endregion

        #region Enviro-Tec Items
        public DbSet<ItemR1> ItemR1s { get; set; }
        public DbSet<ItemR2> ItemR2s { get; set; }
        public DbSet<ItemR3> ItemR3s { get; set; }
        public DbSet<ItemR4> ItemR4s { get; set; }
        #endregion



        #region LYNC Catalogs
        public DbSet<CatalogS1> CatalogS1s { get; set; }
        #endregion

        #region LYNC Items
        public DbSet<ItemS1> ItemS1s { get; set; }
        #endregion



        #region Nortek Catalogs
        public DbSet<CatalogT1> CatalogT1s { get; set; }
        public DbSet<CatalogT2> CatalogT2s { get; set; }
        public DbSet<CatalogT3> CatalogT3s { get; set; }
        #endregion

        #region Nortek Items
        public DbSet<ItemT1> ItemT1s { get; set; }
        public DbSet<ItemT2> ItemT2s { get; set; }
        public DbSet<ItemT3> ItemT3s { get; set; }
        #endregion



        #region NYLE Catalogs
        public DbSet<CatalogU1> CatalogU1s { get; set; }
        #endregion

        #region NYLE Items
        public DbSet<ItemU1> ItemU1s { get; set; }
        #endregion



        #region Plasma Air Catalogs
        public DbSet<CatalogV1> CatalogV1s { get; set; }
        #endregion

        #region Plasma Air Items
        public DbSet<ItemV1> ItemV1s { get; set; }
        #endregion



        #region Polaris Catalogs
        public DbSet<CatalogW1> CatalogW1s { get; set; }
        #endregion

        #region Polaris Items
        public DbSet<ItemW1> ItemW1s { get; set; }
        #endregion



        #region PVI Catalogs
        public DbSet<CatalogX1> CatalogX1s { get; set; }
        public DbSet<CatalogX2> CatalogX2s { get; set; }
        public DbSet<CatalogX3> CatalogX3s { get; set; }
        public DbSet<CatalogX4> CatalogX4s { get; set; }
        public DbSet<CatalogX5> CatalogX5s { get; set; }
        #endregion

        #region PVI Items
        public DbSet<ItemX1> ItemX1s { get; set; }
        public DbSet<ItemX2> ItemX2s { get; set; }
        public DbSet<ItemX3> ItemX3s { get; set; }
        public DbSet<ItemX4> ItemX4s { get; set; }
        public DbSet<ItemX5> ItemX5s { get; set; }
        #endregion



        #region Robur Catalogs
        public DbSet<CatalogY1> CatalogY1s { get; set; }
        #endregion

        #region Robur Items
        public DbSet<ItemY1> ItemY1s { get; set; }
        #endregion



        #region Valent Catalogs
        public DbSet<CatalogZ1> CatalogZ1s { get; set; }
        #endregion

        #region Valent Items
        public DbSet<ItemZ1> ItemZ1s { get; set; }
        #endregion



        #region Whalen Catalogs
        public DbSet<CatalogAA1> CatalogAA1s { get; set; }
        #endregion

        #region Whalen Items
        public DbSet<ItemAA1> ItemAA1s { get; set; }
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



            #region AERCO Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemO1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
            .HasMany(p => p.ItemO2s)
            .WithOne(m => m.Quote)
            .HasForeignKey(m => m.QuoteId);
            #endregion

            #region AERCO Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemO1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemO1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
            entry.HasOne(d => d.ItemO2)
            .WithMany(x => x.Titles).IsRequired(false)
            .HasForeignKey(y => y.ItemO2Id)
            .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Baldor Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemP1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Baldor Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemP1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemP1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Condair Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemQ1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemQ2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemQ3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemQ4s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Condair Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemQ1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemQ1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemQ2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemQ2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemQ3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemQ3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemQ4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemQ4Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Enviro-Tec Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemR1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemR2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemR3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemR4s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Enviro-Tec Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemR1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemR1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemR2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemR2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemR3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemR3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemR4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemR4Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region LYNC Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemS1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region LYNC Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemS1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemS1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Nortek Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemT1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemT2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemT3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Nortek Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemT1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemT1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemT2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemT2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemT3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemT3Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region NYLE Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemU1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region NYLE Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemU1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemU1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region PlasmaAir Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemV1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region PlasmaAir Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemV1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemV1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Polaris Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemW1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Polaris Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemW1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemW1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region PVI Quote Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemX1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemX2s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemX3s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemX4s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);

            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemX5s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region PVI Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemX1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemX1Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemX2)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemX2Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemX3)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemX3Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemX4)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemX4Id)
                        .OnDelete(DeleteBehavior.Restrict));

            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemX5)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemX5Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Robur Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemY1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Robur Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemY1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemY1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Valent Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemZ1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Valent Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemZ1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemZ1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion



            #region Whalen Items
            modelBuilder.Entity<Quote>()
                        .HasMany(p => p.ItemAA1s)
                        .WithOne(m => m.Quote)
                        .HasForeignKey(m => m.QuoteId);
            #endregion

            #region Whalen Item Titles
            modelBuilder.Entity<Title>(entry =>
                        entry.HasOne(d => d.ItemAA1)
                        .WithMany(x => x.Titles).IsRequired(false)
                        .HasForeignKey(y => y.ItemAA1Id)
                        .OnDelete(DeleteBehavior.Restrict));
            #endregion
        }
    }
}
