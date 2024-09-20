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
        private Deck _publicDeck = new Deck();
        private readonly int _startMoney = 100;
        private readonly int _rounds = 4;
        private string _nameRaisedPlayer = "";
        private int _currentBet = 0;
        private void StartGame()
        {
            _mainDeck.MixDeck();
            CreatePlayers();
            StartHand();
        }

        private void StartHand()
        {
            _currentBet = 0;
            for (int round = 0; round < _rounds; round++)
            {
                switch (round)
                {
                    case 0:
                        _currentBet = _players[round].SmallBlind();
                        _currentBet = _players[round + 1].BigBlind(_currentBet);
                        break;
                    case 1:
                        for (int cardsToDraw = 0; cardsToDraw < 3; cardsToDraw++)
                            _publicDeck.Cards.Add(_mainDeck.StoleCard());
                        break;
                    case 2:
                    case 3:
                        _publicDeck.Cards.Add(_mainDeck.StoleCard());
                        break;
                }
                StartRound();
                ResetRound();
                if (round==0)
                    DealCards();
            }
            
        }

        private void DealCards()
        {
            foreach (PokerPlayer pokerPlayer in _players)
                for (int i = 0; i < 2; i++)
                    pokerPlayer.Hand.Cards.Add(_mainDeck.StoleCard());
        }
        private void StartRound()
        {
            int player=0;
            _nameRaisedPlayer = _players[player].Name;
            while (!_players[player].PlayedRound && _nameRaisedPlayer != _players[player].Name)
            {
                if (_players[player].IsFold || _players[player].CurrentMoney == 0)
                {
                    player = player >= _players.Count ? 0 : player + 1;
                    continue;
                }
                Console.WriteLine($@"
Turn player: {_players[player].Name}
Current Bet: {_currentBet}");
                _players[player].ShowStats();
                PlayerAction(_players[player]);
                player = player >= _players.Count ? 0 : player+1;
            }
        }

        public void PlayerAction(PokerPlayer player)
        {
            while (true)
            {
                Console.WriteLine($@"
What do you want to do?
1:Call
2:Raise
3:Fold");
                int option = Tools.GetInt();

                if (option == 1)
                    if (player.Call(_currentBet))
                        break;
                else if (option == 2)
                {
                    int raisedAmmount = player.Raise(_currentBet);
                    if (raisedAmmount!=-1)
                    {
                        _currentBet += raisedAmmount;
                        _nameRaisedPlayer = player.Name;
                        break;
                    }
                }
                else if (option == 3)
                {
                    player.IsFold = true;
                    break;
                }
                Console.WriteLine("Invalid option selected");
            }
            player.PlayedRound = true;
        }
        private void ResetRound()
        {
            foreach (PokerPlayer pokerPlayer in _players)
            {
                pokerPlayer.PlayedRound = false;
                pokerPlayer.Bet = 0;
                pokerPlayer.IsFold=false;
            }

            _currentBet = 0;
        }
        private void CreatePlayers()
        {
            Console.WriteLine("How many players want to play?");
            int numberPlayers = Tools.GetInt();
            for (int i = 0; i < numberPlayers; i++)
            {
                PokerPlayer player = new PokerPlayer();
                player.CurrentMoney = _startMoney;
                player.Name = Tools.ReadConsoleWord("Name player");
                player.IsFold = false;
                player.Bet = 0;
                _players.Add(player);
            }
        }
    }
}
