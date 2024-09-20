using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
    public class PokerPlayer
    {
        public string Name { get; set; }
        public int CurrentMoney { get; set; }
        public Deck Hand { get; set; }
        public int Bet { get; set; }
        public bool IsFold { get; set; }
        public bool PlayedRound { get; set; }
        public PokerPlayer()
        {
            Hand = new Deck();
        }

        public void ShowStats()
        {
            Console.WriteLine("Player cards:");
            foreach (Card card in Hand.Cards)
                Console.WriteLine(card.ToString());
            Console.WriteLine($"Current money: {CurrentMoney}");
            Console.WriteLine($"Current beted {Bet}");
        }
        public int SmallBlind()
        {
            while (true)
            {
                Console.WriteLine("How much you want to start the small blind?");
                int ammount = Tools.GetInt();

                if (ammount <= CurrentMoney)
                {
                    Bet=ammount;
                    CurrentMoney -= ammount;
                    break;
                }
                Console.WriteLine($@"Don't have enough money to bet that ammount:
Current amount: {CurrentMoney}
Tried Bet: {ammount}");
            }

            return Bet;
        }

        public int BigBlind(int smallBlind)
        {
            Bet = smallBlind*2 >= CurrentMoney ? CurrentMoney : smallBlind*2;
            CurrentMoney = smallBlind*2 >= CurrentMoney ? 0 : CurrentMoney - Bet;

            return Bet;
        }
        public bool Call(int ammount)
        {
            int augment = ammount - Bet;
            if (IsFold)
                return false;
            Bet = ammount >= CurrentMoney ? CurrentMoney : ammount;
            CurrentMoney= ammount >= CurrentMoney ? 0 : CurrentMoney-augment;
            return true;
        }

        public int Raise(int ammount)
        {
            int ammountToRise=-1;
            int augment = ammount - Bet;

            if (IsFold || CurrentMoney <= ammount - Bet)
            {
                Console.WriteLine("Don't have enough money to raise the bet or you Folded in the previous round.");
                return ammountToRise;
            }

            while (true)
            {
                Console.WriteLine("How much do you want to raise?");
                ammountToRise = Tools.GetInt();
                if ((ammountToRise+ammount)-Bet<=CurrentMoney)
                    break;
                Console.WriteLine("You can't afford that much");
            }

            Bet = ammountToRise + ammount;
            CurrentMoney -= ammount+ammountToRise;
            return ammountToRise;
                
        }
        public (eHandRank handRank,List<int>cardsValue) EvaluateHand(List<Card>TableCards)
        {
            eHandRank rank;
            List<Card> cardsToEvaluate = new List<Card>();
            List<int> hightCards = new List<int>();
            cardsToEvaluate.AddRange(TableCards);
            cardsToEvaluate.AddRange(Hand.Cards);
            var values = cardsToEvaluate.Select(card => card.Number).OrderByDescending(v => v).ToList();
            var suits = cardsToEvaluate.Select(card => card.Suit).ToList();
            bool isFlush = suits.Distinct().Count() == 1;
            bool isStraight = values.Distinct().Count() == 5 && values.Max() - values.Min() == 4;

            var valueGroups = values.GroupBy(v => v).OrderByDescending(g => g.Count()).ThenByDescending(g => g.Key).ToList();

            if (isFlush && isStraight)
            {
                rank = eHandRank.StraightFlush;
                hightCards = values;
            }
            else if (valueGroups[0].Count() == 4)
            {
                rank = eHandRank.FourOfAKind;
                hightCards = valueGroups.SelectMany(g => g).ToList();
            }
            else if (valueGroups[0].Count() == 3 && valueGroups[1].Count() == 2)
            {
                rank = eHandRank.FullHouse;
                hightCards = valueGroups.SelectMany(g => g).ToList();
            }
            else if (isFlush)
            {
                rank = eHandRank.Flush;
                hightCards = values;
            }
            else if (isStraight)
            {
                rank = eHandRank.Straight;
                hightCards = values;
            }
            else if (valueGroups[0].Count() == 3)
            {
                rank = eHandRank.ThreeOfAKind;
                hightCards = valueGroups.SelectMany(g => g).ToList();
            }
            else if (valueGroups[0].Count() == 2 && valueGroups[1].Count() == 2)
            {
                rank = eHandRank.TwoPair;
                hightCards = valueGroups.SelectMany(g => g).ToList();
            }
            else if (valueGroups[0].Count() == 2)
            {
                rank = eHandRank.OnePair;
                hightCards = valueGroups.SelectMany(g => g).ToList();
            }
            else
            {
                rank = eHandRank.HighCard;
                hightCards = values;
            }

            return (rank, hightCards);
        }
       public enum eHandRank
        {
            HighCard,
            OnePair,
            TwoPair,
            ThreeOfAKind,
            Straight,
            Flush,
            FullHouse,
            FourOfAKind,
            StraightFlush
        }

    }

}

