using Blackjack.BLL.Enums;

namespace Blackjack.BLL
{
    public class Card
    {
        public bool IsFaceUp { get; set; }
        public Suite Suite { get; }
        public Value Value { get; }

        public Card(Suite suite, Value value)
        {
            Suite = suite;
            Value = value;
        }

        public override string ToString() => $"{Value.ToString()} of {Suite.ToString()}";
    }
}
