using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Orion.UI.View
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void mainControler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.OriginalSource is MetroAnimatedSingleRowTabControl)
            {
                if ((e.OriginalSource as MetroAnimatedSingleRowTabControl).Name != "menuControler")
                {
                    e.Handled = true;
                }
            }
            else if (e.OriginalSource is DataGrid)
            {
                e.Handled = true;
            }
            else if (e.OriginalSource is ComboBox)
            {
                e.Handled = true;
            }
        }
    }
}
