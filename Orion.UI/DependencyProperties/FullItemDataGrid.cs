using MahApps.Metro.Controls;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Orion.UI.DependencyProperties
{
    public class FullItemDataGrid : DataGrid
    {
        public static readonly DependencyProperty MyColumnsProperty =
            DependencyProperty.Register("MyColumns", typeof(ObservableCollection<DataGridColumn>), typeof(FullItemDataGrid), new PropertyMetadata(null, OnMyColumnsChanged));

        public FullItemDataGrid()
        {
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var dataGrid = sender as FullItemDataGrid;

            if (!dataGrid.Columns.Any(x => x.Header.ToString().ToFormat() == "" 
            || x.Header.ToString().ToFormat() == "exclude"
            || x.Header.ToString().ToFormat() == "override"
            || x.Header.ToString().ToFormat() == "quantity"
            || x.Header.ToString().ToFormat() == "list price"
            || x.Header.ToString().ToFormat() == "cost multiplier"
            || x.Header.ToString().ToFormat() == "cost"
            || x.Header.ToString().ToFormat() == "sell margin"
            || x.Header.ToString().ToFormat() == "unit sell price"
            || x.Header.ToString().ToFormat() == "total"
            || x.Header.ToString().ToFormat() == "model"
            || x.Header.ToString().ToFormat() == "freight"
            || x.Header.ToString().ToFormat() == "tag"))
            {

                var column = new DataGridTemplateColumn();
                
                AddColumnHeaderStyle(column, "");

                var factory = new FrameworkElementFactory(typeof(Button));
                factory.SetValue(Button.StyleProperty, Application.Current.Resources["moveToStartButtonStyle"]);

                AddColum(dataGrid, column, factory, 0);



                column = new DataGridTemplateColumn();
                
                AddColumnHeaderStyle(column, "");

                factory = new FrameworkElementFactory(typeof(Button));
                factory.SetValue(Button.StyleProperty, Application.Current.Resources["moveToUpButtonStyle"]);
               
                AddColum(dataGrid, column, factory, 1);



                column = new DataGridTemplateColumn();
                
                AddColumnHeaderStyle(column, "");

                factory = new FrameworkElementFactory(typeof(Button));
                factory.SetValue(Button.StyleProperty, Application.Current.Resources["deleteItemButtonStyle"]);
               
                AddColum(dataGrid, column, factory, 2);



                column = new DataGridTemplateColumn();

                AddColumnHeaderStyle(column, "");

                factory = new FrameworkElementFactory(typeof(Button));
                factory.SetValue(Button.StyleProperty, Application.Current.Resources["buttonInfoStyle"]);

                AddColum(dataGrid, column, factory, 3);



                column = new DataGridTemplateColumn();
               
                AddColumnHeaderStyle(column, "");

                factory = new FrameworkElementFactory(typeof(Button));
                factory.SetValue(Button.StyleProperty, Application.Current.Resources["moveToDownButtonStyle"]);

                AddColum(dataGrid, column, factory, 4);




                column = new DataGridTemplateColumn();
                
                AddColumnHeaderStyle(column, "");

                factory = new FrameworkElementFactory(typeof(Button));
                factory.SetValue(Button.StyleProperty, Application.Current.Resources["moveToEndButtonStyle"]);

                AddColum(dataGrid, column, factory, 5);



                column = new DataGridTemplateColumn();

                AddColumnHeaderStyle(column, "Exclude");

                factory = new FrameworkElementFactory(typeof(CheckBox));
                factory.SetValue(CheckBox.ToolTipProperty, "Exclude item from quote");
                factory.SetValue(CheckBox.StyleProperty, Application.Current.Resources["chekboxStyle"]);
                factory.SetBinding(CheckBox.IsCheckedProperty, new System.Windows.Data.Binding("IsExcluded") { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });

                AddColum(dataGrid, column, factory, 6);



                column = new DataGridTemplateColumn();

                AddColumnHeaderStyle(column, "Override");

                factory = new FrameworkElementFactory(typeof(CheckBox));
                factory.SetValue(CheckBox.ToolTipProperty, "Override item prices");
                factory.SetValue(CheckBox.StyleProperty, Application.Current.Resources["chekboxStyle"]);
                factory.SetBinding(CheckBox.IsCheckedProperty, new System.Windows.Data.Binding("OverridePrice") { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });

                AddColum(dataGrid, column, factory, 7);




                column = new DataGridTemplateColumn();
                
                AddColumnHeaderStyle(column, "Tag");

                factory = new FrameworkElementFactory(typeof(TextBox));
                factory.SetBinding(TextBox.TextProperty, new System.Windows.Data.Binding("Tag") { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
                factory.SetValue(TextBox.MaxLengthProperty, 20);
                factory.SetValue(TextBox.CharacterCasingProperty, CharacterCasing.Upper);

                AddColum(dataGrid, column, factory, 8);



                column = new DataGridTemplateColumn();
                
                AddColumnHeaderStyle(column, "Quantity");

                factory = new FrameworkElementFactory(typeof(NumericUpDown));
                factory.SetValue(NumericUpDown.StyleProperty, Application.Current.Resources["customNumericStyle"]);
                factory.SetBinding(NumericUpDown.ValueProperty, new System.Windows.Data.Binding("Quantity") { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
                
                AddColum(dataGrid, column, factory, 9);



                column = new DataGridTemplateColumn();
                column.Width = DataGridLength.Auto;
                column.IsReadOnly = true;
                column.Header = "Model";
                column.HeaderStyle = (Style)Application.Current.Resources["ColumnHeaderStyle"];

                factory = new FrameworkElementFactory(typeof(TextBlock));
                factory.SetBinding(TextBlock.TextProperty, new System.Windows.Data.Binding("Catalog.Model"));

                AddColum(dataGrid, column, factory, 10);



                column = new DataGridTemplateColumn();

                AddColumnHeaderStyle(column, "List Price");

                factory = new FrameworkElementFactory(typeof(TextBox));
                factory.SetValue(TextBox.StyleProperty, Application.Current.Resources["overrideTextBoxStyle"]);
                factory.SetBinding(TextBox.TextProperty, new System.Windows.Data.Binding("ListPrice") { UpdateSourceTrigger = UpdateSourceTrigger.LostFocus, StringFormat = "{0:c}", Mode = BindingMode.TwoWay });
                factory.SetValue(TextBox.MaxLengthProperty, 20);
                factory.SetValue(TextBoxHelper.SelectAllOnFocusProperty, true);
                factory.AddHandler(PreviewTextInputEvent, new TextCompositionEventHandler(IsDouble));

                AddColum(dataGrid, column, factory, 0, true);



                column = new DataGridTemplateColumn();

                AddColumnHeaderStyle(column, "Cost Multiplier");

                factory = new FrameworkElementFactory(typeof(TextBox));
                factory.SetValue(TextBox.StyleProperty, Application.Current.Resources["overrideTextBoxStyle"]);
                factory.SetBinding(TextBox.TextProperty, new System.Windows.Data.Binding("CostMultiplier") { UpdateSourceTrigger = UpdateSourceTrigger.LostFocus, Mode = BindingMode.TwoWay });
                factory.SetValue(TextBox.MaxLengthProperty, 20);
                factory.SetValue(TextBoxHelper.SelectAllOnFocusProperty, true);
                factory.AddHandler(PreviewTextInputEvent, new TextCompositionEventHandler(IsDouble));

                AddColum(dataGrid, column, factory, 0, true);



                column = new DataGridTemplateColumn();
                column.Width = DataGridLength.Auto;
                column.IsReadOnly = true;
                AddColumnHeaderStyle(column, "Cost");

                factory = new FrameworkElementFactory(typeof(TextBlock));
                factory.SetBinding(TextBlock.TextProperty, new System.Windows.Data.Binding("Cost") { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, StringFormat = "{0:c}", Mode = BindingMode.TwoWay });

                AddColum(dataGrid, column, factory, 0, true);



                column = new DataGridTemplateColumn();

                AddColumnHeaderStyle(column, "Sell Margin");

                factory = new FrameworkElementFactory(typeof(TextBox));
                factory.SetValue(TextBox.StyleProperty, Application.Current.Resources["overrideTextBoxStyle"]);
                factory.SetBinding(TextBox.TextProperty, new System.Windows.Data.Binding("SellMargin") { UpdateSourceTrigger = UpdateSourceTrigger.LostFocus, StringFormat = "{0}%", Mode = BindingMode.TwoWay });
                factory.SetValue(TextBox.MaxLengthProperty, 20);
                factory.SetValue(TextBoxHelper.SelectAllOnFocusProperty, true);
                factory.AddHandler(PreviewTextInputEvent, new TextCompositionEventHandler(IsDouble));

                AddColum(dataGrid, column, factory, 0, true);



                column = new DataGridTemplateColumn();
                column.Width = DataGridLength.Auto;
                column.IsReadOnly = true;
                AddColumnHeaderStyle(column, "Unit Sell Price");

                factory = new FrameworkElementFactory(typeof(TextBlock));
                factory.SetBinding(TextBlock.TextProperty, new System.Windows.Data.Binding("SellPrice") { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, StringFormat = "{0:c}", Mode = BindingMode.TwoWay });

                AddColum(dataGrid, column, factory, 0, true);



                column = new DataGridTemplateColumn();

                AddColumnHeaderStyle(column, "Freight");

                factory = new FrameworkElementFactory(typeof(TextBox));
                //factory.SetValue(TextBox.StyleProperty, Application.Current.Resources["overrideTextBoxStyle"]);
                factory.SetBinding(TextBox.TextProperty, new System.Windows.Data.Binding("Freight") { UpdateSourceTrigger = UpdateSourceTrigger.LostFocus, StringFormat = "{0:c}", Mode = BindingMode.TwoWay });
                factory.SetValue(TextBox.MaxLengthProperty, 20);
                factory.SetValue(TextBoxHelper.SelectAllOnFocusProperty, true);
                factory.AddHandler(PreviewTextInputEvent, new TextCompositionEventHandler(IsDouble));

                AddColum(dataGrid, column, factory, 0, true);



                column = new DataGridTemplateColumn();
                column.Width = DataGridLength.Auto;
                column.IsReadOnly = true;
                AddColumnHeaderStyle(column, "Total");

                factory = new FrameworkElementFactory(typeof(TextBlock));
                factory.SetBinding(TextBlock.TextProperty, new System.Windows.Data.Binding("TotalPrice") { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, StringFormat = "{0:c}", Mode = BindingMode.TwoWay });

                AddColum(dataGrid, column, factory, 0, true);

            }
        }

        private void AddColum(FullItemDataGrid dataGrid, DataGridTemplateColumn column, FrameworkElementFactory factory, int newIndex, bool moveToEnd = false)
        {
            column.CellTemplate = new DataTemplate { VisualTree = factory };
            dataGrid.Columns.Add(column);
            int columnIndex = dataGrid.Columns.IndexOf(column);

            if (!moveToEnd)
                dataGrid.Columns.Move(columnIndex, newIndex);
        }

        private void AddColumnHeaderStyle(DataGridTemplateColumn column ,string headerName)
        {
            column.Header = headerName;
            column.CanUserResize = false;
            column.HeaderStyle = (Style)Application.Current.Resources["ColumnHeaderStyle"];
        }

        public ObservableCollection<DataGridColumn> MyColumns
        {
            get { return (ObservableCollection<DataGridColumn>)GetValue(MyColumnsProperty); }
            set { SetValue(MyColumnsProperty, value); }
        }

        private void NumericUpDown_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void IsDouble(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !DoubleValidator(e.Text, sender as TextBox);
        }

        private static bool DoubleValidator(string text, TextBox box)
        {
            string k = Regex.Replace((box.Text + text).Trim().Replace(" ", string.Empty), "[0-9]", string.Empty);
            if (k == "..")
            {
                return false;
            }
            Regex regex = new Regex("[^0-9.]");
            return !regex.IsMatch(text);
        }


        private static void OnMyColumnsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //var dataGrid = d as MyDataGrid;
            //if (dataGrid == null || e.NewValue == null) return;

            //dataGrid.Columns.Clear();

            //foreach (DataGridColumn column in (ObservableCollection<DataGridColumn>)e.NewValue)
            //{
            //    if (!dataGrid.Columns.Contains(column))
            //    {
            //        dataGrid.Columns.Add(column);
            //    }

            //    if (!dataGrid.MyColumns.Contains(column))
            //    {
            //        dataGrid.MyColumns.Add(column);
            //    }
            //}
        }
    }


}
