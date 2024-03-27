﻿using System;
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

namespace Orion.UI.View
{
    /// <summary>
    /// Interaction logic for ProjectInformationView.xaml
    /// </summary>
    public partial class ProjectInformationView : UserControl
    {
        public ProjectInformationView()
        {
            InitializeComponent();
        }

        private void NumericUpDown_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void NoSlashInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Contains("/"))
            {
                e.Handled = true; // Cancela la entrada del texto
            }
        }
    }
}
