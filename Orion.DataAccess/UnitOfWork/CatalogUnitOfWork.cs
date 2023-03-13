using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.Repository;
using Orion.Domain.EntityCatalogQuantech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.UnitOfWork
{
    public class CatalogUnitOfWork : ICatalogUnitOfWork
    {
        private readonly DbContext _context;
        private Dictionary<Type, object> _repositories;

        public CatalogUnitOfWork(DbContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();

            _repositories.Add(typeof(CatalogA1), new CatalogA1Repository(_context));
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return _repositories[typeof(T)] as IGenericRepository<T>;
            }

            var repository = new GenericRepository<T>(_context);
            _repositories.Add(typeof(T), repository);

            return repository;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
