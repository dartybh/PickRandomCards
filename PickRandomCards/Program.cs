using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string value = Console.ReadLine();
            
            if (int.TryParse(value, out int numberOfCards) && Convert.ToInt32(value) >= 0)
            {
                foreach (string card in CardPicker.pickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }

            else
            {
                Console.WriteLine("Invalid input: Please use positive numerical values only.");
            }
        }
    }
}
