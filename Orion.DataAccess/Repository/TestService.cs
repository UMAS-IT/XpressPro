using Orion.DataAccess.DataBase;
using Orion.DataAccess.UnitOfWork;
using Orion.Domain.EntityCatalogQuantech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Repository
{
    public class TestService
    {
        private readonly CatalogUnitOfWork _unitOfWork;

        public TestService()
        {
            GlobalDbContext context = new GlobalDbContext();

            _unitOfWork = new CatalogUnitOfWork(context);
        }

        public IGenericRepository<CatalogA1> CatalogA1Repository => _unitOfWork.GetRepository<CatalogA1>();
    }
}
