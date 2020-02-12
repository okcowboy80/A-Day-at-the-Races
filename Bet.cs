using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        public const int MinimumBet = 5;
        public string Description;

        public Bet(Guy guy, int dog, int amount )
        {
            
            Bettor = guy;
            Dog = dog;
            Amount = amount;
        }
        public string GetDescription()
        {
            
            if (Amount >= MinimumBet)
                Description = Bettor.Name + " placed a bet of " + Amount + " bucks on Dog # " + Dog;
            else
                Description = Bettor.Name + " hasn't placed a bet yet";
            // return a string that says who placed the bet, how much
            // cash was bet, and which dog he bet on ("Joe bets 8 on dog #4").
            // If the amount is zero, no bet was placed
            // ("Joe hasn't placed a bet").
            return Description;
        }

        public int PayOut(int Winner)
        {
            // The parameter is the winner of the race. 
            // If the dog won, return the amount bet
            // otherwise, return the negative of the amount bet.
            
            if (Winner == Dog)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
