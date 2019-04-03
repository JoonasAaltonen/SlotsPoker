﻿using System;
using System.Collections.Generic;
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
        private Deck _deck;

        public GameBoard()
        {
            InitializeComponent();
            InitTable();
            _deck = new Deck();
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
                    Margin = new Thickness(15, 15, 15, 15)
                };
                BackGroundGrid.Children.Add(testLabel);
            }
        }
    }
}
