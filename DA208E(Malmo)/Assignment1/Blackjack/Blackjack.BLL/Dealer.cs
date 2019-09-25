namespace Blackjack.BLL
{
    public class Dealer : Player
    {
        public override bool IsFinished => Hand.Score > 16;
    }
}
