using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class CardShark
    {
        //A standard deck of cards is represented as an array. Each card is represented as an integer. Write a method to shuffle the cards.
        //n represents the number of cards to shuffle (we are shuffling all 52)
        public void ShuffleCards(int[] deck, int n)
        {
            //Random class represents a random number generator
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                //r will calculate random for remaining posiions
                int r = i + random.Next(52 - i);

                //swapping cards at random position and at position i
                int temp = deck[r];
                deck[r] = deck[i];
                deck[i] = temp;
            }
        }
    }
}
