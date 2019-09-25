using Blackjack.BLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Blackjack.BLL
{
    public class Deck
    {
        private readonly List<Card> _cards;
        private int _initialSize;
        public bool IsTimeToReshuffle => _cards.Count <= _initialSize * 0.25;
        public bool IsEmpty => _cards.Count == 0;

        public Deck()
        {
            _cards = new List<Card>();
            Shuffle();
        }

        public Card Draw() => _cards.Pop();

        public void Shuffle(int numberOfDecks = 1)
        {
            _cards.Clear(); // Don't keep old cards

            var cards = new List<Card>();

            _initialSize = cards.Count; // Total amount of cards to be added

            for (var i = 0; i < numberOfDecks; i++)
                cards.AddRange(CreateDeck());

            _cards.AddRange(cards.OrderBy(c => Guid.NewGuid())); // GUIDs are often unique
        }

        private List<Card> CreateDeck()
        {
            var deck = new List<Card>();

            foreach (var suite in Enumerable.Range(1, 4))
                foreach (var value in Enumerable.Range(1, 52))
                    deck.Add(new Card((Suite)suite, (Value)value));

            return deck;
        }

    }
}
