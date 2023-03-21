using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedCircuits;
using Orion.Domain.EntityItemBACCoolingTowers;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Service
{
    public class DataSheetService
    {
        public DataSheet CreateDataSheet(ObservableCollection<Title> titles, Product product)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                DataSheet dataSheet = new DataSheet();

                dataSheet.ProductId = product.Id;

                context.DataSheets.Add(dataSheet);

                dataSheet.Titles = titles.ToList();

                dataSheet.Titles.ToList().ForEach(x => x.DataSheet = dataSheet);

                context.SaveChanges();

                return dataSheet;
            }
        }

        public void DeleteDataSheet(DataSheet dataSheet)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                DataSheet dbDataSheet = context.DataSheets.Include(x => x.Titles).FirstOrDefault(x => x.Id == dataSheet.Id);

                RemoveDataSheetRefereceFromCatalog(dataSheet, context);

                foreach (Title title in dbDataSheet.Titles)
                {
                    context.Remove(title);
                }
                context.Remove(dbDataSheet);

                context.SaveChanges();
            }
        }

        private void RemoveDataSheetRefereceFromCatalog(DataSheet dataSheet, GlobalDbContext context)
        {
            List<ICatalog> catalogs = new List<ICatalog>();

            catalogs.AddRange(context.CatalogA1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogA2s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogA3s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogA4s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            
            catalogs.AddRange(context.CatalogB1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogB2s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogB3s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogB4s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogB5s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            
            catalogs.AddRange(context.CatalogC1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogC2s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogC3s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogC4s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
           
            catalogs.AddRange(context.CatalogD1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogD2s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            
            catalogs.AddRange(context.CatalogE1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogE2s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogE3s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogE4s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogE5s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogE6s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogE7s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            
            catalogs.AddRange(context.CatalogF1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
           
            catalogs.AddRange(context.CatalogG1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogG2s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogG3s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogG4s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogG5s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogG6s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
           
            catalogs.AddRange(context.CatalogH1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogH2s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogH3s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogH4s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogH5s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());

            catalogs.AddRange(context.CatalogI1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogI2s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());

            catalogs.AddRange(context.CatalogJ1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());

            catalogs.AddRange(context.CatalogK1s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogK2s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());
            catalogs.AddRange(context.CatalogK3s.Include(x => x.DataSheet).Where(x => x.DataSheetId == dataSheet.Id).ToList());


        }

        public IList<DataSheet> GetDataSheetsByIndex(string index)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.DataSheets.Include(x => x.Titles).ThenInclude(x => x.Specs).Include(x => x.Product).Where(x => x.Product.Index.ToFormat() == index.ToFormat()).ToList();
            }
        }

        public IList<DataSheet> GetDataSheetsByProductId(int productId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.DataSheets.Include(x => x.Titles).ThenInclude(x => x.Specs).Where(x => x.ProductId == productId).ToList();
            }
        }
    }
}
