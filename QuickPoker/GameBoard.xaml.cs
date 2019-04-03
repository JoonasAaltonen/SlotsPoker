using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuickPoker.Properties;
using Brushes = System.Windows.Media.Brushes;
using Image = System.Windows.Controls.Image;

namespace QuickPoker
{
    /// <summary>
    /// Interaction logic for GameBoard.xaml
    /// </summary>
    public partial class GameBoard : UserControl
    {
        private const int MaxCardsOnTable = 5;      // No more than 5 elements on grid at once
        private const int CardWidth = 150;
        private const int CardHeight = 215;     // Dimensions ratio 8 : 11.5, thus height = width / 8 * 11.5
        private Thickness CardMargin = new Thickness(15, 15, 15, 15);

        public GameBoard()
        {
            InitializeComponent();
            InitTable();
            GameLogic logic = new GameLogic(this);
        }

        private void InitTable()
        {
            BackGroundGrid.Background = Brushes.DarkGreen;
            BackGroundGrid.Children.Clear();

            for (int i = 0; i < MaxCardsOnTable; i++)
            {
                Label testLabel = new Label
                {
                    Background = Brushes.BlueViolet,
                    Width = CardWidth,
                    Height = CardHeight,
                    Margin = CardMargin
                };
                BackGroundGrid.Children.Add(testLabel);
            }
        }

        public void DealCards(Card[] hand)
        {
            BackGroundGrid.Children.Clear();

            for (int i = 0; i < MaxCardsOnTable; i++)
            {
                Image cardImage = new Image();
                cardImage.Source = hand[i].GetImage();
                cardImage.Width = CardWidth;
                cardImage.Height = CardHeight;
                BackGroundGrid.Children.Add(cardImage);
            }
        }
        
    }
}
