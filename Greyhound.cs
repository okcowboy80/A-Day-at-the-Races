using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public class Greyhound
    {
        public int StartingPosition;
        public const int RaceTrackLength = 975;
        public PictureBox MyPictureBox;
        public int Location;
        public Random Randomize;
        
        public Greyhound(PictureBox pictureBox)
        {
            Location = 0;
            MyPictureBox = pictureBox;
            Randomize = new Random();
        }
        public bool Run(int randomNum)
        {
            Location += randomNum;
            MyPictureBox.Left = StartingPosition + Location;
            if (Location + MyPictureBox.Width >= RaceTrackLength)
                return true;
            // move forward either 1, 2, 3 or 4 spaces at random
            // Update the position of my PictureBox on the form like this: 
            // MyPictureBox.Left = StartingPosition + Location;
            // return true if I won the race
            return false;
        }

        
        public void TakeStartingPosition()
        {
            //Reset my location to 0 and my PictureBox to starting position
            MyPictureBox.Left = 10;
            Location = 0;
        }
    }
}
