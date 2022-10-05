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
    /// Логика взаимодействия для ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public static int rightAnswersCounter = 0;
        public static int notRightAnswersCounter = 0;
        public ResultWindow()
        {
            InitializeComponent();
            rightAnswers.Content = rightAnswersCounter;
            notRightAnswers.Content = notRightAnswersCounter;

            rightAnswersCounter = 0;
            notRightAnswersCounter = 0;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
