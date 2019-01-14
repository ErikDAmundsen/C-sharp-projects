using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{ 
  public  struct Card
    {

     
        public Suit Suit { get; set; }
        public string Face { get; set; }

    }

    public enum Suit
    {
Clubs,
Diamonds,
Hearts,
Spades

    }
    public enum Face
    {
        two,
        three,
        four,
        five,
       six,
       seven,
       eight,
       nine,
       ten,
       jack,
       queen,
       king,
       ace
    }
}
