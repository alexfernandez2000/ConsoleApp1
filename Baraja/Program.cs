using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
    internal class Program
    {
        private Dictionary<string, Deck> Players = new Dictionary<string, Deck>();
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card card = deck.StoleCard();
            card = deck.RandomStoleCard();
            card = deck.StoleAtPosition(60);
            deck.MixDeck();
            card = deck.StoleCard();
        }
        
    }
}
