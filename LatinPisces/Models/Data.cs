using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinPisces.Models
{
    internal class Data
    {
        private static ApplicationContext db { get; set; }

        private static List<Card> _cards { get; set; }

        static Data()
        {
            db = new ApplicationContext();

            db.Database.EnsureCreated();
            db.Cards.Load();

            _cards = db.Cards.Local.ToList();
        }

        public static void AddCard(Card card)
        {
            db.Cards.Add(card);
            _cards.Add(card);
            db.SaveChanges();
        }

        public static void RemoveCard(Card card)
        {
            db.Cards.Remove(card);
            _cards.Remove(card);
            db.SaveChanges();
        }

        public static List<Card> GetCards()
        {
            return _cards;
        }

    }
}
