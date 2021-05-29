using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public class Race
    {
        public RadioButton myRadioButton { get; set; }
        public Boolean player1Bet { get; set; }
        public Boolean player2Bet { get; set; }
        public Boolean player3Bet { get; set; }
        public int p1Amount { get; set; }
        public int p2Amount { get; set; }
        public int p3Amount { get; set; }
        public int player1Thing { get; set; }
        public int player2Thing { get; set; }
        public int player3Thing { get; set; }
        public int p1Cash { get; set; }
        public int p2Cash { get; set; }
        public int p3Cash { get; set; }
        public int TrackLength { get; set; }
        public int Winner { get; set; }


}
}
 