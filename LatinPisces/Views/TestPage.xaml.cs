using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using LatinPisces.Views;

namespace LatinPisces.View
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {

        private int i = 0;
        private List<Card> _cards;
        private Dictionary<String, String> _wrongAnswers;

        public TestPage()
        {
            InitializeComponent();
            grid.Focus();

            Random r = new Random();
            _cards = Data.GetCards().OrderBy(x => r.Next()).ToList();

            isLatin.IsChecked = true;
            isRussian.IsChecked = false;

            LoadTest();
        }

        private void LoadTest()
        {
            RefreshButtons();
        }

        //private void AddTranscriprion(object sender, RoutedEventArgs e)
        //{
        //    IEnumerable<Button> collection = grid.Children.OfType<Button>();
        //    foreach (Button button in collection)
        //    {
        //        button.Content = $"{Data.GetCards()[i].Translation} - {Data.GetCards()[i].Transcription}";
        //    }
        //}

        private void GiveAnswer(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            //if (button.Content ==_cards[i].Latin || button.Content == _cards[i].Russian)
            //{
            //    MessageBox.Show($"Верный ответ!\nПеревод: {_cards[i].Russian}\nТранскрипция: {_cards[i].Transcription}");
            //}
            //else
            //{
            //    MessageBox.Show($"Неверный ответ!\nПравильно: {_cards[i].Latin}\nПеревод: {_cards[i].Russian}\nТранскрипция: {_cards[i].Transcription}");
            //}

            InfoMessage inf = new InfoMessage(_cards[i], button);
            inf.Show();

            i++;
            if (i == _cards.Count)
            {
                MessageBox.Show("Все тесты пройдены!");
                NavigationService.GoBack();
            }
            else
            {
                RefreshButtons();
            }
        }

        private void RefreshButtons()
        {
            isLatin.IsChecked = true;
            isRussian.IsChecked = false;

            CardImage.Source = BitmapFrame.Create(new Uri(_cards[i].Path));

            _wrongAnswers = Logic.GetRandomAnswers(_cards[i]);
            IEnumerable<Button> collection = grid.Children.OfType<Button>();
            int j = 0;

            foreach (var item in _wrongAnswers)
            {
                //collection.ElementAt(j).Content = item.Key;
                Button btn = collection.ElementAt(j) as Button;
                btn.Content = item.Key;
                j++;
            }
        }

        private void ChangeLanguage(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            IEnumerable<Button> collection = grid.Children.OfType<Button>();
            

            if (checkBox == isLatin)
            {
                isLatin.IsChecked = true;
                isRussian.IsChecked = false;
                int j = 0;
                foreach (var item in _wrongAnswers)
                {
                    //collection.ElementAt(j).Content = item.Key;
                    Button btn = collection.ElementAt(j) as Button;
                    btn.Content = item.Key;
                    j++;
                }
            }
            else
            {
                isRussian.IsChecked = true;
                isLatin.IsChecked = false;
                int j = 0;
                //foreach (Button button in collection)
                //{
                //    button.Content = _wrongAnswers.;
                //    j++;
                //}
                foreach (var item in _wrongAnswers)
                {
                    //collection.ElementAt(j).Content = item.Key;
                    Button btn = collection.ElementAt(j) as Button;
                    btn.Content = item.Value;
                    j++;
                }

            }
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                NavigationService.GoBack();
            }
        }
    }
}
