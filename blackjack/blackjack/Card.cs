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
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
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
