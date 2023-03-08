using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

                foreach (Title title in dbDataSheet.Titles)
                {
                    context.Remove(title);
                }

                context.Remove(dbDataSheet);

                context.SaveChanges();
            }
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
