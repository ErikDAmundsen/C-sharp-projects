using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace blackjack
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\The Tech Academy\Desktop\Log.txt", true))
            {
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);
        }

    }
}
//string text =  File.ReadAllText(@"C:\Users\The Tech Academy\Desktop\Log.txt");