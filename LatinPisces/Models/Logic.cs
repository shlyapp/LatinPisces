using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LatinPisces.Models
{
    internal static class Logic
    {
        public static Dictionary<String, String> GetRandomAnswers(Card card)
        {
            Random rand = new Random();

            Dictionary<String, String> wrongAnswers = card.GetWrongAnswers();

            //foreach (var answer in wrongAnswers)
            //{
            //    if (answer.Key.St == card.Latin)
            //    {
            //        MessageBox.Show("Повторение!");
            //    }
            //}

            var shuffledDictionary = wrongAnswers.OrderBy(x => rand.Next()).Take(4).ToDictionary(item => item.Key, item => item.Value);

            //if (card.GetWrongAnswers().ContainsKey(shuffledDictionary.ElementAt(1).Key))
            //{
            //    MessageBox.Show("Повторение!");
            //}

            while (shuffledDictionary.ContainsKey(card.Latin))
            {
                shuffledDictionary = card.GetWrongAnswers().OrderBy(x => rand.Next()).Take(4).ToDictionary(item => item.Key, item => item.Value);
            }
            

            shuffledDictionary.Add(card.Latin, card.Russian);

            return shuffledDictionary.OrderBy(x => rand.Next()).Take(5).ToDictionary(item => item.Key, item => item.Value);
        }
    }
}
