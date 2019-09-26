using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Blackjack.BLL
{
    public class Hand
    {
        private List<Card> _cards;

        public Card LastCard { get; set; }
        public int NumberOfCards => _cards.Count;
        public int Score => _cards.Select(c => (int)c.Value).BlackjackSum();

        public Hand()
        {
            _cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
            LastCard = card;
        }

        public void Clear() => _cards.Clear();

        public override string ToString() => string.Join(", ", _cards);
    }
}
