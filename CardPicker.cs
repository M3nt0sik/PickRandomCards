using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
     class CardPicker
    {
         static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] PickedCards = new string[numberOfCards];
            for(int i = 0; i<numberOfCards; i++)
            {
                PickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return PickedCards;
        }

        private static string RandomSuit()
        {
            //take random values from 1 to 4
            int value = random.Next(1, 5);
            //if value is 1 return pik
            if (value == 1) return "pik";
            //if value is 2 return kier
            if (value == 2) return "kier";
            //if value is 3 return trefl
            if (value == 3) return "trefl";
            //otherwise return karo
            return "karo";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "AS";
            if (value == 11) return "Walet";
            if (value == 12) return "Dama";
            if (value == 13) return "Król";
            return value.ToString();
        }
    }
}
