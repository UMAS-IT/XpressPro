using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
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

                companies.ForEach(x => x.Products = x.Products.Where(y => y.InService).ToList());

                return companies;
            }
        }
    }
}
