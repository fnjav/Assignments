using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack.BLL
{
    public class Player
    {
        public string PlayerId { get; private set; }
        public Hand Hand { get; set; }
        public virtual bool IsFinished { get; private set; }
        public bool IsThick => Hand.Score > 21;
        public static List<Player> New(int amount)
        {
            var players = new List<Player>();

            for (var i = 0; i < amount; i++)
                players.Add(new Player());

            return players;
        }

        public Player()
        {
            PlayerId = Guid.NewGuid().ToString().Substring(0, 5);
            Hand = new Hand();
        }

        public void Reset()
        {
            Hand = new Hand();
        }

        public void Finish() => IsFinished = true;

        public override string ToString() => $"Player: {PlayerId}\nScore: {Hand.Score}\n{Hand.ToString()}";

    }
}
