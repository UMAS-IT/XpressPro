using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Orion.UI.Service
{
    public class WindowService
    {
        public void EditItemsWndow(object viewModel, string title)
        {
            var win = new MetroWindow
            {
                Height = 700,
                MinHeight = 700,
                Width = 1000,
                MinWidth = 1000,
                TitleCharacterCasing = System.Windows.Controls.CharacterCasing.Normal,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.CanResizeWithGrip,
                WindowState = WindowState.Normal,
                Content = viewModel,
                ShowCloseButton = false,
                Title = title
            };
            win.ShowDialog();
        }

        public void AddInternalDoorWindow(object viewModel, string title)
        {
            var win = new MetroWindow
            {
                Height = 380,
                MinHeight = 380,
                Width = 250,
                MinWidth = 250,
                TitleCharacterCasing = System.Windows.Controls.CharacterCasing.Normal,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize,
                WindowState = WindowState.Normal,
                Content = viewModel,
                ShowCloseButton = false,
                Title = title
            };
            win.ShowDialog();
        }

        public void OpeningWindow(object viewModel, string title)
        {
            var win = new MetroWindow
            {
                Height = 565,
                MinHeight = 565,
                Width = 662,
                MinWidth = 662,
                TitleCharacterCasing = System.Windows.Controls.CharacterCasing.Normal,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize,
                WindowState = WindowState.Normal,
                Content = viewModel,
                ShowCloseButton = false,
                Title = title
            };
            win.ShowDialog();
        }

        public void ConfigurationMenuWindow(object viewModel, string title)
        {
            var win = new MetroWindow
            {
                Height = 700,
                MinHeight = 700,
                Width = 1200,
                MinWidth = 1200,
                TitleCharacterCasing = System.Windows.Controls.CharacterCasing.Normal,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.CanResizeWithGrip,
                WindowState = WindowState.Normal,
                Content = viewModel,
                ShowCloseButton = true,
                Title = title
            };
            win.ShowDialog();
        }

        public void InternalWallWindow(object viewModel, string title)
        {
            var win = new MetroWindow
            {
                Height = 366,
                MinHeight = 366,
                Width = 250,
                MinWidth = 250,
                TitleCharacterCasing = System.Windows.Controls.CharacterCasing.Normal,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize,
                WindowState = WindowState.Normal,
                Content = viewModel,
                ShowCloseButton = false,
                Title = title
            };
            win.ShowDialog();
        }

        public void NewProjectWindow(object viewModel, string title)
        {
            var win = new MetroWindow
            {
                Height = 500,
                MinHeight = 500,
                Width = 250,
                MinWidth = 250,
                TitleCharacterCasing = System.Windows.Controls.CharacterCasing.Normal,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize,
                WindowState = WindowState.Normal,
                Content = viewModel,
                ShowCloseButton = false,
                Title = title
            };
            win.ShowDialog();
        }

        public void OpenProjectWindow(object viewModel, string title)
        {
            var win = new MetroWindow
            {
                Height = 600,
                MinHeight = 600,
                Width = 900,
                MinWidth = 900,
                TitleCharacterCasing = System.Windows.Controls.CharacterCasing.Normal,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize,
                WindowState = WindowState.Normal,
                Content = viewModel,
                ShowCloseButton = false,
                Title = title
            };
            win.ShowDialog();
        }

        public void SelectFilterWindow(object viewModel, string title)
        {
            var win = new MetroWindow
            {
                Height = 500,
                MinHeight = 500,
                Width = 600,
                MinWidth = 600,
                TitleCharacterCasing = System.Windows.Controls.CharacterCasing.Normal,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize,
                WindowState = WindowState.Normal,
                Content = viewModel,
                ShowCloseButton = false,
                Title = title
            };
            win.ShowDialog();
        }
    }
}
