using LatinPisces.Models;
using LatinPisces.Views;
using Microsoft.Win32;
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

namespace LatinPisces.View
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void AddCard(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCardPage());
        }

        private void ShowCards(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CardsPage());
        }

        private void AddDefaultDictionary(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                Card.AddDefaultDictionary(openFileDialog.FileName);
            }
        }
    }
}
