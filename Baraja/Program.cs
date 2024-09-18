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

            _mainDeck = new Deck().SpanishDeck();
            _mainDeck.MixDeck();
            AskPlayers();
            DealingCards();
            while (true)
            {
                PlayRound(_players.Select(x=>x.Key).ToList());
               List<string> playersToDelete= _players.Where(x => x.Value.Cards.Count == 0).Select(kvp => kvp.Key).ToList();
               
               foreach (string player in playersToDelete)
                   _players.Remove(player);

                if (_players.Count == 1)
                {
                    Console.WriteLine($"Winner: {_players.FirstOrDefault().Key}");
                    break;
                }
            }

            Console.ReadKey();
        }

        private static string PlayRound(List<string>players)
        {
            Dictionary<string, Card> playedCards=new Dictionary<string, Card>();

            foreach (var player in players)
                playedCards.Add(player,_players[player].StoleCard());
            int maxCardValue = playedCards.Max(x => x.Value== null? -1 : x.Value.Number);

            List<string> winners = playedCards.Where(x => (x.Value == null ? -1 : x.Value.Number) == maxCardValue).Select(x=>x.Key).ToList();
            
            if (winners.Count > 1)
            {
               string remachWinner = PlayRound(winners);
                winners.RemoveAll(x=>x!=remachWinner);
            }

            string winner = winners.FirstOrDefault();

            foreach (var playedCard in playedCards)
                if (playedCard.Value!=null)
                    _players[winner].Cards.Add(playedCard.Value);

            return winner;
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

           while (playerNumber>0)
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
