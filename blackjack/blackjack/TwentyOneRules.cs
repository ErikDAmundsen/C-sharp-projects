using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
   public  class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.two] = 2,
            [Face.three] = 3,
            [Face.four ] = 4,
            [Face.five] = 5,
            [Face.six] = 6,
            [Face.seven] = 7,
            [Face.eight] =8,
             [Face.nine] =9,
            [Face.ten] = 10,
            [Face.jack] =10,
            [Face.queen] = 10,
            [Face.king]= 10,
            [Face.ace] = 1

        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
                    }
            for (int i = 1; i< result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;


            }
            return result;
        }

        public static bool CheckForBlackJack (List <Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;

        }
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;

        }
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value <22)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerscore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerscore > dealerScore) return true;
            else if (playerscore < dealerScore) return false;
            else return null;
        }

    }
}
