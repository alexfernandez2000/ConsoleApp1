﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Baraja
{
    public class Deck
    {
        public List<Card> Cards {get; set; }
        private readonly List<Card.eSuit> _spanishDeck=new List<Card.eSuit>(){Card.eSuit.Batons,Card.eSuit.Swords,Card.eSuit.Cups, Card.eSuit.Gold };
        private readonly List<Card.eSuit> _pokerDeck = new List<Card.eSuit>() { Card.eSuit.Diamonds,Card.eSuit.Clubs,Card.eSuit.Hearts,Card.eSuit.Spades };
        public Deck()
        {
            Cards=new List<Card>();
        }

        public Deck PokerDeck()
        {
            Cards = new List<Card>();
            foreach (Card.eSuit suit in _pokerDeck)
                for (int i = 2; i < 15; i++)
                    Cards.Add(new Card(i, suit));
            return this;

        }
        public Deck SpanishDeck()
        {
            Cards=new List<Card>();
            foreach (Card.eSuit suit in _spanishDeck)
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

        public override string ToString()
        {
            string result="Cards:";

            foreach (Card card in Cards)
                result += $"\n {card.ToString()}";

            return result;
        }
    }
}
