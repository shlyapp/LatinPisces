using LatinPisces.Models;
using Microsoft.EntityFrameworkCore;
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


namespace LatinPisces.Views
{
    /// <summary>
    /// Логика взаимодействия для CardsPage.xaml
    /// </summary>
    public partial class CardsPage : Page
    {
        public CardsPage()
        {
            InitializeComponent();

            CardList.ItemsSource = Data.GetCards();      
        }

        private void DeleteCard(object sender, RoutedEventArgs e)
        {
            //Button button = sender as Button;
            Image image = sender as Image;
            Card card = image.DataContext as Card;

            Data.RemoveCard(card);
            CardList.Items.Refresh();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void EditCard(object sender, MouseButtonEventArgs e)
        {
            Image button = sender as Image;
            Card card = button.DataContext as Card;
            NavigationService.Navigate(new EditCard(card));
            CardList.Items.Refresh();
        }
    }
}
