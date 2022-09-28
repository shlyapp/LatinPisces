using LatinPisces.Models;
using Microsoft.EntityFrameworkCore;
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

namespace LatinPisces.Views
{
    /// <summary>
    /// Логика взаимодействия для AddCardPage.xaml
    /// </summary>
    public partial class AddCardPage : Page
    {

        private string _path;

        public AddCardPage()
        {
            InitializeComponent();
        }

        private void AddCard(object sender, RoutedEventArgs e)
        {
            try
            {
                ApplicationContext db = new ApplicationContext();

                db.Database.EnsureCreated();
                db.Cards.Load();

                Card card = new Card(NameTextBlock.Text, TranslationTextBlock.Text, _path, TranscriptionTextBlock.Text);
                db.Cards.Add(card);
                db.SaveChanges();

                MessageBox.Show("Новая карточка успешна добавлена!");
                NavigationService.GoBack();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность заполнения полей.");
            }
            
        }

        private void OpenFileDialog(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.png)|*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                _path = openFileDialog.FileName;
            }
        }
    }
}
