using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
    internal class Program
    {
        private static Dictionary<string, Deck> _players = new Dictionary<string, Deck>();
        private static Deck _mainDeck = new Deck();

        static void Main(string[] args)
        {
            new SpanishGame().StartPlay();
        }

    }
}
