﻿using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AERCO.Item;
using Orion.Domain.AERCO.Related;
using Orion.Domain.Baldor.Item;
using Orion.Domain.Condair.Item;
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
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static Orion.Helper.Misc.GV;

namespace Orion.Domain.Entity
{
    public class Quote : ValidatableBindableBase, IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }

        private int _projectId;
        public int ProjectId
        {
            get => _projectId;
            set => SetProperty(ref _projectId, value);
        }

        private Project _project;
        public Project Project
        {
            get => _project;
            set => SetProperty(ref _project, value);
        }



        #region Quantech Items
        private IList<ItemA1> _itemA1s;
        public IList<ItemA1> ItemA1s
        {
            get => _itemA1s;
            set => SetProperty(ref _itemA1s, value);
        }

        private IList<ItemA2> _itemA2s;
        public IList<ItemA2> ItemA2s
        {
            get => _itemA2s;
            set => SetProperty(ref _itemA2s, value);
        }

        private IList<ItemA3> _itemA3s;
        public IList<ItemA3> ItemA3s
        {
            get => _itemA3s;
            set => SetProperty(ref _itemA3s, value);
        }
        private IList<ItemA4> _itemA4s;
        public IList<ItemA4> ItemA4s
        {
            get => _itemA4s;
            set => SetProperty(ref _itemA4s, value);
        }
        #endregion



        #region ABB Items

        private IList<ItemB1> _itemB1s;
        public IList<ItemB1> ItemB1s
        {
            get => _itemB1s;
            set => SetProperty(ref _itemB1s, value);
        }

        private IList<ItemB2> _itemB2s;
        public IList<ItemB2> ItemB2s
        {
            get => _itemB2s;
            set => SetProperty(ref _itemB2s, value);
        }

        private IList<ItemB3> _itemB3s;
        public IList<ItemB3> ItemB3s
        {
            get => _itemB3s;
            set => SetProperty(ref _itemB3s, value);
        }

        private IList<ItemB4> _itemB4s;
        public IList<ItemB4> ItemB4s
        {
            get => _itemB4s;
            set => SetProperty(ref _itemB4s, value);
        }

        private IList<ItemB5> _itemB5s;
        public IList<ItemB5> ItemB5s
        {
            get => _itemB5s;
            set => SetProperty(ref _itemB5s, value);
        }
        #endregion



        #region American Wheatley Items
        private IList<ItemC1> _itemC1s;
        public IList<ItemC1> ItemC1s
        {
            get => _itemC1s;
            set => SetProperty(ref _itemC1s, value);
        }

        private IList<ItemC2> _itemC2s;
        public IList<ItemC2> ItemC2s
        {
            get => _itemC2s;
            set => SetProperty(ref _itemC2s, value);
        }

        private IList<ItemC3> _itemC3s;
        public IList<ItemC3> ItemC3s
        {
            get => _itemC3s;
            set => SetProperty(ref _itemC3s, value);
        }
        private IList<ItemC4> _itemC4s;
        public IList<ItemC4> ItemC4s
        {
            get => _itemC4s;
            set => SetProperty(ref _itemC4s, value);
        }

        private IList<ItemC5> _itemC5s;
        public IList<ItemC5> ItemC5s
        {
            get => _itemC5s;
            set => SetProperty(ref _itemC5s, value);
        }

        private IList<ItemC6> _itemC6s;
        public IList<ItemC6> ItemC6s
        {
            get => _itemC6s;
            set => SetProperty(ref _itemC6s, value);
        }

        private IList<ItemC7> _itemC7s;
        public IList<ItemC7> ItemC7s
        {
            get => _itemC7s;
            set => SetProperty(ref _itemC7s, value);
        }
        #endregion



        #region Puroflux Items
        private IList<ItemD1> _itemD1s;
        public IList<ItemD1> ItemD1s
        {
            get => _itemD1s;
            set => SetProperty(ref _itemD1s, value);
        }

        private IList<ItemD2> _itemD2s;
        public IList<ItemD2> ItemD2s
        {
            get => _itemD2s;
            set => SetProperty(ref _itemD2s, value);
        }
        #endregion



        #region Groundfos Items

        private IList<ItemE1> _itemE1s;
        public IList<ItemE1> ItemE1s
        {
            get => _itemE1s;
            set => SetProperty(ref _itemE1s, value);
        }

        private IList<ItemE2> _itemE2s;
        public IList<ItemE2> ItemE2s
        {
            get => _itemE2s;
            set => SetProperty(ref _itemE2s, value);
        }

        private IList<ItemE3> _itemE3s;
        public IList<ItemE3> ItemE3s
        {
            get => _itemE3s;
            set => SetProperty(ref _itemE3s, value);
        }

        private IList<ItemE4> _itemE4s;
        public IList<ItemE4> ItemE4s
        {
            get => _itemE4s;
            set => SetProperty(ref _itemE4s, value);
        }

        private IList<ItemE5> _itemE5s;
        public IList<ItemE5> ItemE5s
        {
            get => _itemE5s;
            set => SetProperty(ref _itemE5s, value);
        }

        private IList<ItemE6> _itemE6s;
        public IList<ItemE6> ItemE6s
        {
            get => _itemE6s;
            set => SetProperty(ref _itemE6s, value);
        }

        private IList<ItemE7> _itemE7s;
        public IList<ItemE7> ItemE7s
        {
            get => _itemE7s;
            set => SetProperty(ref _itemE7s, value);
        }
        #endregion



        #region UV Resources Items
        private IList<ItemF1> _itemF1s;
        public IList<ItemF1> ItemF1s
        {
            get => _itemF1s;
            set => SetProperty(ref _itemF1s, value);
        }
        #endregion



        #region BAC Cooling Towers Items

        private IList<ItemG1> _itemG1s;
        public IList<ItemG1> ItemG1s
        {
            get => _itemG1s;
            set => SetProperty(ref _itemG1s, value);
        }

        private IList<ItemG2> _itemG2s;
        public IList<ItemG2> ItemG2s
        {
            get => _itemG2s;
            set => SetProperty(ref _itemG2s, value);
        }

        private IList<ItemG3> _itemG3s;
        public IList<ItemG3> ItemG3s
        {
            get => _itemG3s;
            set => SetProperty(ref _itemG3s, value);
        }

        private IList<ItemG4> _itemG4s;
        public IList<ItemG4> ItemG4s
        {
            get => _itemG4s;
            set => SetProperty(ref _itemG4s, value);
        }

        private IList<ItemG5> _itemG5s;
        public IList<ItemG5> ItemG5s
        {
            get => _itemG5s;
            set => SetProperty(ref _itemG5s, value);
        }

        private IList<ItemG6> _itemG6s;
        public IList<ItemG6> ItemG6s
        {
            get => _itemG6s;
            set => SetProperty(ref _itemG6s, value);
        }
        #endregion



        #region BAC Closed Circuits Items

        private IList<ItemH1> _itemH1s;
        public IList<ItemH1> ItemH1s
        {
            get => _itemH1s;
            set => SetProperty(ref _itemH1s, value);
        }

        private IList<ItemH2> _itemH2s;
        public IList<ItemH2> ItemH2s
        {
            get => _itemH2s;
            set => SetProperty(ref _itemH2s, value);
        }

        private IList<ItemH3> _itemH3s;
        public IList<ItemH3> ItemH3s
        {
            get => _itemH3s;
            set => SetProperty(ref _itemH3s, value);
        }

        private IList<ItemH4> _itemH4s;
        public IList<ItemH4> ItemH4s
        {
            get => _itemH4s;
            set => SetProperty(ref _itemH4s, value);
        }

        private IList<ItemH5> _itemH5s;
        public IList<ItemH5> ItemH5s
        {
            get => _itemH5s;
            set => SetProperty(ref _itemH5s, value);
        }
        #endregion



        #region Marvair Items
        private IList<ItemI1> _itemI1s;
        public IList<ItemI1> ItemI1s
        {
            get => _itemI1s;
            set => SetProperty(ref _itemI1s, value);
        }

        private IList<ItemI2> _itemI2s;
        public IList<ItemI2> ItemI2s
        {
            get => _itemI2s;
            set => SetProperty(ref _itemI2s, value);
        }
        #endregion



        #region PACE AHU Items       
        private IList<ItemJ1> _itemJ1s;
        public IList<ItemJ1> ItemJ1s
        {
            get => _itemJ1s;
            set => SetProperty(ref _itemJ1s, value);
        }
        #endregion



        #region Multiaqua
        private IList<ItemK1> _itemK1s;
        public IList<ItemK1> ItemK1s
        {
            get => _itemK1s;
            set => SetProperty(ref _itemK1s, value);
        }

        private IList<ItemK2> _itemK2s;
        public IList<ItemK2> ItemK2s
        {
            get => _itemK2s;
            set => SetProperty(ref _itemK2s, value);
        }

        private IList<ItemK3> _itemK3s;
        public IList<ItemK3> ItemK3s
        {
            get => _itemK3s;
            set => SetProperty(ref _itemK3s, value);
        }
        #endregion



        #region General Product
        private IList<ItemL1> _itemL1s;
        public IList<ItemL1> ItemL1s
        {
            get => _itemL1s;
            set => SetProperty(ref _itemL1s, value);
        }



        #endregion



        #region UMAS AHU Items       
        private IList<ItemM1> _itemM1s;
        public IList<ItemM1> ItemM1s
        {
            get => _itemM1s;
            set => SetProperty(ref _itemM1s, value);
        }
        #endregion



        #region ABOVE AIR Items       
        private IList<ItemN1> _itemN1s;
        public IList<ItemN1> ItemN1s
        {
            get => _itemN1s;
            set => SetProperty(ref _itemN1s, value);
        }
        #endregion



        #region AERCO Items

        private IList<ItemO1> _itemO1s;
        public IList<ItemO1> ItemO1s
        {
            get => _itemO1s;
            set => SetProperty(ref _itemO1s, value);
        }

        private IList<ItemO2> _itemO2s;
        public IList<ItemO2> ItemO2s
        {
            get => _itemO2s;
            set => SetProperty(ref _itemO2s, value);
        }
        #endregion



        #region Baldor Items

        private IList<ItemP1> _itemP1s;
        public IList<ItemP1> ItemP1s
        {
            get => _itemP1s;
            set => SetProperty(ref _itemP1s, value);
        }
        #endregion



        #region Coindair Items

        private IList<ItemQ1> _itemQ1s;
        public IList<ItemQ1> ItemQ1s
        {
            get => _itemQ1s;
            set => SetProperty(ref _itemQ1s, value);
        }

        private IList<ItemQ2> _itemQ2s;
        public IList<ItemQ2> ItemQ2s
        {
            get => _itemQ2s;
            set => SetProperty(ref _itemQ2s, value);
        }

        private IList<ItemQ3> _itemQ3s;
        public IList<ItemQ3> ItemQ3s
        {
            get => _itemQ3s;
            set => SetProperty(ref _itemQ3s, value);
        }

        private IList<ItemQ4> _itemQ4s;
        public IList<ItemQ4> ItemQ4s
        {
            get => _itemQ4s;
            set => SetProperty(ref _itemQ4s, value);
        }
        #endregion



        #region Enviro-Tec Items

        private IList<ItemR1> _itemR1s;
        public IList<ItemR1> ItemR1s
        {
            get => _itemR1s;
            set => SetProperty(ref _itemR1s, value);
        }

        private IList<ItemR2> _itemR2s;
        public IList<ItemR2> ItemR2s
        {
            get => _itemR2s;
            set => SetProperty(ref _itemR2s, value);
        }

        private IList<ItemR3> _itemR3s;
        public IList<ItemR3> ItemR3s
        {
            get => _itemR3s;
            set => SetProperty(ref _itemR3s, value);
        }

        private IList<ItemR4> _itemR4s;
        public IList<ItemR4> ItemR4s
        {
            get => _itemR4s;
            set => SetProperty(ref _itemR4s, value);
        }
        #endregion



        #region LYNC Items

        private IList<ItemS1> _itemS1s;
        public IList<ItemS1> ItemS1s
        {
            get => _itemS1s;
            set => SetProperty(ref _itemS1s, value);
        }
        #endregion



        #region Nortek Items

        private IList<ItemT1> _itemT1s;
        public IList<ItemT1> ItemT1s
        {
            get => _itemT1s;
            set => SetProperty(ref _itemT1s, value);
        }

        private IList<ItemT2> _itemT2s;
        public IList<ItemT2> ItemT2s
        {
            get => _itemT2s;
            set => SetProperty(ref _itemT2s, value);
        }

        private IList<ItemT3> _itemT3s;
        public IList<ItemT3> ItemT3s
        {
            get => _itemT3s;
            set => SetProperty(ref _itemT3s, value);
        }
        #endregion



        #region NYLE Items

        private IList<ItemU1> _itemU1s;
        public IList<ItemU1> ItemU1s
        {
            get => _itemU1s;
            set => SetProperty(ref _itemU1s, value);
        }
        #endregion



        #region Plasma Air Items

        private IList<ItemV1> _itemV1s;
        public IList<ItemV1> ItemV1s
        {
            get => _itemV1s;
            set => SetProperty(ref _itemV1s, value);
        }

        #endregion



        #region Polaris Items

        private IList<ItemW1> _itemW1s;
        public IList<ItemW1> ItemW1s
        {
            get => _itemW1s;
            set => SetProperty(ref _itemW1s, value);
        }
        #endregion



        #region PVI Items

        private IList<ItemX1> _itemX1s;
        public IList<ItemX1> ItemX1s
        {
            get => _itemX1s;
            set => SetProperty(ref _itemX1s, value);
        }

        private IList<ItemX2> _itemX2s;
        public IList<ItemX2> ItemX2s
        {
            get => _itemX2s;
            set => SetProperty(ref _itemX2s, value);
        }

        private IList<ItemX3> _itemX3s;
        public IList<ItemX3> ItemX3s
        {
            get => _itemX3s;
            set => SetProperty(ref _itemX3s, value);
        }

        private IList<ItemX4> _itemX4s;
        public IList<ItemX4> ItemX4s
        {
            get => _itemX4s;
            set => SetProperty(ref _itemX4s, value);
        }

        private IList<ItemX5> _itemX5s;
        public IList<ItemX5> ItemX5s
        {
            get => _itemX5s;
            set => SetProperty(ref _itemX5s, value);
        }
        #endregion



        #region Robur Items

        private IList<ItemY1> _itemY1s;
        public IList<ItemY1> ItemY1s
        {
            get => _itemY1s;
            set => SetProperty(ref _itemY1s, value);
        }
        #endregion



        #region Valent Items

        private IList<ItemZ1> _itemZ1s;
        public IList<ItemZ1> ItemZ1s
        {
            get => _itemZ1s;
            set => SetProperty(ref _itemZ1s, value);
        }
        #endregion



        #region Whalen Items

        private IList<ItemAA1> _itemAA1s;
        public IList<ItemAA1> ItemAA1s
        {
            get => _itemAA1s;
            set => SetProperty(ref _itemAA1s, value);
        }
        #endregion


        private bool _isSelected;
        [NotMapped]
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

        private bool _canCreateReports;
        [NotMapped]
        public bool CanCreateReports
        {
            get => _canCreateReports;
            set => SetProperty(ref _canCreateReports, value);
        }


        //private IList<IItem> _items;
        //[NotMapped]
        //public IList<IItem> Items
        //{
        //    get => _items;
        //    set => SetProperty(ref _items, value);
        //}

        private IList<QuoteCompanies> _quoteCompanies;
        public IList<QuoteCompanies> QuoteCompanies
        {
            get => _quoteCompanies;
            set => SetProperty(ref _quoteCompanies, value);
        }

        [NotMapped]
        public IList<IItem> Items
        {
            get
            {
                List<IItem> items = new List<IItem>();

                items.AddRange(ItemA1s);
                items.AddRange(ItemA2s);
                items.AddRange(ItemA3s);
                items.AddRange(ItemA4s);
                items.AddRange(ItemB1s);
                items.AddRange(ItemB2s);
                items.AddRange(ItemB3s);
                items.AddRange(ItemB4s);
                items.AddRange(ItemB5s);
                items.AddRange(ItemC1s);
                items.AddRange(ItemC2s);
                items.AddRange(ItemC3s);
                items.AddRange(ItemC4s);
                items.AddRange(ItemC5s);
                items.AddRange(ItemC6s);
                items.AddRange(ItemC7s);
                items.AddRange(ItemD1s);
                items.AddRange(ItemD2s);
                items.AddRange(ItemE1s);
                items.AddRange(ItemE2s);
                items.AddRange(ItemE3s);
                items.AddRange(ItemE4s);
                items.AddRange(ItemE5s);
                items.AddRange(ItemE6s);
                items.AddRange(ItemE7s);
                items.AddRange(ItemF1s);
                items.AddRange(ItemG1s);
                items.AddRange(ItemG2s);
                items.AddRange(ItemG3s);
                items.AddRange(ItemG4s);
                items.AddRange(ItemG5s);
                items.AddRange(ItemG6s);
                items.AddRange(ItemH1s);
                items.AddRange(ItemH2s);
                items.AddRange(ItemH3s);
                items.AddRange(ItemH4s);
                items.AddRange(ItemH5s);
                items.AddRange(ItemI1s);
                items.AddRange(ItemI2s);
                items.AddRange(ItemJ1s);
                items.AddRange(ItemK1s);
                items.AddRange(ItemK2s);
                items.AddRange(ItemK3s);
                items.AddRange(ItemL1s);
                items.AddRange(ItemM1s);
                items.AddRange(ItemN1s);
                items.AddRange(ItemO1s);
                items.AddRange(ItemO2s);
                items.AddRange(ItemP1s);
                items.AddRange(ItemQ1s);
                items.AddRange(ItemQ2s);
                items.AddRange(ItemQ3s);
                items.AddRange(ItemQ4s);
                items.AddRange(ItemR1s);
                items.AddRange(ItemR2s);
                items.AddRange(ItemR3s);
                items.AddRange(ItemR4s);
                items.AddRange(ItemS1s);
                items.AddRange(ItemT1s);
                items.AddRange(ItemT2s);
                items.AddRange(ItemT3s);
                items.AddRange(ItemU1s);
                items.AddRange(ItemV1s);
                items.AddRange(ItemW1s);
                items.AddRange(ItemX1s);
                items.AddRange(ItemX2s);
                items.AddRange(ItemX3s);
                items.AddRange(ItemX4s);
                items.AddRange(ItemX5s);
                items.AddRange(ItemY1s);
                items.AddRange(ItemZ1s);
                items.AddRange(ItemAA1s);

                return items;
            }
        }

        public Quote()
        {
            ItemA1s = new ObservableCollection<ItemA1>();
            ItemA2s = new ObservableCollection<ItemA2>();
            ItemA3s = new ObservableCollection<ItemA3>();
            ItemA4s = new ObservableCollection<ItemA4>();

            ItemB1s = new ObservableCollection<ItemB1>();
            ItemB2s = new ObservableCollection<ItemB2>();
            ItemB3s = new ObservableCollection<ItemB3>();
            ItemB4s = new ObservableCollection<ItemB4>();
            ItemB5s = new ObservableCollection<ItemB5>();

            ItemC1s = new ObservableCollection<ItemC1>();
            ItemC2s = new ObservableCollection<ItemC2>();
            ItemC3s = new ObservableCollection<ItemC3>();
            ItemC4s = new ObservableCollection<ItemC4>();
            ItemC5s = new ObservableCollection<ItemC5>();
            ItemC6s = new ObservableCollection<ItemC6>();
            ItemC7s = new ObservableCollection<ItemC7>();

            ItemD1s = new ObservableCollection<ItemD1>();
            ItemD2s = new ObservableCollection<ItemD2>();

            ItemE1s = new ObservableCollection<ItemE1>();
            ItemE2s = new ObservableCollection<ItemE2>();
            ItemE3s = new ObservableCollection<ItemE3>();
            ItemE4s = new ObservableCollection<ItemE4>();
            ItemE5s = new ObservableCollection<ItemE5>();
            ItemE6s = new ObservableCollection<ItemE6>();
            ItemE7s = new ObservableCollection<ItemE7>();

            ItemF1s = new ObservableCollection<ItemF1>();

            ItemG1s = new ObservableCollection<ItemG1>();
            ItemG2s = new ObservableCollection<ItemG2>();
            ItemG3s = new ObservableCollection<ItemG3>();
            ItemG4s = new ObservableCollection<ItemG4>();
            ItemG5s = new ObservableCollection<ItemG5>();
            ItemG6s = new ObservableCollection<ItemG6>();

            ItemH1s = new ObservableCollection<ItemH1>();
            ItemH2s = new ObservableCollection<ItemH2>();
            ItemH3s = new ObservableCollection<ItemH3>();
            ItemH4s = new ObservableCollection<ItemH4>();
            ItemH5s = new ObservableCollection<ItemH5>();

            ItemI1s = new ObservableCollection<ItemI1>();
            ItemI2s = new ObservableCollection<ItemI2>();

            ItemJ1s = new ObservableCollection<ItemJ1>();

            ItemK1s = new ObservableCollection<ItemK1>();
            ItemK2s = new ObservableCollection<ItemK2>();
            ItemK3s = new ObservableCollection<ItemK3>();

            ItemL1s = new ObservableCollection<ItemL1>();

            ItemM1s = new ObservableCollection<ItemM1>();

            ItemN1s = new ObservableCollection<ItemN1>();

            ItemO1s = new ObservableCollection<ItemO1>();
            ItemO2s = new ObservableCollection<ItemO2>();

            ItemP1s = new ObservableCollection<ItemP1>();

            ItemQ1s = new ObservableCollection<ItemQ1>();
            ItemQ2s = new ObservableCollection<ItemQ2>();
            ItemQ3s = new ObservableCollection<ItemQ3>();
            ItemQ4s = new ObservableCollection<ItemQ4>();

            ItemR1s = new ObservableCollection<ItemR1>();
            ItemR2s = new ObservableCollection<ItemR2>();
            ItemR3s = new ObservableCollection<ItemR3>();
            ItemR4s = new ObservableCollection<ItemR4>();

            ItemS1s = new ObservableCollection<ItemS1>();

            ItemT1s = new ObservableCollection<ItemT1>();
            ItemT2s = new ObservableCollection<ItemT2>();
            ItemT3s = new ObservableCollection<ItemT3>();

            ItemU1s = new ObservableCollection<ItemU1>();

            ItemV1s = new ObservableCollection<ItemV1>();

            ItemW1s = new ObservableCollection<ItemW1>();   

            ItemX1s = new ObservableCollection<ItemX1>();
            ItemX2s = new ObservableCollection<ItemX2>();
            ItemX3s = new ObservableCollection<ItemX3>();
            ItemX4s = new ObservableCollection<ItemX4>();
            ItemX5s = new ObservableCollection<ItemX5>();

            ItemY1s = new ObservableCollection<ItemY1>();
            
            ItemZ1s = new ObservableCollection<ItemZ1>();

            ItemAA1s = new ObservableCollection<ItemAA1>();

            Name = "";

            QuoteCompanies = new ObservableCollection<QuoteCompanies>(); 
        }
    }
    
}
