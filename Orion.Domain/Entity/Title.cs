using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AERCO.Item;
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

namespace Orion.Domain.Entity
{
    public class Title : ValidatableBindableBase, IEntity, ICloneable, ITexteable
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private IList<Spec> _specs;
        public IList<Spec> Specs
        {
            get => _specs;
            set => SetProperty(ref _specs, value);
        }



        #region Quantech Items Id
        private int? _itemA1Id;
        public int? ItemA1Id
        {
            get => _itemA1Id;
            set => SetProperty(ref _itemA1Id, value);
        }

        private ItemA1 _itemA1;
        public ItemA1 ItemA1
        {
            get => _itemA1;
            set => SetProperty(ref _itemA1, value);
        }

        private int? _itemA2Id;
        public int? ItemA2Id
        {
            get => _itemA2Id;
            set => SetProperty(ref _itemA2Id, value);
        }

        private ItemA2 _itemA2;
        public ItemA2 ItemA2
        {
            get => _itemA2;
            set => SetProperty(ref _itemA2, value);
        }

        private int? _itemA3Id;
        public int? ItemA3Id
        {
            get => _itemA3Id;
            set => SetProperty(ref _itemA3Id, value);
        }

        private ItemA3 _itemA3;
        public ItemA3 ItemA3
        {
            get => _itemA3;
            set => SetProperty(ref _itemA3, value);
        }

        private int? _itemA4Id;
        public int? ItemA4Id
        {
            get => _itemA4Id;
            set => SetProperty(ref _itemA4Id, value);
        }

        private ItemA4 _itemA4;
        public ItemA4 ItemA4
        {
            get => _itemA4;
            set => SetProperty(ref _itemA4, value);
        }
        #endregion



        #region ABB Items Id
        private int? _itemB1Id;
        public int? ItemB1Id
        {
            get => _itemB1Id;
            set => SetProperty(ref _itemB1Id, value);
        }

        private ItemB1 _itemB1;
        public ItemB1 ItemB1
        {
            get => _itemB1;
            set => SetProperty(ref _itemB1, value);
        }

        private int? _itemB2Id;
        public int? ItemB2Id
        {
            get => _itemB2Id;
            set => SetProperty(ref _itemB2Id, value);
        }

        private ItemB2 _itemB2;
        public ItemB2 ItemB2
        {
            get => _itemB2;
            set => SetProperty(ref _itemB2, value);
        }

        private int? _itemB3Id;
        public int? ItemB3Id
        {
            get => _itemB3Id;
            set => SetProperty(ref _itemB3Id, value);
        }

        private ItemB3 _itemB3;
        public ItemB3 ItemB3
        {
            get => _itemB3;
            set => SetProperty(ref _itemB3, value);
        }

        private int? _itemB4Id;
        public int? ItemB4Id
        {
            get => _itemB4Id;
            set => SetProperty(ref _itemB4Id, value);
        }

        private ItemB4 _itemB4;
        public ItemB4 ItemB4
        {
            get => _itemB4;
            set => SetProperty(ref _itemB4, value);
        }

        private int? _itemB5Id;
        public int? ItemB5Id
        {
            get => _itemB5Id;
            set => SetProperty(ref _itemB5Id, value);
        }

        private ItemB5 _itemB5;
        public ItemB5 ItemB5
        {
            get => _itemB5;
            set => SetProperty(ref _itemB5, value);
        }
        #endregion



        #region American Wheatley Items Id
        private int? _itemC1Id;
        public int? ItemC1Id
        {
            get => _itemC1Id;
            set => SetProperty(ref _itemC1Id, value);
        }

        private ItemC1 _itemC1;
        public ItemC1 ItemC1
        {
            get => _itemC1;
            set => SetProperty(ref _itemC1, value);
        }

        private int? _itemC2Id;
        public int? ItemC2Id
        {
            get => _itemC2Id;
            set => SetProperty(ref _itemC2Id, value);
        }

        private ItemC2 _itemC2;
        public ItemC2 ItemC2
        {
            get => _itemC2;
            set => SetProperty(ref _itemC2, value);
        }

        private int? _itemC3Id;
        public int? ItemC3Id
        {
            get => _itemC3Id;
            set => SetProperty(ref _itemC3Id, value);
        }

        private ItemC3 _itemC3;
        public ItemC3 ItemC3
        {
            get => _itemC3;
            set => SetProperty(ref _itemC3, value);
        }

