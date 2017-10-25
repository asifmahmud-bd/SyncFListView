using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Syncfusion.DataSource;

namespace SyncFListView.Model
{
    public class Catalog : INotifyPropertyChanged
    {
        private Guid _ifsId;
        private string _catalog_id;
        private string _type;
        private string _catalog_name;
        private string _catalog_version;

        public Guid IfsId
        {
            get { return _ifsId; }
            set
            {
                value = _ifsId;
                OnPropertyChange("IfsId");
            }
        }
        public string Type
        {
            get { return _type; }
            set
            {
                value = _type;
                OnPropertyChange("Type");
            }
        }

        public string Catalog_id
        {
            get { return _catalog_id; }
            set
            {
                value = _catalog_id;
                OnPropertyChange("Catalog_id");
            }
        }

        public string Catalog_name
        {
            get { return _catalog_name; }
            set
            {
                value = _catalog_name;
                OnPropertyChange("Catalog_name");
            }
        }

        public string Catalog_version
        {
            
            get { return _catalog_version; }
            set
            {
                value = _catalog_version;
                OnPropertyChange("Catalog_version");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
    }
}
