using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Service
{
    public class CompanyService
    {
        public IList<Company> GetCompanies()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<Company> companies = context.Companies.Include(x => x.Products).ToList();

                companies.ForEach(x => x.Products = x.Products.Where(y => y.InService).OrderBy(y => y.Name).ToList());

                return companies;
            }
        }

        public Product GetProduct(IList<Company> companies, string index)
        {
            Product product = null;

            product = companies.SelectMany(x => x.Products).FirstOrDefault(x => x.Index.ToFormat() == index.ToFormat());

            return product;
        }
    }
}