        private int? _itemC4Id;
        public int? ItemC4Id
        {
            get => _itemC4Id;
            set => SetProperty(ref _itemC4Id, value);
        }

        private ItemC4 _itemC4;
        public ItemC4 ItemC4
        {
            get => _itemC4;
            set => SetProperty(ref _itemC4, value);
        }

        private int? _itemC5Id;
        public int? ItemC5Id
        {
            get => _itemC5Id;
            set => SetProperty(ref _itemC5Id, value);
        }

        private ItemC5 _itemC5;
        public ItemC5 ItemC5
        {
            get => _itemC5;
            set => SetProperty(ref _itemC5, value);
        }

        private int? _itemC6Id;
        public int? ItemC6Id
        {
            get => _itemC6Id;
            set => SetProperty(ref _itemC6Id, value);
        }

        private ItemC6 _itemC6;
        public ItemC6 ItemC6
        {
            get => _itemC6;
            set => SetProperty(ref _itemC6, value);
        }

        private int? _itemC7Id;
        public int? ItemC7Id
        {
            get => _itemC7Id;
            set => SetProperty(ref _itemC7Id, value);
        }

        private ItemC7 _itemC7;
        public ItemC7 ItemC7
        {
            get => _itemC7;
            set => SetProperty(ref _itemC7, value);
        }
        #endregion



        #region Puroflux Items Id
        private int? _itemD1Id;
        public int? ItemD1Id
        {
            get => _itemD1Id;
            set => SetProperty(ref _itemD1Id, value);
        }

        private ItemD1 _itemD1;
        public ItemD1 ItemD1
        {
            get => _itemD1;
            set => SetProperty(ref _itemD1, value);
        }

        private int? _itemD2Id;
        public int? ItemD2Id
        {
            get => _itemD2Id;
            set => SetProperty(ref _itemD2Id, value);
        }

        private ItemD2 _itemD2;
        public ItemD2 ItemD2
        {
            get => _itemD2;
            set => SetProperty(ref _itemD2, value);
        }
        #endregion



        #region Groundfos Items Id
        private int? _itemE1Id;
        public int? ItemE1Id
        {
            get => _itemE1Id;
            set => SetProperty(ref _itemE1Id, value);
        }

        private ItemE1 _itemE1;
        public ItemE1 ItemE1
        {
            get => _itemE1;
            set => SetProperty(ref _itemE1, value);
        }

        private int? _itemE2Id;
        public int? ItemE2Id
        {
            get => _itemE2Id;
            set => SetProperty(ref _itemE2Id, value);
        }

        private ItemE2 _itemE2;
        public ItemE2 ItemE2
        {
            get => _itemE2;
            set => SetProperty(ref _itemE2, value);
        }

        private int? _itemE3Id;
        public int? ItemE3Id
        {
            get => _itemE3Id;
            set => SetProperty(ref _itemE3Id, value);
        }

        private ItemE3 _itemE3;
        public ItemE3 ItemE3
        {
            get => _itemE3;
            set => SetProperty(ref _itemE3, value);
        }

        private int? _itemE4Id;
        public int? ItemE4Id
        {
            get => _itemE4Id;
            set => SetProperty(ref _itemE4Id, value);
        }

        private ItemE4 _itemE4;
        public ItemE4 ItemE4
        {
            get => _itemE4;
            set => SetProperty(ref _itemE4, value);
        }

        private int? _itemE5Id;
        public int? ItemE5Id
        {
            get => _itemE5Id;
            set => SetProperty(ref _itemE5Id, value);
        }

        private ItemE5 _itemE5;
        public ItemE5 ItemE5
        {
            get => _itemE5;
            set => SetProperty(ref _itemE5, value);
        }

        private int? _itemE6Id;
        public int? ItemE6Id
        {
            get => _itemE6Id;
            set => SetProperty(ref _itemE6Id, value);
        }

        private ItemE6 _itemE6;
        public ItemE6 ItemE6
        {
            get => _itemE6;
            set => SetProperty(ref _itemE6, value);
        }

        private int? _itemE7Id;
        public int? ItemE7Id
        {
            get => _itemE7Id;
            set => SetProperty(ref _itemE7Id, value);
        }

        private ItemE7 _itemE7;
        public ItemE7 ItemE7
        {
            get => _itemE7;
            set => SetProperty(ref _itemE7, value);
        }
        #endregion



