using System;

namespace QuickPoker
{
    public class GameLogic
    {
        private Deck _deck;
        private GameBoard _gameBoard;

        public GameLogic(GameBoard board)
        {
            _gameBoard = board;
            _deck = new Deck();
            DealCards();
        }
        

        private void DealCards()
        {
            Random r = new Random();
            Card[] hand = new Card[5];

            for (int i = 0; i < 5; i++)
            {
                hand[i] = _deck.TakeCard();
            }
            
            _gameBoard.DealCards(hand);
        }
    }
}