using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace Snake_and_Ladder
{
    public class PlayerLocation
    {
        public static void Player1Location(int Player1location, PictureBox Player1)
        {
            Player1.Location = new Point(Player1location, 510);
        }
        public static void Player2Location(int Player2location, PictureBox Player2)
        {
            Player2.Location = new Point( Player2location, 510 + 46);
        }
    }
}