        #region UV Resources Items Id
        private int? _itemF1Id;
        public int? ItemF1Id
        {
            get => _itemF1Id;
            set => SetProperty(ref _itemF1Id, value);
        }

        private ItemF1 _itemF1;
        public ItemF1 ItemF1
        {
            get => _itemF1;
            set => SetProperty(ref _itemF1, value);
        }
        #endregion



        #region BAC Cooling Towers Items Id
        private int? _itemG1Id;
        public int? ItemG1Id
        {
            get => _itemG1Id;
            set => SetProperty(ref _itemG1Id, value);
        }

        private ItemG1 _itemG1;
        public ItemG1 ItemG1
        {
            get => _itemG1;
            set => SetProperty(ref _itemG1, value);
        }

        private int? _itemG2Id;
        public int? ItemG2Id
        {
            get => _itemG2Id;
            set => SetProperty(ref _itemG2Id, value);
        }

        private ItemG2 _itemG2;
        public ItemG2 ItemG2
        {
            get => _itemG2;
            set => SetProperty(ref _itemG2, value);
        }

        private int? _itemG3Id;
        public int? ItemG3Id
        {
            get => _itemG3Id;
            set => SetProperty(ref _itemG3Id, value);
        }

        private ItemG3 _itemG3;
        public ItemG3 ItemG3
        {
            get => _itemG3;
            set => SetProperty(ref _itemG3, value);
        }

        private int? _itemG4Id;
        public int? ItemG4Id
        {
            get => _itemG4Id;
            set => SetProperty(ref _itemG4Id, value);
        }

        private ItemG4 _itemG4;
        public ItemG4 ItemG4
        {
            get => _itemG4;
            set => SetProperty(ref _itemG4, value);
        }

        private int? _itemG5Id;
        public int? ItemG5Id
        {
            get => _itemG5Id;
            set => SetProperty(ref _itemG5Id, value);
        }

        private ItemG5 _itemG5;
        public ItemG5 ItemG5
        {
            get => _itemG5;
            set => SetProperty(ref _itemG5, value);
        }

        private int? _itemG6Id;
        public int? ItemG6Id
        {
            get => _itemG6Id;
            set => SetProperty(ref _itemG6Id, value);
        }

        private ItemG6 _itemG6;
        public ItemG6 ItemG6
        {
            get => _itemG6;
            set => SetProperty(ref _itemG6, value);
        }
        #endregion



        #region BAC Closed Circuits Items Id
        private int? _itemH1Id;
        public int? ItemH1Id
        {
            get => _itemH1Id;
            set => SetProperty(ref _itemH1Id, value);
        }

        private ItemH1 _itemH1;
        public ItemH1 ItemH1
        {
            get => _itemH1;
            set => SetProperty(ref _itemH1, value);
        }

        private int? _itemH2Id;
        public int? ItemH2Id
        {
            get => _itemH2Id;
            set => SetProperty(ref _itemH2Id, value);
        }

        private ItemH2 _itemH2;
        public ItemH2 ItemH2
        {
            get => _itemH2;
            set => SetProperty(ref _itemH2, value);
        }

        private int? _itemH3Id;
        public int? ItemH3Id
        {
            get => _itemH3Id;
            set => SetProperty(ref _itemH3Id, value);
        }

        private ItemH3 _itemH3;
        public ItemH3 ItemH3
        {
            get => _itemH3;
            set => SetProperty(ref _itemH3, value);
        }

        private int? _itemH4Id;
        public int? ItemH4Id
        {
            get => _itemH4Id;
            set => SetProperty(ref _itemH4Id, value);
        }

        private ItemH4 _itemH4;
        public ItemH4 ItemH4
        {
            get => _itemH4;
            set => SetProperty(ref _itemH4, value);
        }

        private int? _itemH5Id;
        public int? ItemH5Id
        {
            get => _itemH5Id;
            set => SetProperty(ref _itemH5Id, value);
        }

        private ItemH5 _itemH5;
        public ItemH5 ItemH5
        {
            get => _itemH5;
            set => SetProperty(ref _itemH5, value);
        }
        #endregion



        #region Marvair Items Id
        private int? _itemI1Id;
        public int? ItemI1Id
        {
            get => _itemI1Id;
            set => SetProperty(ref _itemI1Id, value);
        }

