using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Orion.UI.View.ABB.EditCatalogItem
{
    /// <summary>
    /// Interaction logic for EditB2CatalogView.xaml
    /// </summary>
    public partial class EditB2CatalogView : UserControl
    {
        public EditB2CatalogView()
        {
            InitializeComponent();
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
    }
}
