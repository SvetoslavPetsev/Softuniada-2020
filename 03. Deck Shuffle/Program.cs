using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Deck_Shuffle
{
    class Program
    {
        static void Main()
        {
            int cardNumber = int.Parse(Console.ReadLine());
            List<int> cards = new List<int>();

            for (int i = 1; i <= cardNumber; i++)
            {
                cards.Add(i);
            }

            int[] IndexesOfSplit = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < IndexesOfSplit.Length; i++)
            {
                int currIndex = IndexesOfSplit[i];

                if (currIndex < 0 && currIndex >= cards.Count)
                {
                    continue;
                }

                List<int> leftDeck = new List<int>();
                List<int> rightDeck = new List<int>();

                for (int j = 0; j < cards.Count; j++)
                {
                    if (j < currIndex)
                    {
                        leftDeck.Add(cards[j]);
                    }
                    else
                    {
                        rightDeck.Add(cards[j]);
                    }
                }

                List<int> temp = new List<int>();
                for (int k = 0; k < cards.Count; k++)
                {
                    if (k % 2 == 0 && leftDeck.Count > 0 || rightDeck.Count == 0)
                    {
                        temp.Add(leftDeck[0]);
                        leftDeck.RemoveAt(0);
                    }
                    else
                    {
                        temp.Add(rightDeck[0]);
                        rightDeck.RemoveAt(0);
                    }
                }
                cards = temp;
            }
            Console.WriteLine(string.Join(" ", cards));
        }
    }
}
