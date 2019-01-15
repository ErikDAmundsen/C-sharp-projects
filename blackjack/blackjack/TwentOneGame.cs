using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play ()// begin a game
        {

            Dealer = new TwentyOneDealer();

            foreach (Player player in Players)//dea;
            {
                player.Hand = new List<Card>();
                player.Stay = false;

            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)//begin betting
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool succesfullyBet = player.Bet(bet);
                if (!succesfullyBet)
                {
                    return;

                }
                Bets[player] = bet;

            }

            for (int i = 0; i< 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Player)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i ==1)
                    {

                    }
                }

            }
        }

        public override void ListPlayers()
        {


            Console.WriteLine("21 Players:");
            base.ListPlayers();
}
            public void WalkAway(Player player)
            {
            throw new NotImplementedException();

            }
        
    }
}
