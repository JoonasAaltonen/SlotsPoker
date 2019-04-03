using System;

namespace QuickPoker
{
    public class Card
    {

        public CardAttributes.Suit CardSuit;
        public CardAttributes.Value CardValue;

        public Card() {}

        public void ShowCard()
        {
            Console.WriteLine(CardValue + " of " + CardSuit);
        }
    }

    
}