using System.Collections.Generic;

namespace Blackjack.BLL
{
    public class Game
    {
        private List<Player> _players;
        private Deck _deck;
        public Player Dealer { get; private set; }
        public Player Player { get; set; }

        public Game()
        {
            _players = new List<Player>();
            _deck = new Deck();
        }
        public void Start(int numberOfPlayers, int numberOfDecks)
        {
            _players.Clear();
            _players.AddRange(Player.New(numberOfPlayers));
            _deck.Shuffle(numberOfDecks);
            Dealer = new Dealer();

            Initialize();
        }

        public string NextPlayer()
        {
            Player = _players[_players.IndexOf(Player) == _players.Count - 1 ? 0 : _players.IndexOf(Player) + 1];
            
            return Player.ToString();
        }

        private void Initialize()
        {
            Player = _players[0];

            foreach (var p in _players)
            {
                Draw();
                Draw();

                NextPlayer();
            }


            Draw(true); // Draw two cards for dealer
            Draw(true);
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
