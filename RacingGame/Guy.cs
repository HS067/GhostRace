using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{

    //Simple stats on all three betters
    class Player1 : Punter
    {
        public Player1()
        {
            name = "Player1";
            cash = 50;
        }

    }

    class Player2 : Punter
    {
        public Player2()
        {
            name = "Player2";
            cash = 50;

        }

       
    }

    class Player3 : Punter
    {
        public Player3()
        {
            name = "Player3";
            cash = 50;
        }
    }
    
}
