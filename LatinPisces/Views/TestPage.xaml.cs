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

namespace LatinPisces.View
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {

        private int i = 0;

        public TestPage()
        {
            InitializeComponent();
            LoadTest();
        }

        private void LoadTest()
        {
            RefreshButtons();
        }

        private void GiveAnswer(object sender, RoutedEventArgs e)
        {
            

            Button button = sender as Button;

            if (button.Content == Data.GetCards()[i].Translation)
            {
                MessageBox.Show("Верный ответ!");
            }
            else
            {
                MessageBox.Show("Неверный ответ!");
            }

            i++;
            if (i == Data.GetCards().Count)
            {
                NavigationService.GoBack();
            }
            else
            {
                RefreshButtons();
            }
            
        }

        private void RefreshButtons()
        {
            CardImage.Source = BitmapFrame.Create(new Uri(Data.GetCards()[i].Path));

            List<string> asnwers = Logic.GetRandomAnswers(Data.GetCards()[i]);
            IEnumerable<Button> collection = grid.Children.OfType<Button>();
            int j = 0;
            foreach (Button button in collection)
            {
                button.Content = asnwers[j];
                j++;
            }
        }
    }
}