        private ItemI1 _itemI1;
        public ItemI1 ItemI1
        {
            get => _itemI1;
            set => SetProperty(ref _itemI1, value);
        }

        private int? _itemI2Id;
        public int? ItemI2Id
        {
            get => _itemI2Id;
            set => SetProperty(ref _itemI2Id, value);
        }

        private ItemI2 _itemI2;
        public ItemI2 ItemI2
        {
            get => _itemI2;
            set => SetProperty(ref _itemI2, value);
        }
        #endregion



        #region PACE AHU Items Id
        private int? _itemJ1Id;
        public int? ItemJ1Id
        {
            get => _itemJ1Id;
            set => SetProperty(ref _itemJ1Id, value);
        }

        private ItemJ1 _itemJ1;
        public ItemJ1 ItemJ1
        {
            get => _itemJ1;
            set => SetProperty(ref _itemJ1, value);
        }
        #endregion



        #region Multiaqua Items Id

        private int? _itemK1Id;
        public int? ItemK1Id
        {
            get => _itemK1Id;
            set => SetProperty(ref _itemK1Id, value);
        }

        private ItemK1 _itemK1;
        public ItemK1 ItemK1
        {
            get => _itemK1;
            set => SetProperty(ref _itemK1, value);
        }

        private int? _itemK2Id;
        public int? ItemK2Id
        {
            get => _itemK2Id;
            set => SetProperty(ref _itemK2Id, value);
        }

        private ItemK2 _itemK2;
        public ItemK2 ItemK2
        {
            get => _itemK2;
            set => SetProperty(ref _itemK2, value);
        }

        private int? _itemK3Id;
        public int? ItemK3Id
        {
            get => _itemK3Id;
            set => SetProperty(ref _itemK3Id, value);
        }

        private ItemK3 _itemK3;
        public ItemK3 ItemK3
        {
            get => _itemK3;
            set => SetProperty(ref _itemK3, value);
        }
        #endregion



        #region General Product Items Id

        private int? _itemL1Id;
        public int? ItemL1Id
        {
            get => _itemL1Id;
            set => SetProperty(ref _itemL1Id, value);
        }

        private ItemL1 _itemL1;
        public ItemL1 ItemL1
        {
            get => _itemL1;
            set => SetProperty(ref _itemL1, value);
        }
        #endregion


        #region DataSheet Id

        private int? _dataSheetId;
        public int? DataSheetId
        {
            get => _dataSheetId;
            set => SetProperty(ref _dataSheetId, value);
        }

        private DataSheet _dataSheet;
        public DataSheet DataSheet
        {
            get => _dataSheet;
            set => SetProperty(ref _dataSheet, value);
        }
        #endregion


        #region UMAS AHU Items Id
        private int? _itemM1Id;
        public int? ItemM1Id
        {
            get => _itemM1Id;
            set => SetProperty(ref _itemM1Id, value);
        }

        private ItemM1 _itemM1;
        public ItemM1 ItemM1
        {
            get => _itemM1;
            set => SetProperty(ref _itemM1, value);
        }
        #endregion


        #region ABOVE AIR Items Id
        private int? _itemN1Id;
        public int? ItemN1Id
        {
            get => _itemN1Id;
            set => SetProperty(ref _itemN1Id, value);
        }

        private ItemN1 _itemN1;
        public ItemN1 ItemN1
        {
            get => _itemN1;
            set => SetProperty(ref _itemN1, value);
        }
        #endregion

        
        #region AERCO Items Id

        private int? _itemO1Id;
        public int? ItemO1Id
        {
            get => _itemO1Id;
            set => SetProperty(ref _itemO1Id, value);
        }

        private ItemO1 _itemO1;
        public ItemO1 ItemO1
        {
            get => _itemO1;
            set => SetProperty(ref _itemO1, value);
        }

        private int? _itemO2Id;
        public int? ItemO2Id
        {
            get => _itemO2Id;
            set => SetProperty(ref _itemO2Id, value);
        }

        private ItemO2 _itemO2;
        public ItemO2 ItemO2
        {
            get => _itemO2;
            set => SetProperty(ref _itemO2, value);
        }
        #endregion


        #region Baldor Items Id

        private int? _itemP1Id;
        public int? ItemP1Id
        {
            get => _itemP1Id;
            set => SetProperty(ref _itemP1Id, value);
        }

