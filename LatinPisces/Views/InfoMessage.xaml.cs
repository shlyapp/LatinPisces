using LatinPisces.Models;
using LatinPisces.View;
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
using System.Windows.Shapes;

namespace LatinPisces.Views
{
    /// <summary>
    /// Логика взаимодействия для InfoMessage.xaml
    /// </summary>
    public partial class InfoMessage : Window
    {
        public InfoMessage(Card card, Button button)
        {
            InitializeComponent();

            yourAnswer.Content = button.Content;
            rightAnswer.Content = card.Latin;
            translationLabel.Content = card.Russian;
            transcriptionLabel.Content = card.Transcription;

            if (button.Content == card.Latin || button.Content == card.Russian)
            {
                statusLabel.Content = "Верный ответ!";
                statusLabel.Foreground = Brushes.Green;
                ResultWindow.rightAnswersCounter++;
            }
            else
            {
                statusLabel.Content = "Неверный ответ!";
                statusLabel.Foreground = Brushes.Red;
                ResultWindow.notRightAnswersCounter++; ;
            }
        }

        private void CloseInfo(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
