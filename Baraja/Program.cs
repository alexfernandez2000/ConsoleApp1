using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
    internal class Program
    {
        /// <summary>
        /// Robar carta
        /// Barajar
        /// Robar al azar
        /// Robar en posicion N
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card card = deck.StoleCard();
            card = deck.RandomStoleCard();
            card = deck.StoleAtPosition(0);
            deck.MixDeck();
            card = deck.StoleCard();
        }
        
    }
}
