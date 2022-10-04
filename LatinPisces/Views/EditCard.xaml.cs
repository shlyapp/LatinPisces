using LatinPisces.Models;
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
    /// Логика взаимодействия для EditCard.xaml
    /// </summary>
    public partial class EditCard : Page
    {
        private string _path;
        private string _pathToDict;
        private Card _card;

        public EditCard(Card card)
        {
            InitializeComponent();
            _card = card;

            LatinTextBlock.Text = _card.Latin;
            RussianTextBlock.Text = _card.Russian;
            TranscriptionTextBlock.Text = _card.Transcription;
            _path = _card.Path;
            _pathToDict = _card.PathToDictionary;
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

        private void CanselChange(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CardChange(object sender, RoutedEventArgs e)
        {
            Data.RemoveCard(_card);
            Card newCard = new Card(LatinTextBlock.Text, RussianTextBlock.Text, _path, TranscriptionTextBlock.Text);
            newCard.PathToDictionary = _pathToDict;
            Data.AddCard(newCard);
            NavigationService.GoBack();
        }
    }
}
