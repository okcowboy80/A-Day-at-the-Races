using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public const int MinimumBet = 5;
        // The last two fields are the guys' GUI controls on the form
        public RadioButton MyRadioButton;
        public Label MyLabel;
        
        public Guy(RadioButton radioButton, Label label, int cash, string name)
        {
            MyRadioButton = radioButton;
            MyLabel = label;
            Cash = cash;
            Name = name;
        }

        public void UpdateLabels()
        {
            // Set my label to my bet's description, and the label 
            // on my radio button to show my cash ("Joe has 43 bucks")
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = "" + Name + " has " + Cash + " bucks";
        }
       

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public void PlaceBet(int BetAmount, int DogToWin)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            int myBet = 0;
           
            if(Cash >= BetAmount)
            {
                myBet = BetAmount;  
            }

            MyBet = new Bet(this, DogToWin, myBet);

        }

        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
