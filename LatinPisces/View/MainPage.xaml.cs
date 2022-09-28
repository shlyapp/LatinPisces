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

using LatinPisces.Model;

namespace LatinPisces.View
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        ApplicationContext db;

        public MainPage()
        {
            InitializeComponent();

            db = new ApplicationContext();
            TestDataBase();
        }

        private void startTest(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestPage());
        }

        private void openSettings(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingsPage());
        }

        private void TestDataBase()
        {
            db.Cards.Add(new Card("1", "1", "1", "1"));
            db.SaveChanges();
        }
    }
}
