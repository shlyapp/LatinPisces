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
        private string _pathToDict;

        public AddCardPage()
        {
            InitializeComponent();
        }

        private void AddCard(object sender, RoutedEventArgs e)
        {
            if (NameTextBlock.Text != null && TranslationTextBlock.Text != null && _path != null)
            {

                Card card = new Card(NameTextBlock.Text, TranslationTextBlock.Text, _path, TranscriptionTextBlock.Text);
                if (_pathToDict != null)
                {
                    card.PathToDictionary = _pathToDict;
                }

                if (card.PathToDictionary != null)
                {
                    Data.AddCard(card);

                    MessageBox.Show("Новая карточка успешна добавлена!");
                }
                else
                {
                    MessageBox.Show("Нет словаря по умолчанию или специального словаря!");
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность заполнения полей.");
            }


            NavigationService.GoBack();

        }

        private void OpenFileDialog(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.png, *.jpg)|*.png;*.jpg";

            if (openFileDialog.ShowDialog() == true)
            {
                _path = openFileDialog.FileName;
            }
        }

        private void AddDictionaryFile(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                _pathToDict = openFileDialog.FileName;
            }
        }
    }
}
