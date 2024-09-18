using System;
using System.Collections.Generic;
using System.Linq;
namespace Baraja
{
    public class Deck
    {
        public List<Card> Cards {get; set; }

        public Deck()
        {
            Cards=new List<Card>();
        }
        public Deck SpanishDeck()
        {
            Cards=new List<Card>();
            foreach (Card.eSuit suit in Enum.GetValues(typeof(Card.eSuit)))
                if (suit != Card.eSuit.Jocker)
                    for (int i = 1; i < 13; i++)
                        Cards.Add(new Card(i, suit));
            Cards.Add(new Card(13,Card.eSuit.Jocker));
            Cards.Add(new Card(13, Card.eSuit.Jocker));
            return this;
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

            List<Card> shuffledList = Cards.OrderBy(x => random.Next()).ToList();
            Cards=shuffledList;
        }

        public Card RandomStoleCard()
        {
            Random random = new Random();
            return StoleAtPosition(random.Next(0, Cards.Count - 1));
        }

        public Card StoleAtPosition(int position)
        {
            if (Cards.Count == 0 || Cards.Count<position)
                return null;

            Card card = Cards[position];
            Cards.Remove(card);
            return card;
        }

    }
}
