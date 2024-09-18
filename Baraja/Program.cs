using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
    internal class Program
    {
        private static Dictionary<string, Deck> _players = new Dictionary<string, Deck>();
        private static Deck _mainDeck = new Deck();
        private static Deck _playedDeck = new Deck();

        static void Main(string[] args)
        {
            _mainDeck = new Deck().SpanishDeck();
            AskPlayers();
            DealingCards();
            while
        }

        private static void DealingCards()
        {
            int cardsToDeal = _mainDeck.Cards.Count / _players.Count;
            foreach (var player in _players)
                for (int i = 0; i < cardsToDeal; i++)
                    player.Value.Cards.Add(_mainDeck.StoleCard());
        }

        private static void AskPlayers()
        { 
            Console.WriteLine("How many players want to play?");
           int playerNumber = GetInt();

           while (playerNumber<0)
           {
              string playerName = ReadConsoleWord("Player name:");

              _players.Add(playerName, new Deck());
               playerNumber--;
           }
        }
        private static int GetInt()
        {
            while (true)
            {
                if (int.TryParse(ReadConsoleWord("Insert number"), out int number))
                    return number;
                Console.WriteLine("Invalid number");
            }
        }
        private static string ReadConsoleWord(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

    }
}
