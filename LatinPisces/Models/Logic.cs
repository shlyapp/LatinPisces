using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinPisces.Models
{
    internal static class Logic
    {
        public static List<string> GetRandomAnswers(Card card)
        {
            var random = new Random();
            List<string> answers = card.GetWrongAnswers().OrderBy(s => random.Next()).Take(4).ToList();
            answers.Add(card.Translation);

            return answers.OrderBy(s => random.Next()).Take(5).ToList();
        }
    }
}
