using System;
using System.Linq;
using System.Windows;

namespace QuickPoker
{
    public class Deck
    {
        private Card[] _cards = new Card[54];   // 52 cards + 2 jokers

        public Deck()
        {
            CreateDeck();
            PrintDeck();
        }

        private void CreateDeck()
        {
            int i = 0;
            foreach (int suit in Enum.GetValues(typeof(CardAttributes.Suit)))
            {
                Console.WriteLine("Suit = {0}", suit);
                foreach (int value in Enum.GetValues(typeof(CardAttributes.Value)))
                {
                    Console.WriteLine("Value = {0}", value);
                    if (suit != (int)CardAttributes.Suit.Jokers && i > (int)CardAttributes.Value.Ace)
                    {
                        break;
                    }
                    if (suit == (int) CardAttributes.Suit.Jokers && value <= (int)CardAttributes.Value.Ace)
                    {
                        continue;
                    }
                    _cards[i] = 
                        new Card() { CardSuit = (CardAttributes.Suit)suit, CardValue = (CardAttributes.Value)value };
                    i++;
                }
            }
        }

        private void PrintDeck()
        {
            {
                foreach (var VARIABLE in _cards)
                {
                    VARIABLE.ShowCard();
                }
            }
        }
    }
}