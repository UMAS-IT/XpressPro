using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogBACClosedCircuits;
using Orion.Domain.EntityCatalogBACCoolingTowers;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;

namespace Orion.DataAccess.Service
{
    public class CatalogService
    {
        public bool CatalogModelNameExist(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                if (catalog is CatalogA1)
                    return context.CatalogA1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogA2)
                    return context.CatalogA2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogA3)
                    return context.CatalogA3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogA4)
                    return context.CatalogA4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogB1)
                    return context.CatalogB1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogB2)
                    return context.CatalogB2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogB3)
                    return context.CatalogB3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogB4)
                    return context.CatalogB4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogB5)
                    return context.CatalogB5s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogC1)
                    return context.CatalogC1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogC2)
                    return context.CatalogC2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogC3)
                    return context.CatalogC3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogC4)
                    return context.CatalogC4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogD1)
                    return context.CatalogD1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogD2)
                    return context.CatalogD2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogE1)
                    return context.CatalogE1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE2)
                    return context.CatalogE2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE3)
                    return context.CatalogE3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE4)
                    return context.CatalogE4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE5)
                    return context.CatalogE5s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE6)
                    return context.CatalogE6s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogE7)
                    return context.CatalogE7s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogF1)
                    return context.CatalogF1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogG1)
                    return context.CatalogG1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG2)
                    return context.CatalogG2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG3)
                    return context.CatalogG3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG4)
                    return context.CatalogG4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG5)
                    return context.CatalogG5s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogG6)
                    return context.CatalogG6s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else if (catalog is CatalogH1)
                    return context.CatalogH1s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogH2)
                    return context.CatalogH2s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogH3)
                    return context.CatalogH3s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogH4)
                    return context.CatalogH4s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);
                else if (catalog is CatalogH5)
                    return context.CatalogH5s.Any(x => x.Model.ToFormat() == catalog.Model.ToFormat() && x.Id != catalog.Id);

                else
                    return true;
            }
        }

        public IList<ICatalog> GetCatalogA1s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogA1s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogA2s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogA2s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogA3s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogA3s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogA4s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogA4s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogB1s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogB1s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogB2s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogB2s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogB3s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogB3s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogB4s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogB4s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogB5s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogB5s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogC1s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogC1s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogC2s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogC2s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogC3s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogC3s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogC4s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogC4s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogD1s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogD1s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogD2s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogD2s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogE1s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogE1s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogE2s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogE2s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogE3s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogE3s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogE4s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogE4s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogE5s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogE5s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogE6s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogE6s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogE7s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogE7s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogF1s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogF1s.Include(x => x.DataSheet).Include(x => x.CatalogF1ProductType).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogG1s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogG1s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogG2s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogG2s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogG3s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogG3s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogG4s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogG4s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogG5s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogG5s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogG6s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogG6s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogH1s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogH1s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogH2s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogH2s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogH3s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogH3s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogH4s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogH4s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public IList<ICatalog> GetCatalogH5s()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.CatalogH5s.Include(x => x.DataSheet).ToList<ICatalog>();
            }
        }

        public ICatalog GetCatalogByCatalogId(ICatalog catalog, GlobalDbContext refContext = null)
        {
            using (GlobalDbContext context = refContext == null ? new GlobalDbContext() : refContext)
            {
                if (catalog is CatalogA1)
                    return context.CatalogA1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogA2)
                    return context.CatalogA2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogA3)
                    return context.CatalogA3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogA4)
                    return context.CatalogA4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogB1)
                    return context.CatalogB1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB2)
                    return context.CatalogB2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB3)
                    return context.CatalogB3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB4)
                    return context.CatalogB4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB5)
                    return context.CatalogB5s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogC1)
                    return context.CatalogC1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC2)
                    return context.CatalogC2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC3)
                    return context.CatalogC3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC4)
                    return context.CatalogC4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogD1)
                    return context.CatalogD1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogD2)
                    return context.CatalogD2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogE1)
                    return context.CatalogE1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE2)
                    return context.CatalogE2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE3)
                    return context.CatalogE3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE4)
                    return context.CatalogE4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE5)
                    return context.CatalogE5s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE6)
                    return context.CatalogE6s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE7)
                    return context.CatalogE7s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogF1)
                    return context.CatalogF1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogG1)
                    return context.CatalogG1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG2)
                    return context.CatalogG2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG3)
                    return context.CatalogG3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG4)
                    return context.CatalogG4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG5)
                    return context.CatalogG5s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG6)
                    return context.CatalogG6s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogH1)
                    return context.CatalogH1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogH2)
                    return context.CatalogH2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogH3)
                    return context.CatalogH3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogH4)
                    return context.CatalogH4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogH5)
                    return context.CatalogH5s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else
                    return null;
            }
        }

        public ICatalog GetCatalogByCatalogIdByContext(ICatalog catalog, GlobalDbContext context)
        {

                if (catalog is CatalogA1)
                    return context.CatalogA1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogA2)
                    return context.CatalogA2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogA3)
                    return context.CatalogA3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogA4)
                    return context.CatalogA4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogB1)
                    return context.CatalogB1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB2)
                    return context.CatalogB2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB3)
                    return context.CatalogB3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB4)
                    return context.CatalogB4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogB5)
                    return context.CatalogB5s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogC1)
                    return context.CatalogC1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC2)
                    return context.CatalogC2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC3)
                    return context.CatalogC3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogC4)
                    return context.CatalogC4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogD1)
                    return context.CatalogD1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogD2)
                    return context.CatalogD2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogE1)
                    return context.CatalogE1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE2)
                    return context.CatalogE2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE3)
                    return context.CatalogE3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE4)
                    return context.CatalogE4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE5)
                    return context.CatalogE5s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE6)
                    return context.CatalogE6s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogE7)
                    return context.CatalogE7s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogF1)
                    return context.CatalogF1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogG1)
                    return context.CatalogG1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG2)
                    return context.CatalogG2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG3)
                    return context.CatalogG3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG4)
                    return context.CatalogG4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG5)
                    return context.CatalogG5s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogG6)
                    return context.CatalogG6s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else if (catalog is CatalogH1)
                    return context.CatalogH1s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogH2)
                    return context.CatalogH2s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogH3)
                    return context.CatalogH3s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogH4)
                    return context.CatalogH4s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);
                else if (catalog is CatalogH5)
                    return context.CatalogH5s.Include(x => x.DataSheet).FirstOrDefault(x => x.Id == catalog.Id);

                else
                    return null;
        }

        public ICatalog UpdateCatalogDataSheet(ICatalog catalog, IList<DataSheet> dataSheets)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                ICatalog dbCatalog = GetCatalogByCatalogIdByContext(catalog, context);

                DataSheet dataSheetSelected = dataSheets.Any(x => x.IsSelected) ? dataSheets.FirstOrDefault(x => x.IsSelected) : null;

                if (dataSheetSelected != null)
                    dataSheetSelected = context.DataSheets.FirstOrDefault(x => x.Id == dataSheetSelected.Id);

                dbCatalog.DataSheet = dataSheetSelected;

                context.Update(dbCatalog);

                context.SaveChanges();

                return dbCatalog;
            }
        }

        public ICatalog UpdateCatalogItem(ICatalog catalog)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                ICatalog dbCatalog = null;

                if (catalog is CatalogA1)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogA1 catalogA1 = catalog as CatalogA1;
                        CatalogA1 dbCatalogA1 = context.CatalogA1s.FirstOrDefault(x => x.Id == catalog.Id);
                        
                        dbCatalogA1.Model = catalogA1.Model;
                        dbCatalogA1.ListPrice = catalogA1.ListPrice;
                        dbCatalogA1.CostMultiplier = catalogA1.CostMultiplier;
                        dbCatalogA1.SellMargin = catalogA1.SellMargin;
                        dbCatalogA1.UnitSize = catalogA1.UnitSize;
                        dbCatalogA1.Description = catalogA1.Description;
                        dbCatalogA1.Voltage = catalogA1.Voltage;

                        context.CatalogA1s.Update(dbCatalogA1);
                        dbCatalog = dbCatalogA1;
                    }
                    else
                    {
                        context.CatalogA1s.Add(catalog as CatalogA1);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogA2)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogA2 catalogA2 = catalog as CatalogA2;
                        CatalogA2 dbCatalogA2 = context.CatalogA2s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogA2.Model = catalogA2.Model;
                        dbCatalogA2.ListPrice = catalogA2.ListPrice;
                        dbCatalogA2.CostMultiplier = catalogA2.CostMultiplier;
                        dbCatalogA2.SellMargin = catalogA2.SellMargin;
                        dbCatalogA2.UnitSize = catalogA2.UnitSize;
                        dbCatalogA2.Description = catalogA2.Description;
                        dbCatalogA2.Voltage = catalogA2.Voltage;

                        context.CatalogA2s.Update(dbCatalogA2);
                        dbCatalog = dbCatalogA2;
                    }
                    else
                    {
                        context.CatalogA2s.Add(catalog as CatalogA2);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogA3)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogA3 catalogA3 = catalog as CatalogA3;
                        CatalogA3 dbCatalogA3 = context.CatalogA3s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogA3.Model = catalogA3.Model;
                        dbCatalogA3.ListPrice = catalogA3.ListPrice;
                        dbCatalogA3.CostMultiplier = catalogA3.CostMultiplier;
                        dbCatalogA3.SellMargin = catalogA3.SellMargin;
                        dbCatalogA3.UnitSize = catalogA3.UnitSize;
                        dbCatalogA3.Description = catalogA3.Description;
                        dbCatalogA3.Voltage = catalogA3.Voltage;

                        context.CatalogA3s.Update(dbCatalogA3);
                        dbCatalog = dbCatalogA3;
                    }
                    else
                    {
                        context.CatalogA3s.Add(catalog as CatalogA3);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogA4)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogA4 catalogA4 = catalog as CatalogA4;
                        CatalogA4 dbCatalogA4 = context.CatalogA4s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogA4.Model = catalogA4.Model;
                        dbCatalogA4.ListPrice = catalogA4.ListPrice;
                        dbCatalogA4.CostMultiplier = catalogA4.CostMultiplier;
                        dbCatalogA4.SellMargin = catalogA4.SellMargin;
                        dbCatalogA4.UnitSize = catalogA4.UnitSize;
                        dbCatalogA4.Description = catalogA4.Description;
                        dbCatalogA4.Voltage = catalogA4.Voltage;

                        context.CatalogA4s.Update(dbCatalogA4);
                        dbCatalog = dbCatalogA4;
                    }
                    else
                    {
                        context.CatalogA4s.Add(catalog as CatalogA4);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogB1)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogB1 catalogB1 = catalog as CatalogB1;
                        CatalogB1 dbCatalogB1 = context.CatalogB1s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogB1.Model = catalogB1.Model;
                        dbCatalogB1.Hp = catalogB1.Hp;
                        dbCatalogB1.Description = catalogB1.Description;
                        dbCatalogB1.Nema = catalogB1.Nema;
                        dbCatalogB1.Bypass = catalogB1.Bypass;
                        dbCatalogB1.CircuitBreakerDisconnect = catalogB1.CircuitBreakerDisconnect;
                        dbCatalogB1.Voltage = catalogB1.Voltage;


                        dbCatalogB1.ListPrice = catalogB1.ListPrice;
                        dbCatalogB1.CostMultiplier = catalogB1.CostMultiplier;
                        dbCatalogB1.SellMargin = catalogB1.SellMargin;

                        context.CatalogB1s.Update(dbCatalogB1);
                        dbCatalog = dbCatalogB1;
                    }
                    else
                    {
                        context.CatalogB1s.Add(catalog as CatalogB1);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogB2)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogB2 catalogB2 = catalog as CatalogB2;
                        CatalogB2 dbCatalogB2 = context.CatalogB2s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogB2.Model = catalogB2.Model;
                        dbCatalogB2.Description = catalogB2.Description;
                        dbCatalogB2.ListPrice = catalogB2.ListPrice;
                        dbCatalogB2.CostMultiplier = catalogB2.CostMultiplier;
                        dbCatalogB2.SellMargin = catalogB2.SellMargin;

                        context.CatalogB2s.Update(dbCatalogB2);
                        dbCatalog = dbCatalogB2;
                    }
                    else
                    {
                        context.CatalogB2s.Add(catalog as CatalogB2);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogB3)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogB3 catalogB3 = catalog as CatalogB3;
                        CatalogB3 dbCatalogB3 = context.CatalogB3s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogB3.Model = catalogB3.Model;
                        dbCatalogB3.ListPrice = catalogB3.ListPrice;
                        dbCatalogB3.CostMultiplier = catalogB3.CostMultiplier;
                        dbCatalogB3.SellMargin = catalogB3.SellMargin;

                        context.CatalogB3s.Update(dbCatalogB3);
                        dbCatalog = dbCatalogB3;
                    }
                    else
                    {
                        context.CatalogB3s.Add(catalog as CatalogB3);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogB4)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogB4 catalogB4 = catalog as CatalogB4;
                        CatalogB4 dbCatalogB4 = context.CatalogB4s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogB4.Model = catalogB4.Model;
                        dbCatalogB4.ListPrice = catalogB4.ListPrice;
                        dbCatalogB4.CostMultiplier = catalogB4.CostMultiplier;
                        dbCatalogB4.SellMargin = catalogB4.SellMargin;

                        context.CatalogB4s.Update(dbCatalogB4);
                        dbCatalog = dbCatalogB4;
                    }
                    else
                    {
                        context.CatalogB4s.Add(catalog as CatalogB4);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogB5)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogB5 catalogB5 = catalog as CatalogB5;
                        CatalogB5 dbCatalogB5 = context.CatalogB5s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogB5.Model = catalogB5.Model;
                        dbCatalogB5.Description = catalogB5.Description;
                        dbCatalogB5.ListPrice = catalogB5.ListPrice;
                        dbCatalogB5.CostMultiplier = catalogB5.CostMultiplier;
                        dbCatalogB5.SellMargin = catalogB5.SellMargin;

                        context.CatalogB5s.Update(dbCatalogB5);
                        dbCatalog = dbCatalogB5;
                    }
                    else
                    {
                        context.CatalogB5s.Add(catalog as CatalogB5);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogC1)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogC1 catalogC1 = catalog as CatalogC1;
                        CatalogC1 dbCatalogC1 = context.CatalogC1s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogC1.Model = catalogC1.Model;
                        dbCatalogC1.ListPrice = catalogC1.ListPrice;
                        dbCatalogC1.CostMultiplier = catalogC1.CostMultiplier;
                        dbCatalogC1.SellMargin = catalogC1.SellMargin;

                        context.CatalogC1s.Update(dbCatalogC1);
                        dbCatalog = dbCatalogC1;
                    }
                    else
                    {
                        context.CatalogC1s.Add(catalog as CatalogC1);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogC2)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogC2 catalogC2 = catalog as CatalogC2;
                        CatalogC2 dbCatalogC2 = context.CatalogC2s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogC2.Model = catalogC2.Model;
                        dbCatalogC2.ListPrice = catalogC2.ListPrice;
                        dbCatalogC2.CostMultiplier = catalogC2.CostMultiplier;
                        dbCatalogC2.SellMargin = catalogC2.SellMargin;

                        context.CatalogC2s.Update(dbCatalogC2);
                        dbCatalog = dbCatalogC2;
                    }
                    else
                    {
                        context.CatalogC2s.Add(catalog as CatalogC2);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogC3)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogC3 catalogC3 = catalog as CatalogC3;
                        CatalogC3 dbCatalogC3 = context.CatalogC3s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogC3.Model = catalogC3.Model;
                        dbCatalogC3.ListPrice = catalogC3.ListPrice;
                        dbCatalogC3.CostMultiplier = catalogC3.CostMultiplier;
                        dbCatalogC3.SellMargin = catalogC3.SellMargin;

                        context.CatalogC3s.Update(dbCatalogC3);
                        dbCatalog = dbCatalogC3;
                    }
                    else
                    {
                        context.CatalogC3s.Add(catalog as CatalogC3);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogC4)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogC4 catalogC4 = catalog as CatalogC4;
                        CatalogC4 dbCatalogC4 = context.CatalogC4s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogC4.Model = catalogC4.Model;
                        dbCatalogC4.ListPrice = catalogC4.ListPrice;
                        dbCatalogC4.CostMultiplier = catalogC4.CostMultiplier;
                        dbCatalogC4.SellMargin = catalogC4.SellMargin;

                        context.CatalogC4s.Update(dbCatalogC4);
                        dbCatalog = dbCatalogC4;
                    }
                    else
                    {
                        context.CatalogC4s.Add(catalog as CatalogC4);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogD1)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogD1 catalogD1 = catalog as CatalogD1;
                        CatalogD1 dbCatalogD1 = context.CatalogD1s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogD1.Model = catalogD1.Model;
                        dbCatalogD1.ListPrice = catalogD1.ListPrice;
                        dbCatalogD1.CostMultiplier = catalogD1.CostMultiplier;
                        dbCatalogD1.SellMargin = catalogD1.SellMargin;

                        context.CatalogD1s.Update(dbCatalogD1);
                        dbCatalog = dbCatalogD1;
                    }
                    else
                    {
                        context.CatalogD1s.Add(catalog as CatalogD1);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogD2)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogD2 catalogD2 = catalog as CatalogD2;
                        CatalogD2 dbCatalogD2 = context.CatalogD2s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogD2.Model = catalogD2.Model;
                        dbCatalogD2.ListPrice = catalogD2.ListPrice;
                        dbCatalogD2.CostMultiplier = catalogD2.CostMultiplier;
                        dbCatalogD2.SellMargin = catalogD2.SellMargin;

                        context.CatalogD2s.Update(dbCatalogD2);
                        dbCatalog = dbCatalogD2;
                    }
                    else
                    {
                        context.CatalogD2s.Add(catalog as CatalogD2);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogE1)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogE1 catalogE1 = catalog as CatalogE1;
                        CatalogE1 dbCatalogE1 = context.CatalogE1s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogE1.Model = catalogE1.Model;
                        dbCatalogE1.ListPrice = catalogE1.ListPrice;
                        dbCatalogE1.CostMultiplier = catalogE1.CostMultiplier;
                        dbCatalogE1.SellMargin = catalogE1.SellMargin;

                        context.CatalogE1s.Update(dbCatalogE1);
                        dbCatalog = dbCatalogE1;
                    }
                    else
                    {
                        context.CatalogE1s.Add(catalog as CatalogE1);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogE2)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogE2 catalogE2 = catalog as CatalogE2;
                        CatalogE2 dbCatalogE2 = context.CatalogE2s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogE2.Model = catalogE2.Model;
                        dbCatalogE2.ListPrice = catalogE2.ListPrice;
                        dbCatalogE2.CostMultiplier = catalogE2.CostMultiplier;
                        dbCatalogE2.SellMargin = catalogE2.SellMargin;

                        context.CatalogE2s.Update(dbCatalogE2);
                        dbCatalog = dbCatalogE2;
                    }
                    else
                    {
                        context.CatalogE2s.Add(catalog as CatalogE2);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogE3)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogE3 catalogE3 = catalog as CatalogE3;
                        CatalogE3 dbCatalogE3 = context.CatalogE3s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogE3.Model = catalogE3.Model;
                        dbCatalogE3.ListPrice = catalogE3.ListPrice;
                        dbCatalogE3.CostMultiplier = catalogE3.CostMultiplier;
                        dbCatalogE3.SellMargin = catalogE3.SellMargin;

                        context.CatalogE3s.Update(dbCatalogE3);
                        dbCatalog = dbCatalogE3;
                    }
                    else
                    {
                        context.CatalogE3s.Add(catalog as CatalogE3);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogE4)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogE4 catalogE4 = catalog as CatalogE4;
                        CatalogE4 dbCatalogE4 = context.CatalogE4s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogE4.Model = catalogE4.Model;
                        dbCatalogE4.ListPrice = catalogE4.ListPrice;
                        dbCatalogE4.CostMultiplier = catalogE4.CostMultiplier;
                        dbCatalogE4.SellMargin = catalogE4.SellMargin;

                        context.CatalogE4s.Update(dbCatalogE4);
                        dbCatalog = dbCatalogE4;
                    }
                    else
                    {
                        context.CatalogE4s.Add(catalog as CatalogE4);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogE5)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogE5 catalogE5 = catalog as CatalogE5;
                        CatalogE5 dbCatalogE5 = context.CatalogE5s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogE5.Model = catalogE5.Model;
                        dbCatalogE5.ListPrice = catalogE5.ListPrice;
                        dbCatalogE5.CostMultiplier = catalogE5.CostMultiplier;
                        dbCatalogE5.SellMargin = catalogE5.SellMargin;

                        context.CatalogE5s.Update(dbCatalogE5);
                        dbCatalog = dbCatalogE5;
                    }
                    else
                    {
                        context.CatalogE5s.Add(catalog as CatalogE5);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogE6)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogE6 catalogE6 = catalog as CatalogE6;
                        CatalogE6 dbCatalogE6 = context.CatalogE6s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogE6.Model = catalogE6.Model;
                        dbCatalogE6.ListPrice = catalogE6.ListPrice;
                        dbCatalogE6.CostMultiplier = catalogE6.CostMultiplier;
                        dbCatalogE6.SellMargin = catalogE6.SellMargin;

                        context.CatalogE6s.Update(dbCatalogE6);
                        dbCatalog = dbCatalogE6;
                    }
                    else
                    {
                        context.CatalogE6s.Add(catalog as CatalogE6);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogE7)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogE7 catalogE7 = catalog as CatalogE7;
                        CatalogE7 dbCatalogE7 = context.CatalogE7s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogE7.Model = catalogE7.Model;
                        dbCatalogE7.ListPrice = catalogE7.ListPrice;
                        dbCatalogE7.CostMultiplier = catalogE7.CostMultiplier;
                        dbCatalogE7.SellMargin = catalogE7.SellMargin;

                        context.CatalogE7s.Update(dbCatalogE7);
                        dbCatalog = dbCatalogE7;
                    }
                    else
                    {
                        context.CatalogE7s.Add(catalog as CatalogE7);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogF1)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogF1 catalogF1 = catalog as CatalogF1;
                        CatalogF1 dbCatalogF1 = context.CatalogF1s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogF1.Model = catalogF1.Model;
                        dbCatalogF1.ListPrice = catalogF1.ListPrice;
                        dbCatalogF1.CostMultiplier = catalogF1.CostMultiplier;
                        dbCatalogF1.SellMargin = catalogF1.SellMargin;

                        context.CatalogF1s.Update(dbCatalogF1);
                        dbCatalog = dbCatalogF1;
                    }
                    else
                    {
                        context.CatalogF1s.Add(catalog as CatalogF1);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogG1)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogG1 catalogG1 = catalog as CatalogG1;
                        CatalogG1 dbCatalogG1 = context.CatalogG1s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogG1.Model = catalogG1.Model;
                        dbCatalogG1.ListPrice = catalogG1.ListPrice;
                        dbCatalogG1.CostMultiplier = catalogG1.CostMultiplier;
                        dbCatalogG1.SellMargin = catalogG1.SellMargin;

                        context.CatalogG1s.Update(dbCatalogG1);
                        dbCatalog = dbCatalogG1;
                    }
                    else
                    {
                        context.CatalogG1s.Add(catalog as CatalogG1);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogG2)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogG2 catalogG2 = catalog as CatalogG2;
                        CatalogG2 dbCatalogG2 = context.CatalogG2s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogG2.Model = catalogG2.Model;
                        dbCatalogG2.ListPrice = catalogG2.ListPrice;
                        dbCatalogG2.CostMultiplier = catalogG2.CostMultiplier;
                        dbCatalogG2.SellMargin = catalogG2.SellMargin;

                        context.CatalogG2s.Update(dbCatalogG2);
                        dbCatalog = dbCatalogG2;
                    }
                    else
                    {
                        context.CatalogG2s.Add(catalog as CatalogG2);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogG3)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogG3 catalogG3 = catalog as CatalogG3;
                        CatalogG3 dbCatalogG3 = context.CatalogG3s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogG3.Model = catalogG3.Model;
                        dbCatalogG3.ListPrice = catalogG3.ListPrice;
                        dbCatalogG3.CostMultiplier = catalogG3.CostMultiplier;
                        dbCatalogG3.SellMargin = catalogG3.SellMargin;

                        context.CatalogG3s.Update(dbCatalogG3);
                        dbCatalog = dbCatalogG3;
                    }
                    else
                    {
                        context.CatalogG3s.Add(catalog as CatalogG3);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogG4)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogG4 catalogG4 = catalog as CatalogG4;
                        CatalogG4 dbCatalogG4 = context.CatalogG4s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogG4.Model = catalogG4.Model;
                        dbCatalogG4.ListPrice = catalogG4.ListPrice;
                        dbCatalogG4.CostMultiplier = catalogG4.CostMultiplier;
                        dbCatalogG4.SellMargin = catalogG4.SellMargin;

                        context.CatalogG4s.Update(dbCatalogG4);
                        dbCatalog = dbCatalogG4;
                    }
                    else
                    {
                        context.CatalogG4s.Add(catalog as CatalogG4);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogG5)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogG5 catalogG5 = catalog as CatalogG5;
                        CatalogG5 dbCatalogG5 = context.CatalogG5s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogG5.Model = catalogG5.Model;
                        dbCatalogG5.ListPrice = catalogG5.ListPrice;
                        dbCatalogG5.CostMultiplier = catalogG5.CostMultiplier;
                        dbCatalogG5.SellMargin = catalogG5.SellMargin;

                        context.CatalogG5s.Update(dbCatalogG5);
                        dbCatalog = dbCatalogG5;
                    }
                    else
                    {
                        context.CatalogG5s.Add(catalog as CatalogG5);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogG6)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogG6 catalogG6 = catalog as CatalogG6;
                        CatalogG6 dbCatalogG6 = context.CatalogG6s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogG6.Model = catalogG6.Model;
                        dbCatalogG6.ListPrice = catalogG6.ListPrice;
                        dbCatalogG6.CostMultiplier = catalogG6.CostMultiplier;
                        dbCatalogG6.SellMargin = catalogG6.SellMargin;

                        context.CatalogG6s.Update(dbCatalogG6);
                        dbCatalog = dbCatalogG6;
                    }
                    else
                    {
                        context.CatalogG6s.Add(catalog as CatalogG6);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogH1)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogH1 catalogH1 = catalog as CatalogH1;
                        CatalogH1 dbCatalogH1 = context.CatalogH1s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogH1.Model = catalogH1.Model;
                        dbCatalogH1.ListPrice = catalogH1.ListPrice;
                        dbCatalogH1.CostMultiplier = catalogH1.CostMultiplier;
                        dbCatalogH1.SellMargin = catalogH1.SellMargin;

                        context.CatalogH1s.Update(dbCatalogH1);
                        dbCatalog = dbCatalogH1;
                    }
                    else
                    {
                        context.CatalogH1s.Add(catalog as CatalogH1);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogH2)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogH2 catalogH2 = catalog as CatalogH2;
                        CatalogH2 dbCatalogH2 = context.CatalogH2s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogH2.Model = catalogH2.Model;
                        dbCatalogH2.ListPrice = catalogH2.ListPrice;
                        dbCatalogH2.CostMultiplier = catalogH2.CostMultiplier;
                        dbCatalogH2.SellMargin = catalogH2.SellMargin;

                        context.CatalogH2s.Update(dbCatalogH2);
                        dbCatalog = dbCatalogH2;
                    }
                    else
                    {
                        context.CatalogH2s.Add(catalog as CatalogH2);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogH3)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogH3 catalogH3 = catalog as CatalogH3;
                        CatalogH3 dbCatalogH3 = context.CatalogH3s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogH3.Model = catalogH3.Model;
                        dbCatalogH3.ListPrice = catalogH3.ListPrice;
                        dbCatalogH3.CostMultiplier = catalogH3.CostMultiplier;
                        dbCatalogH3.SellMargin = catalogH3.SellMargin;

                        context.CatalogH3s.Update(dbCatalogH3);
                        dbCatalog = dbCatalogH3;
                    }
                    else
                    {
                        context.CatalogH3s.Add(catalog as CatalogH3);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogH4)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogH4 catalogH4 = catalog as CatalogH4;
                        CatalogH4 dbCatalogH4 = context.CatalogH4s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogH4.Model = catalogH4.Model;
                        dbCatalogH4.ListPrice = catalogH4.ListPrice;
                        dbCatalogH4.CostMultiplier = catalogH4.CostMultiplier;
                        dbCatalogH4.SellMargin = catalogH4.SellMargin;

                        context.CatalogH4s.Update(dbCatalogH4);
                        dbCatalog = dbCatalogH4;
                    }
                    else
                    {
                        context.CatalogH4s.Add(catalog as CatalogH4);
                        dbCatalog = catalog;
                    }
                }
                else if (catalog is CatalogH5)
                {
                    if (catalog.Id != 0)
                    {
                        CatalogH5 catalogH5 = catalog as CatalogH5;
                        CatalogH5 dbCatalogH5 = context.CatalogH5s.FirstOrDefault(x => x.Id == catalog.Id);

                        dbCatalogH5.Model = catalogH5.Model;
                        dbCatalogH5.ListPrice = catalogH5.ListPrice;
                        dbCatalogH5.CostMultiplier = catalogH5.CostMultiplier;
                        dbCatalogH5.SellMargin = catalogH5.SellMargin;

                        context.CatalogH5s.Update(dbCatalogH5);
                        dbCatalog = dbCatalogH5;
                    }
                    else
                    {
                        context.CatalogH5s.Add(catalog as CatalogH5);
                        dbCatalog = catalog;
                    }
                }
                context.SaveChanges();

                return dbCatalog;
            }
        }

    }
}