        private ItemP1 _itemP1;
        public ItemP1 ItemP1
        {
            get => _itemP1;
            set => SetProperty(ref _itemP1, value);
        }
        #endregion


        #region Condair Items Id
        private int? _itemQ1Id;
        public int? ItemQ1Id
        {
            get => _itemQ1Id;
            set => SetProperty(ref _itemQ1Id, value);
        }

        private ItemQ1 _itemQ1;
        public ItemQ1 ItemQ1
        {
            get => _itemQ1;
            set => SetProperty(ref _itemQ1, value);
        }

        private int? _itemQ2Id;
        public int? ItemQ2Id
        {
            get => _itemQ2Id;
            set => SetProperty(ref _itemQ2Id, value);
        }

        private ItemQ2 _itemQ2;
        public ItemQ2 ItemQ2
        {
            get => _itemQ2;
            set => SetProperty(ref _itemQ2, value);
        }

        private int? _itemQ3Id;
        public int? ItemQ3Id
        {
            get => _itemQ3Id;
            set => SetProperty(ref _itemQ3Id, value);
        }

        private ItemQ3 _itemQ3;
        public ItemQ3 ItemQ3
        {
            get => _itemQ3;
            set => SetProperty(ref _itemQ3, value);
        }

        private int? _itemQ4Id;
        public int? ItemQ4Id
        {
            get => _itemQ4Id;
            set => SetProperty(ref _itemQ4Id, value);
        }

        private ItemQ4 _itemQ4;
        public ItemQ4 ItemQ4
        {
            get => _itemQ4;
            set => SetProperty(ref _itemQ4, value);
        }
        #endregion


        #region Enviro-Tec Items Id
        private int? _itemR1Id;
        public int? ItemR1Id
        {
            get => _itemR1Id;
            set => SetProperty(ref _itemR1Id, value);
        }

        private ItemR1 _itemR1;
        public ItemR1 ItemR1
        {
            get => _itemR1;
            set => SetProperty(ref _itemR1, value);
        }

        private int? _itemR2Id;
        public int? ItemR2Id
        {
            get => _itemR2Id;
            set => SetProperty(ref _itemR2Id, value);
        }

        private ItemR2 _itemR2;
        public ItemR2 ItemR2
        {
            get => _itemR2;
            set => SetProperty(ref _itemR2, value);
        }

        private int? _itemR3Id;
        public int? ItemR3Id
        {
            get => _itemR3Id;
            set => SetProperty(ref _itemR3Id, value);
        }

        private ItemR3 _itemR3;
        public ItemR3 ItemR3
        {
            get => _itemR3;
            set => SetProperty(ref _itemR3, value);
        }

        private int? _itemR4Id;
        public int? ItemR4Id
        {
            get => _itemR4Id;
            set => SetProperty(ref _itemR4Id, value);
        }

        private ItemR4 _itemR4;
        public ItemR4 ItemR4
        {
            get => _itemR4;
            set => SetProperty(ref _itemR4, value);
        }
        #endregion


        #region LYNC Items Id
        private int? _itemS1Id;
        public int? ItemS1Id
        {
            get => _itemS1Id;
            set => SetProperty(ref _itemS1Id, value);
        }

        private ItemS1 _itemS1;
        public ItemS1 ItemS1
        {
            get => _itemS1;
            set => SetProperty(ref _itemS1, value);
        }
        #endregion


        #region Nortek Items Id
        private int? _itemT1Id;
        public int? ItemT1Id
        {
            get => _itemT1Id;
            set => SetProperty(ref _itemT1Id, value);
        }

        private ItemT1 _itemT1;
        public ItemT1 ItemT1
        {
            get => _itemT1;
            set => SetProperty(ref _itemT1, value);
        }

        private int? _itemT2Id;
        public int? ItemT2Id
        {
            get => _itemT2Id;
            set => SetProperty(ref _itemT2Id, value);
        }

        private ItemT2 _itemT2;
        public ItemT2 ItemT2
        {
            get => _itemT2;
            set => SetProperty(ref _itemT2, value);
        }

        private int? _itemT3Id;
        public int? ItemT3Id
        {
            get => _itemT3Id;
            set => SetProperty(ref _itemT3Id, value);
        }

        private ItemT3 _itemT3;
        public ItemT3 ItemT3
        {
            get => _itemT3;
            set => SetProperty(ref _itemT3, value);
        }
        #endregion


