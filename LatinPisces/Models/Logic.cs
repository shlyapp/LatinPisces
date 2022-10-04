using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinPisces.Models
{
    internal static class Logic
    {
        public static Dictionary<String, String> GetRandomAnswers(Card card)
        {
            var random = new Random();
            Random rand = new Random();
            var shuffledDictionary = card.GetWrongAnswers().OrderBy(x => rand.Next()).Take(4).ToDictionary(item => item.Key, item => item.Value);
            shuffledDictionary.Add(card.Latin, card.Russian);

            return shuffledDictionary.OrderBy(x => rand.Next()).Take(5).ToDictionary(item => item.Key, item => item.Value);
        }
    }
}
