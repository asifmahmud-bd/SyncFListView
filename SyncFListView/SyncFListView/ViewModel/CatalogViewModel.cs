using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SyncFListView.Model;

namespace SyncFListView.ViewModel
{
    public class CatalogViewModel
    {
        private ObservableCollection<Catalog> _catalogInfo;

        public ObservableCollection<Catalog> CatalogInfo
        {
            get { return this._catalogInfo; }
            set {this._catalogInfo= value; }
        }

        public CatalogViewModel()
        {
            GenerateSampleCatalogInfo();
        }

        internal void GenerateSampleCatalogInfo()
        {
            _catalogInfo = new ObservableCollection<Catalog>();
           
                _catalogInfo.Add(new Catalog(){ IfsId =Guid.NewGuid(), Catalog_id = "BMECAT_NL_B2C_NL", Catalog_name = "MIELE  USA",  Catalog_version = "xxx.yyy", Type ="catalog" });
                _catalogInfo.Add(new Catalog() { IfsId = Guid.NewGuid(), Catalog_id = "BMECAT_NL_B2C_NL", Catalog_name = "MIELE Italy", Catalog_version = "xxx.yyy", Type = "catalog" });
                _catalogInfo.Add(new Catalog() { IfsId = Guid.NewGuid(), Catalog_id = "BMECAT_NL_B2C_NL", Catalog_name = "MIELE Germany", Catalog_version = "xxx.yyy", Type = "catalog" });
                _catalogInfo.Add(new Catalog() { IfsId = Guid.NewGuid(), Catalog_id = "BMECAT_NL_B2C_NL", Catalog_name = "MIELE Franch", Catalog_version = "xxx.yyy", Type = "catalog" });
                _catalogInfo.Add(new Catalog() { IfsId = Guid.NewGuid(), Catalog_id = "BMECAT_NL_B2C_NL", Catalog_name = "MIELE Bangladesh", Catalog_version = "xxx.yyy", Type = "catalog" });
  
        }
    }
}
