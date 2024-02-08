using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.Polaris.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Polaris.Item
{
    public class ItemW1 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _cfm;
        public string Cfm
        {
            get => _cfm;
            set => SetProperty(ref _cfm, value);
        }

        private string _hotSideGpm;
        public string HotSideGpm
        {
            get => _hotSideGpm;
            set => SetProperty(ref _hotSideGpm, value);
        }

        private string _hotSideEwt;
        public string HotSideEwt
        {
            get => _hotSideEwt;
            set => SetProperty(ref _hotSideEwt, value);
        }

        private string _coldSideGpm;
        public string ColdSideGpm
        {
            get => _coldSideGpm;
            set => SetProperty(ref _coldSideGpm, value);
        }

        private string _coldSideEwt;
        public string ColdSideEwt
        {
            get => _coldSideEwt;
            set => SetProperty(ref _coldSideEwt, value);
        }

        private int? _catalogW1Id;
        public int? CatalogW1Id
        {
            get => _catalogW1Id;
            set => SetProperty(ref _catalogW1Id, value);
        }

        private CatalogW1 _catalogW1;
        public CatalogW1 CatalogW1
        {
            get => _catalogW1;
            set => SetProperty(ref _catalogW1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogW1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogW1Id; } }

        public ItemW1() : base()
        {
            Model = "";
            Cfm = "";
            HotSideGpm = "";
            HotSideEwt = "";
            ColdSideGpm = "";
            ColdSideEwt = "";
        }
    }
}
