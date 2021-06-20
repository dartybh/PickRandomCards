using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {
        private static Random random = new Random();

        public static string[] pickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);

            switch (value)
            {
                case 1:
                    return "Diamonds";

                case 2:
                    return "Hearts";

                case 3:
                    return "Spades";

                default:
                    return "Clubs";
            }
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            switch (value)
            {
                case 1:
                    return "Ace";

                case 11:
                    return "Jack";

                case 12:
                    return "Queen";

                case 13:
                    return "King";

                default:
                    return value.ToString();
            }
        }

      
    }
}