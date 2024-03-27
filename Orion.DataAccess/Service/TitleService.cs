using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Orion.DataAccess.DataBase;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AERCO.Item;
using Orion.Domain.Baldor.Item;
using Orion.Domain.Condair.Item;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Domain.EntityItemGeneralProduct;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Domain.EnviroTec.Item;
using Orion.Domain.LYNC.Item;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.Nortek.Item;
using Orion.Domain.NYLE.Item;
using Orion.Domain.PACE.Item;
using Orion.Domain.PlasmaAir.Item;
using Orion.Domain.Polaris.Item;
using Orion.Domain.PVI.Item;
using Orion.Domain.Robur.Item;
using Orion.Domain.UMAS.Item;
using Orion.Domain.Valent.Item;
using Orion.Domain.Whalen.Item;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Orion.DataAccess.Service
{
    public class TitleService
    {
        // [new]
        public IList<Title> GetTitlesFromItem(IItem item)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                List<Title> titles = new List<Title>();

                if (item is ItemA1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA1Id == item.Id).ToList();
                else if (item is ItemA2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA2Id == item.Id).ToList();
                else if (item is ItemA3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA3Id == item.Id).ToList();
                else if (item is ItemA4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemA4Id == item.Id).ToList();

                else if (item is ItemB1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB1Id == item.Id).ToList();
                else if (item is ItemB2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB2Id == item.Id).ToList();
                else if (item is ItemB3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB3Id == item.Id).ToList();
                else if (item is ItemB4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB4Id == item.Id).ToList();
                else if (item is ItemB5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemB5Id == item.Id).ToList();

                else if (item is ItemC1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC1Id == item.Id).ToList();
                else if (item is ItemC2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC2Id == item.Id).ToList();
                else if (item is ItemC3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC3Id == item.Id).ToList();
                else if (item is ItemC4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC4Id == item.Id).ToList();
                else if (item is ItemC5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC5Id == item.Id).ToList();
                else if (item is ItemC6)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC6Id == item.Id).ToList();
                else if (item is ItemC7)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemC7Id == item.Id).ToList();

                else if (item is ItemD1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemD1Id == item.Id).ToList();
                else if (item is ItemD2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemD2Id == item.Id).ToList();

                else if (item is ItemE1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE1Id == item.Id).ToList();
                else if (item is ItemE2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE2Id == item.Id).ToList();
                else if (item is ItemE3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE3Id == item.Id).ToList();
                else if (item is ItemE4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE4Id == item.Id).ToList();
                else if (item is ItemE5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE5Id == item.Id).ToList();
                else if (item is ItemE6)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE6Id == item.Id).ToList();
                else if (item is ItemE7)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemE7Id == item.Id).ToList();

                else if (item is ItemF1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemF1Id == item.Id).ToList();

                else if (item is ItemG1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG1Id == item.Id).ToList();
                else if (item is ItemG2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG2Id == item.Id).ToList();
                else if (item is ItemG3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG3Id == item.Id).ToList();
                else if (item is ItemG4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG4Id == item.Id).ToList();
                else if (item is ItemG5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG5Id == item.Id).ToList();
                else if (item is ItemG6)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemG6Id == item.Id).ToList();

                else if (item is ItemH1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH1Id == item.Id).ToList();
                else if (item is ItemH2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH2Id == item.Id).ToList();
                else if (item is ItemH3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH3Id == item.Id).ToList();
                else if (item is ItemH4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH4Id == item.Id).ToList();
                else if (item is ItemH5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemH5Id == item.Id).ToList();

                else if (item is ItemI1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemI1Id == item.Id).ToList();
                else if (item is ItemI2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemI2Id == item.Id).ToList();

                else if (item is ItemJ1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemJ1Id == item.Id).ToList();

                else if (item is ItemK1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemK1Id == item.Id).ToList();
                else if (item is ItemK2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemK2Id == item.Id).ToList();
                else if (item is ItemK3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemK3Id == item.Id).ToList();


                else if (item is ItemL1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemL1Id == item.Id).ToList();

                else if (item is ItemM1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemM1Id == item.Id).ToList();
                else if (item is ItemN1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemN1Id == item.Id).ToList();
                else if (item is ItemO1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemO1Id == item.Id).ToList();
                else if (item is ItemO2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemO2Id == item.Id).ToList();
                else if (item is ItemP1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemP1Id == item.Id).ToList();
                else if (item is ItemQ1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemQ1Id == item.Id).ToList();
                else if (item is ItemQ2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemQ2Id == item.Id).ToList();
                else if (item is ItemQ3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemQ3Id == item.Id).ToList();
                else if (item is ItemQ4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemQ4Id == item.Id).ToList();
                else if (item is ItemR1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemR1Id == item.Id).ToList();
                else if (item is ItemR2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemR2Id == item.Id).ToList();
                else if (item is ItemR3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemR3Id == item.Id).ToList();
                else if (item is ItemR4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemR4Id == item.Id).ToList();
                else if (item is ItemS1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemS1Id == item.Id).ToList();
                else if (item is ItemT1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemT1Id == item.Id).ToList();
                else if (item is ItemT2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemT2Id == item.Id).ToList();
                else if (item is ItemT3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemT3Id == item.Id).ToList();
                else if (item is ItemU1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemU1Id == item.Id).ToList();
                else if (item is ItemV1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemV1Id == item.Id).ToList();
                else if (item is ItemW1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemW1Id == item.Id).ToList();
                else if (item is ItemX1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemX1Id == item.Id).ToList();
                else if (item is ItemX2)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemX2Id == item.Id).ToList();
                else if (item is ItemX3)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemX3Id == item.Id).ToList();
                else if (item is ItemX4)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemX4Id == item.Id).ToList();
                else if (item is ItemX5)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemX5Id == item.Id).ToList();
                else if (item is ItemY1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemY1Id == item.Id).ToList();
                else if (item is ItemZ1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemZ1Id == item.Id).ToList();
                else if (item is ItemAA1)
                    titles = context.Titles.Include(x => x.Specs).Where(x => x.ItemAA1Id == item.Id).ToList();
                return titles;
            }
        }

        public IList<Title> UpdataTitlesFromDataSheet(DataSheet dataSheet, ObservableCollection<Title> titles)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                DataSheet dbDataSheet = context.DataSheets.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == dataSheet.Id);

                foreach (Title title in titles)
                {
                    if (dbDataSheet.Titles.Any(x => x.Id == title.Id && !x.Saved))
                    {
                        Title dbTitle = dbDataSheet.Titles.FirstOrDefault(x => x.Id == title.Id && !x.Saved);
                        dbTitle.Name = title.Name;
                        dbTitle.Highlighted = title.Highlighted;

                        foreach (Spec spec in title.Specs)
                        {
                            if (dbTitle.Specs.Any(x => x.Id == spec.Id && !x.Saved))
                            {
                                Spec dbSpec = dbTitle.Specs.FirstOrDefault(x => x.Id == spec.Id);
                                dbSpec.Name = spec.Name;
                                dbSpec.Price = spec.Price;
                                dbSpec.Saved = true;
                                dbSpec.Highlighted = spec.Highlighted;
                            }
                            else
                            {
                                spec.Saved = true;
                                dbTitle.Specs.Add(spec);
                            }
                        }
                    }
                    else if (title.Id == 0)
                    {
                        title.Saved = true;
                        dbDataSheet.Titles.Add(title);
                    }
                }

                foreach (Title title in dbDataSheet.Titles.Where(x => !x.Saved))
                {
                    if (!titles.ToList().Exists(sf => sf.Id == title.Id))
                    {
                        context.Remove(title);
                        context.Entry(title).State = EntityState.Deleted;
                    }
                    else
                    {
                        foreach (Spec spec in title.Specs)
                        {
                            if (!titles.SelectMany(x => x.Specs).ToList().Exists(sf => sf.Id == spec.Id))
                            {
                                context.Remove(spec);
                                context.Entry(spec).State = EntityState.Deleted;
                            }
                        }
                    }
                }

                context.Update(dbDataSheet);

                context.SaveChanges();

                return GetTitlesFromDataSheet(dbDataSheet);
            }
        }

        private IList<Title> GetTitlesFromDataSheet(DataSheet dbDataSheet)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Titles.Include(x => x.Specs).Where(x => x.DataSheetId == dbDataSheet.Id).ToList();
            }
        }
        // [new]
        public IList<Title> UpdateTitlesFromItem(IItem item, IList<Title> titles)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                IItem dbItem = null;

                if (item is ItemA1)
                    dbItem = context.ItemA1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemA2)
                    dbItem = context.ItemA2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemA3)
                    dbItem = context.ItemA3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemA4)
                    dbItem = context.ItemA4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemB1)
                    dbItem = context.ItemB1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemB2)
                    dbItem = context.ItemB2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemB3)
                    dbItem = context.ItemB3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemB4)
                    dbItem = context.ItemB4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemB5)
                    dbItem = context.ItemB5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemC1)
                    dbItem = context.ItemC1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC2)
                    dbItem = context.ItemC2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC3)
                    dbItem = context.ItemC3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC4)
                    dbItem = context.ItemC4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC5)
                    dbItem = context.ItemC5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC6)
                    dbItem = context.ItemC6s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemC7)
                    dbItem = context.ItemC7s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemD1)
                    dbItem = context.ItemD1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemD2)
                    dbItem = context.ItemD2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemE1)
                    dbItem = context.ItemE1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE2)
                    dbItem = context.ItemE2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE3)
                    dbItem = context.ItemE3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE4)
                    dbItem = context.ItemE4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE5)
                    dbItem = context.ItemE5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE6)
                    dbItem = context.ItemE6s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemE7)
                    dbItem = context.ItemE7s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemF1)
                    dbItem = context.ItemF1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemG1)
                    dbItem = context.ItemG1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG2)
                    dbItem = context.ItemG2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG3)
                    dbItem = context.ItemG3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG4)
                    dbItem = context.ItemG4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG5)
                    dbItem = context.ItemG5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemG6)
                    dbItem = context.ItemG6s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemH1)
                    dbItem = context.ItemH1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemH2)
                    dbItem = context.ItemH2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemH3)
                    dbItem = context.ItemH3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemH4)
                    dbItem = context.ItemH4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemH5)
                    dbItem = context.ItemH5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemI1)
                    dbItem = context.ItemI1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemI2)
                    dbItem = context.ItemI2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemJ1)
                    dbItem = context.ItemJ1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemK1)
                    dbItem = context.ItemK1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemK2)
                    dbItem = context.ItemK2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemK3)
                    dbItem = context.ItemK3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemL1)
                    dbItem = context.ItemL1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemM1)
                    dbItem = context.ItemM1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                else if (item is ItemN1)
                    dbItem = context.ItemN1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemO1)
                    dbItem = context.ItemO1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemO2)
                    dbItem = context.ItemO2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemP1)
                    dbItem = context.ItemP1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemQ1)
                    dbItem = context.ItemQ1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemQ2)
                    dbItem = context.ItemQ2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemQ3)
                    dbItem = context.ItemQ3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemQ4)
                    dbItem = context.ItemQ4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemR1)
                    dbItem = context.ItemR1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemR2)
                    dbItem = context.ItemR2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemR3)
                    dbItem = context.ItemR3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemR4)
                    dbItem = context.ItemR4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemS1)
                    dbItem = context.ItemS1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemT1)
                    dbItem = context.ItemT1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemT2)
                    dbItem = context.ItemT2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemT3)
                    dbItem = context.ItemT3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemU1)
                    dbItem = context.ItemU1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemV1)
                    dbItem = context.ItemV1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemW1)
                    dbItem = context.ItemW1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemX1)
                    dbItem = context.ItemX1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemX2)
                    dbItem = context.ItemX2s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemX3)
                    dbItem = context.ItemX3s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemX4)
                    dbItem = context.ItemX4s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemX5)
                    dbItem = context.ItemX5s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemY1)
                    dbItem = context.ItemY1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemZ1)
                    dbItem = context.ItemZ1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);
                else if (item is ItemAA1)
                    dbItem = context.ItemAA1s.Include(x => x.Titles).ThenInclude(x => x.Specs).FirstOrDefault(x => x.Id == item.Id);

                foreach (Title title in titles)
                {
                    if (dbItem.Titles.Any(x => x.Id == title.Id && !x.Saved))
                    {
                        Title dbTitle = dbItem.Titles.FirstOrDefault(x => x.Id == title.Id && !x.Saved);
                        dbTitle.Name = title.Name;

                        foreach (Spec spec in title.Specs)
                        {
                            if (dbTitle.Specs.Any(x => x.Id == spec.Id && !x.Saved))
                            {
                                Spec dbSpec = dbTitle.Specs.FirstOrDefault(x => x.Id == spec.Id);
                                dbSpec.Name = spec.Name;
                                dbSpec.Price = spec.Price;
                                dbSpec.Saved = true;
                            }
                            else
                            {
                                spec.Saved = true;
                                dbTitle.Specs.Add(spec);
                            }
                        }
                    }
                    else if (title.Id == 0)
                    {
                        title.Saved = true;
                        dbItem.Titles.Add(title);
                    }
                }

                foreach (Title title in dbItem.Titles.Where(x => !x.Saved))
                {
                    if (!titles.ToList().Exists(sf => sf.Id == title.Id))
                    {
                        context.Remove(title);
                        context.Entry(title).State = EntityState.Deleted;
                    }
                    else
                    {
                        foreach (Spec spec in title.Specs)
                        {
                            if (!titles.SelectMany(x => x.Specs).ToList().Exists(sf => sf.Id == spec.Id))
                            {
                                context.Remove(spec);
                                context.Entry(spec).State = EntityState.Deleted;
                            }
                        }
                    }
                }

                context.Update(dbItem);

                context.SaveChanges();

                return GetTitlesFromItem(dbItem);
            }
        }
    }
}