        #region NYLE Items Id
        private int? _itemU1Id;
        public int? ItemU1Id
        {
            get => _itemU1Id;
            set => SetProperty(ref _itemU1Id, value);
        }

        private ItemU1 _itemU1;
        public ItemU1 ItemU1
        {
            get => _itemU1;
            set => SetProperty(ref _itemU1, value);
        }
        #endregion


        #region Plasma Air Items Id
        private int? _itemV1Id;
        public int? ItemV1Id
        {
            get => _itemV1Id;
            set => SetProperty(ref _itemV1Id, value);
        }

        private ItemV1 _itemV1;
        public ItemV1 ItemV1
        {
            get => _itemV1;
            set => SetProperty(ref _itemV1, value);
        }
        #endregion


        #region Polaris Items Id
        private int? _itemW1Id;
        public int? ItemW1Id
        {
            get => _itemW1Id;
            set => SetProperty(ref _itemW1Id, value);
        }

        private ItemW1 _itemW1;
        public ItemW1 ItemW1
        {
            get => _itemW1;
            set => SetProperty(ref _itemW1, value);
        }
        #endregion


        #region PVI Items Id
        private int? _itemX1Id;
        public int? ItemX1Id
        {
            get => _itemX1Id;
            set => SetProperty(ref _itemX1Id, value);
        }

        private ItemX1 _itemX1;
        public ItemX1 ItemX1
        {
            get => _itemX1;
            set => SetProperty(ref _itemX1, value);
        }

        private int? _itemX2Id;
        public int? ItemX2Id
        {
            get => _itemX2Id;
            set => SetProperty(ref _itemX2Id, value);
        }

        private ItemX2 _itemX2;
        public ItemX2 ItemX2
        {
            get => _itemX2;
            set => SetProperty(ref _itemX2, value);
        }

        private int? _itemX3Id;
        public int? ItemX3Id
        {
            get => _itemX3Id;
            set => SetProperty(ref _itemX3Id, value);
        }

        private ItemX3 _itemX3;
        public ItemX3 ItemX3
        {
            get => _itemX3;
            set => SetProperty(ref _itemX3, value);
        }

        private int? _itemX4Id;
        public int? ItemX4Id
        {
            get => _itemX4Id;
            set => SetProperty(ref _itemX4Id, value);
        }

        private ItemX4 _itemX4;
        public ItemX4 ItemX4
        {
            get => _itemX4;
            set => SetProperty(ref _itemX4, value);
        }

        private int? _itemX5Id;
        public int? ItemX5Id
        {
            get => _itemX5Id;
            set => SetProperty(ref _itemX5Id, value);
        }

        private ItemX5 _itemX5;
        public ItemX5 ItemX5
        {
            get => _itemX5;
            set => SetProperty(ref _itemX5, value);
        }
        #endregion


        #region Robur Items Id
        private int? _itemY1Id;
        public int? ItemY1Id
        {
            get => _itemY1Id;
            set => SetProperty(ref _itemY1Id, value);
        }

        private ItemY1 _itemY1;
        public ItemY1 ItemY1
        {
            get => _itemY1;
            set => SetProperty(ref _itemY1, value);
        }
        #endregion


        #region Valent Items Id
        private int? _itemZ1Id;
        public int? ItemZ1Id
        {
            get => _itemZ1Id;
            set => SetProperty(ref _itemZ1Id, value);
        }

        private ItemZ1 _itemZ1;
        public ItemZ1 ItemZ1
        {
            get => _itemZ1;
            set => SetProperty(ref _itemZ1, value);
        }
        #endregion


        #region Whalen Items Id
        private int? _itemAA1Id;
        public int? ItemAA1Id
        {
            get => _itemAA1Id;
            set => SetProperty(ref _itemAA1Id, value);
        }

        private ItemAA1 _itemAA1;
        public ItemAA1 ItemAA1
        {
            get => _itemAA1;
            set => SetProperty(ref _itemAA1, value);
        }
        #endregion


        private bool _saved;
        [NotMapped]
        public bool Saved
        {
            get => _saved;
            set => SetProperty(ref _saved, value);
        }

        private bool _highlighted;
        public bool Highlighted
        {
            get => _highlighted;
            set => SetProperty(ref _highlighted, value);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public Title()
        {
            Specs = new ObservableCollection<Spec>();
            Name = "Default Title Name";
        }
    }
}
