using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public partial class RacesForm : Form
    {
        string tempString;
        int myWidth;
        int winner = 0;
        Random random;

        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];

        public RacesForm()
        {
            InitializeComponent();
            guys[0] = new Guy(joeRadioButton, joeBetLabel, 50, "Joe");
            guys[1] = new Guy(bobRadioButton, bobBetLabel, 50, "Bob");
            guys[2] = new Guy(alRadioButton, alBetLabel, 50, "Al");

            dogs[0] = new Greyhound(dog1);
            dogs[1] = new Greyhound(dog2);
            dogs[2] = new Greyhound(dog3);
            dogs[3] = new Greyhound(dog4);

            random = new Random();
        }
        // Loads Race Form and centers Title
        private void RacesForm_Load(object sender, EventArgs e)
        {
            string title = this.Text.Trim();
            int width = this.Width;
            myWidth = (width / 16) - title.Length;
          
            int titleLength = title.Length;
            
            tempString = "";
            for (int i = 0; i <= myWidth; i++)
            {
                tempString += "   ";
            }

            this.Text = tempString + title;
            minimumBetLabel.Text = "Minimum bet: " + dollarUD.Value + " bucks";
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].TakeStartingPosition();
            }
            
            timer1.Start();
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            int betAmount = (int)dollarUD.Value;
            int dogToWin = (int)dogToWinUD.Value;
            if (joeRadioButton.Checked == true)
            {
                guys[0].PlaceBet(betAmount, dogToWin);
                guys[0].UpdateLabels();
            }

            if (bobRadioButton.Checked == true)
            {
                guys[1].PlaceBet(betAmount, dogToWin);
                guys[1].UpdateLabels();
            }

            if (alRadioButton.Checked == true)
            {
                guys[2].PlaceBet(betAmount, dogToWin);
                guys[2].UpdateLabels();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            for (int i = 0; i < dogs.Length; i++)
            {

                if (dogs[i].Run(random.Next(4)))
                {

                    timer1.Stop();
                    winner = i+1;
                    MessageBox.Show("Dog #" + winner, "Race Winner");
                    for(int j = 0; j < guys.Length; j++)
                    {
                        guys[j].Collect(winner);
                    }
                    break;
                }
            }
           
        }

        private void dog1_Click(object sender, EventArgs e)
        {

        }
    }
}
