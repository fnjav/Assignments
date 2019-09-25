using System.Collections.Generic;

namespace Blackjack.BLL
{
    public class Game
    {
        private List<Player> _players;
        private Deck _deck;
        public Player Dealer { get; private set; }
        public Player Player { get; set; }

        public void Start(int numberOfPlayers, int numberOfDecks)
        {
            _players = new List<Player>();
            _deck = new Deck();
            Dealer = new Dealer();
            Initialize();
        }

        private string SetPlayer(Player player)
        {
            return player.ToString();
        }

        public string NextPlayer()
        {
            return string.Empty;
        }

        private void Initialize()
        {
            _deck.Shuffle();
            foreach (var p in _players)
            {
                NextPlayer();

                Draw();
                Draw();
            }


            Draw(true); // Draw two cards for dealer
            Draw(true);
        }

        private void InitializePlayers()
        {

        }

        private void InitializeDeck()
        {

        }

        public void Draw(bool isDealer = false)
        {
            if (isDealer)
            {
                Dealer.Hand.AddCard(_deck.Draw());
            }
            else
            {
                Player.Hand.AddCard(_deck.Draw());
            }
        }
    }
}
