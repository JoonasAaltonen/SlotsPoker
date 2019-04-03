using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace QuickPoker
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>(54);      // 52 cards + 2 jokers
        private Random r = new Random();

        public Deck()
        {
            CreateDeck();
           // PrintDeck();
        }

        private void CreateDeck()
        {
            int cardNumber = 0;
            // Loop through suits
            foreach (int suit in Enum.GetValues(typeof(CardAttributes.Suit)))
            {
                int cardValue = 0;
                // Loop through values of each suit, don't add Jokers
                foreach (int value in Enum.GetValues(typeof(CardAttributes.Value)))
                {
                    if (suit != (int)CardAttributes.Suit.Jokers && cardValue > (int)CardAttributes.Value.Ace)
                    {
                        break;
                    }
                    if (suit == (int)CardAttributes.Suit.Jokers && value <= (int)CardAttributes.Value.Ace)
                    {
                        continue;
                    }
                    _cards.Add(new Card { CardSuit = (CardAttributes.Suit)suit, CardValue = (CardAttributes.Value)value } ); 
                        
                    cardNumber++;
                    cardValue++;
                }
            }
        }

        private void PrintDeck()
        {
            {
                foreach (var card in _cards)
                {
                    card.ShowCard();
                }
            }
        }

        public Card TakeCard()
        {
            int index = r.Next() % _cards.Count;

            Card takenCard = _cards[index];
            _cards.RemoveAt(index);
            return takenCard;
        }
    }
}