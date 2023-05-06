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
            // retur AS if value equal 1
            if (value == 1) return "AS";
            // retur Walet if value equal 11
            if (value == 11) return "Walet";
            // retur Dama if value equal 12
            if (value == 12) return "Dama";
            // retur Król if value equal 13
            if (value == 13) return "Król";
            //Otherwise return value as string
            return value.ToString();
        }
    }
}
