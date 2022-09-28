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

using LatinPisces.Models;
using Microsoft.EntityFrameworkCore;

namespace LatinPisces.View
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();


            ApplicationContext db = new ApplicationContext();

            db.Database.EnsureCreated();
            db.Cards.Load();

            Card card = new Card("2", "2", "2", "2");
            db.Cards.Add(card);
            db.SaveChanges();

        }

        private void startTest(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestPage());
        }

        private void openSettings(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingsPage());
        }
    }
}
