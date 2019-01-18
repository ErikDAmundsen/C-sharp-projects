using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.blackjack;
namespace blackjack
{
   public class Program
    {
        static void Main(string[] args)
        {

            const string casinoName = "Grand Hotel and casino";
            Guid identifier =  Guid.NewGuid();

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer =="yeah" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\The Tech Academy\Desktop\Log.txt", true))
                {
                    file.WriteLine(player.Id);
                

                }
                Game game = new TwentyOneGame();
                game += player;

                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance >0 )
                {
                    game.Play();

                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
                Console.WriteLine("Feel free to look arround the casino. Bye for now.");
                Console.ReadLine();
            }
            


            Console.ReadLine();

        }

        
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);


        //    }
        //    return deck;

        //}
    }
}
