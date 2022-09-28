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
    /// Логика взаимодействия для AddCardPage.xaml
    /// </summary>
    public partial class AddCardPage : Page
    {
        public AddCardPage()
        {
            InitializeComponent();
        }

        private void AddCard(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = new ApplicationContext();

            db.Database.EnsureCreated();
            db.Cards.Load();

            Card card = new Card(NameTextBlock.Text, TranslationTextBlock.Text, "null", TranscriptionTextBlock.Text);
            db.Cards.Add(card);
            db.SaveChanges();
        }
    }
}
