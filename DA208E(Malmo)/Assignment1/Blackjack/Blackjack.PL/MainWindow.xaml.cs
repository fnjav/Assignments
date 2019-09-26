using Blackjack.BLL;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Blackjack.PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Game Game { get; }
        public int NumberOfPlayers => int.TryParse(txtNumberOfPlayers.Text, out var value) ? value : throw new FormatException("That's not an integer!");
        public int NumberOfDecks => int.TryParse(txtNumberOfDecks.Text, out var value) ? value : throw new FormatException("That's not an integer!");

        public MainWindow()
        {
            InitializeComponent();
            Game = new Game();
        }

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            Game.Draw();
        }

        private void Stay_Click(object sender, RoutedEventArgs e)
        {
            Game.Player.Finish();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            Game.Start(NumberOfPlayers, NumberOfDecks);
        }

        private void NextPlayer_Click(object sender, RoutedEventArgs e)
        {
            lblPlayer.Content = Game.NextPlayer();
        }

        private void Reshuffle_Click(object sender, RoutedEventArgs e)
        {
            Game.Start(NumberOfPlayers, NumberOfDecks);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = (TextBox)sender;
            if (!Regex.IsMatch(textbox.Text, "^[1-9][0-9]*$") && textbox.Text.Length > 0)
            {
                textbox.Text = Regex.Replace(textbox.Text, "[^0-9]", string.Empty);
                textbox.CaretIndex = textbox.Text.Length;
            }
        }
    }
}
