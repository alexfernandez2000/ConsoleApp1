using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool Call(int ammount)
        {
            if (IsFold)
                return false;
            Bet = ammount >= CurrentMoney ? CurrentMoney : ammount;
            CurrentMoney= ammount >= CurrentMoney ? 0 : CurrentMoney-(ammount-Bet);
            return true;
        }

        public int Raise(int ammount)
        {
            int ammountToRise=-1;

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
            CurrentMoney -= ((ammount+ammountToRise)-Bet);
            return ammountToRise;
                
        }
    }
}
