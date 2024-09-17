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
            Cards=new List<Card>();
            foreach (Card.eSuit suit in Enum.GetValues(typeof(Card.eSuit)))
                if (suit != Card.eSuit.Jocker)
                    for (int i = 1; i < 13; i++)
                        Cards.Add(new Card(i, suit));
            Cards.Add(new Card(13,Card.eSuit.Jocker));
            Cards.Add(new Card(13, Card.eSuit.Jocker));
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
            Cards=shuffledList;
        }

        public Card RandomStoleCard()
        {
            Random random = new Random();
            return StoleAtPosition(random.Next(0, cards.Count - 1));
        }

        public Card StoleAtPosition(int position)
        {
            if (cards.Count == 0 || cards.Count<position)
                return null;

            Card card = Cards[position];
            cards.Remove(card);
            return card;
        }

    }
}
