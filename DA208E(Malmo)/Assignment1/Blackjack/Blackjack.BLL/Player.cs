using System;

namespace Blackjack.BLL
{
    public class Player
    {
        public static Guid PlayerId { get; private set; }
        public Hand Hand { get; set; }
        public virtual bool IsFinished { get; private set; }
        public bool IsThick => Hand.Score > 21;

        public Player()
        {
            PlayerId = Guid.NewGuid();
        }

        public void Reset()
        {
            Hand = new Hand();
        }

        public void Finish() => IsFinished = true;

        public override string ToString()
        {
            return IsThick ? "Thick" : Hand.Score.ToString();
        }
    }
}
