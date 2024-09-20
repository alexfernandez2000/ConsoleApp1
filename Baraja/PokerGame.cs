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
        public void StartGame()
        {
            _mainDeck.MixDeck();
            CreatePlayers();
            StartHand();
            Console.ReadLine();
        }

        private void StartHand()
        {
            for (int round = 0; round < _rounds; round++)
            {
                Console.WriteLine($"Starting round{round}");
                switch (round)
                {
                    case 0:
                        _currentBet = _players[round].SmallBlind();
                        _currentBet = _players[round + 1].BigBlind(_currentBet);
                        _nameRaisedPlayer = _players[round + 1].Name;
                        _players[round + 1].PlayedRound = true;
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
                if (IsWinByFold())
                    return;
                ResetRound(false);
                if (round==0)
                    DealCards();
                if (round == _rounds-1)
                    break;
            }
            CompareHands();
            
        }

        private bool IsWinByFold()
        {
            IEnumerable<PokerPlayer> inGamePlayers = _players.Where(x => !x.IsFold);
            if (inGamePlayers.Count()>1)
                return false;
            PokerPlayer winner = inGamePlayers.FirstOrDefault();
            winner.CurrentMoney += GetTotalBet();
            Console.WriteLine($"Winner {winner.Name}");
            ResetRound(true);
            return true;
        }

        private int GetTotalBet()
        {
            int total = 0;
            foreach (PokerPlayer pokerPlayer in _players)
                total += pokerPlayer.Bet;
            return total;
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
            while (true)
            {
                if (_players[player].PlayedRound && _nameRaisedPlayer == _players[player].Name)
                    break;
                if (_players[player].IsFold ||_players[player].CurrentMoney == 0)
                {
                    player = player >= _players.Count-1 ? 0 : player + 1;
                    continue;
                }
                Console.WriteLine($@"
Turn player: {_players[player].Name}
Current Bet: {_currentBet}");
                _players[player].ShowStats();
                Console.WriteLine(_publicDeck.ToString());
                PlayerAction(_players[player]);
                player = player >= _players.Count-1 ? 0 : player+1;
            }
        }

        private void PlayerAction(PokerPlayer player)
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
                {
                    if (player.Call(_currentBet))
                        break;
                }
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
        private void ResetRound(bool isHand)
        {
            foreach (PokerPlayer pokerPlayer in _players)
            {
                pokerPlayer.PlayedRound = false;
                if (isHand)
                {
                    pokerPlayer.Bet = 0;
                    pokerPlayer.IsFold = false;
                }

            }
            if (isHand)
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
#region HandComparer
        private void CompareHands()
        {
            PokerPlayer winner= null;
            foreach (PokerPlayer player in _players.Where(x=>!x.IsFold))
            {
                if (winner == null)
                    winner = player;
                else
                {
                    if (ComparePlayers(player, winner)==1)
                            winner = player;                    
                }
            }
            Console.WriteLine($"Winner: {winner.Name}");
            winner.CurrentMoney = GetTotalBet();
        }
        private int ComparePlayers(PokerPlayer player,PokerPlayer playerToCompare)
        {
            var valuePlayer= player.EvaluateHand(_publicDeck.Cards);
            var valuePlayerToCompare = playerToCompare.EvaluateHand(_publicDeck.Cards);

            if (valuePlayer.handRank != valuePlayerToCompare.handRank)
                return valuePlayer.handRank > valuePlayerToCompare.handRank ? 1 : -1;

            for (int i = 0; i < valuePlayer.cardsValue.Count; i++)
            {
                if (valuePlayer.cardsValue[i] != valuePlayerToCompare.cardsValue[i])
                    return valuePlayer.cardsValue[i] > valuePlayerToCompare.cardsValue[i] ? 1 : -1;
            }

            return 0;

        }

        #endregion
    }
}
