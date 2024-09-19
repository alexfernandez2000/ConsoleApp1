using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
    internal class PokerGame
    {
        private List<PokerPlayer>_players=new List<PokerPlayer>();
        private Deck _mainDeck=new Deck().PokerDeck();
        private readonly int _startMoney = 100;
        private void StartGame()
        {
            _mainDeck.MixDeck();
            CreatePlayers();
            StartHand();
        }

        private void StartHand()
        {
            for (int i = 0; i < 4; i++)
            {
                StartRound();
            }
            
        }

        private void StartRound()
        {
            foreach (var pokerPlayer in _players)
            {
                Console.WriteLine();
            }
        }


        private void CreatePlayers()
        {
            throw new NotImplementedException();
        }
    }
}
