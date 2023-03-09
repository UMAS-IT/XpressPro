using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Orion.UI.DependencyProperties
{
    public class DataGridColumnCollection : DependencyObject, INotifyCollectionChanged
    {
        public static readonly DependencyProperty ColumnsProperty =
            DependencyProperty.Register("Columns", typeof(ObservableCollection<DataGridColumn>), typeof(DataGridColumnCollection), new PropertyMetadata(null));

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public ObservableCollection<DataGridColumn> Columns
        {
            get { return (ObservableCollection<DataGridColumn>)GetValue(ColumnsProperty); }
            set { SetValue(ColumnsProperty, value); }
        }

        public DataGridColumnCollection()
        {
            Columns = new ObservableCollection<DataGridColumn>();
            Columns.CollectionChanged += Columns_CollectionChanged;
        }

        private void Columns_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CollectionChanged?.Invoke(this, e);
        }
    }
}
