using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Media.Imaging;
using QuickPoker.Properties;

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