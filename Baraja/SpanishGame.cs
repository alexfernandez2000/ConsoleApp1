using System;
using System.Collections.Generic;
using System.Linq;

namespace Baraja
{
    internal class SpanishGame
    {
        private Dictionary<string, Deck> _players = new Dictionary<string, Deck>();
        private Deck _mainDeck = new Deck();

        public void StartPlay()
        {
            _mainDeck = new Deck().SpanishDeck();
            _mainDeck.MixDeck();
            AskPlayers();
            DealingCards();
            while (true)
            {
                PlayRound(_players.Select(x => x.Key).ToList());
                RemoveLosers();
                if (_players.Count == 1)
                {
                    Console.WriteLine($"Winner: {_players.FirstOrDefault().Key}");
                    break;
                }
            }

            Console.ReadKey();
        }

        private void RemoveLosers()
        {
            List<string> playersToDelete = _players.Where(x => x.Value.Cards.Count == 0).Select(kvp => kvp.Key).ToList();

            foreach (string player in playersToDelete)
                _players.Remove(player);
        }
        private string PlayRound(List<string> players)
        {
            Dictionary<string, Card> playedCards = new Dictionary<string, Card>();

            foreach (var player in players)
                playedCards.Add(player, _players[player].StoleCard());

            int maxCardValue = playedCards.Max(x => x.Value == null ? -1 : x.Value.Number);

            List<string> winners = playedCards.Where(x => (x.Value == null ? -1 : x.Value.Number) == maxCardValue).Select(x => x.Key).ToList();

            if (winners.Count > 1)
            {
                string remachWinner = PlayRound(winners);
                winners.RemoveAll(x => x != remachWinner);
            }

            string winner = winners.FirstOrDefault();

            foreach (var playedCard in playedCards)
                if (playedCard.Value != null)
                    _players[winner].Cards.Add(playedCard.Value);

            return winner;
        }

        private void DealingCards()
        {
            int cardsToDeal = _mainDeck.Cards.Count / _players.Count;
            foreach (var player in _players)
                for (int i = 0; i < cardsToDeal; i++)
                    player.Value.Cards.Add(_mainDeck.StoleCard());
        }

        private void AskPlayers()
        {
            Console.WriteLine("How many players want to play?");
            int playerNumber = Tools.GetInt();

            while (playerNumber > 0)
            {
                string playerName = Tools.ReadConsoleWord("Player name:");

                _players.Add(playerName, new Deck());
                playerNumber--;
            }
        }
    }
}
