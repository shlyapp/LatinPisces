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

namespace LatinPisces.Views
{
    /// <summary>
    /// Логика взаимодействия для CardsPage.xaml
    /// </summary>
    public partial class CardsPage : Page
    {
        ApplicationContext db;
        List<Card> cards;
        public CardsPage()
        {
            InitializeComponent();

            db = new ApplicationContext();

            db.Database.EnsureCreated();
            db.Cards.Load();

             cards = db.Cards.Local.ToList();
            CardList.ItemsSource = cards;
            
            //CardsData.DataContext = db.Cards.Local.ToObservableCollection();
        }

        private void DeleteCard(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Card card = button.DataContext as Card;
            db.Cards.Local.Remove(card);
            cards.Remove(card);
            CardList.Items.Refresh();
            db.SaveChanges();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
