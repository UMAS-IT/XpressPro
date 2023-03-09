using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Orion.UI.DependencyProperties
{
    public static class DataGridHelper
    {
        public static readonly DependencyProperty ColumnsProperty =
            DependencyProperty.RegisterAttached("Columns", typeof(ItemCollection), typeof(DataGridHelper), new PropertyMetadata(null, ColumnsChanged));

        public static ItemCollection GetColumns(DataGrid obj)
        {
            return (ItemCollection)obj.GetValue(ColumnsProperty);
        }

        public static void SetColumns(DataGrid obj, ItemCollection value)
        {
            obj.SetValue(ColumnsProperty, value);
        }

        private static void ColumnsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid dataGrid)
            {
                if (e.NewValue is ItemCollection columns)
                {
                    dataGrid.Columns.Clear();

                    foreach (var column in columns)
                    {
                        if (column is DataGridColumn dataGridColumn)
                        {
                            dataGrid.Columns.Add(dataGridColumn);
                        }
                    }
                }
            }
        }
    }

}
