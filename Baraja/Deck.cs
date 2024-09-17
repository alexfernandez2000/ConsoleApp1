using System;
using System.Collections.Generic;
using System.Linq;

namespace Baraja
{
    public class Deck
    {
        private List<Card> cards;

        public List<Card> Cards {get { return cards; }set { cards= value; } }

        public Deck()
        {
                
        }

        public Deck(List<Card>cards)
        {
            Cards=cards;
        }

        public Card StoleCard()
        {
            return StoleAtPosition(0);
        }
        public void MixDeck()
        {
            Random random = new Random();

            List<Card> shuffledList = cards.OrderBy(x => random.Next()).ToList();
        }

        public Card RandomStoleCard()
        {
            Random random = new Random();
            return StoleAtPosition(random.Next(0, cards.Count - 1));
        }

        public Card StoleAtPosition(int position)
        {
            if (cards.Count == 0)
                return null;

            Card card = Cards[position];
            cards.Remove(card);
            return card;
        }

    }
}
