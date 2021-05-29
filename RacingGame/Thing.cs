using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Thing
    {
        public string thingName { get; set; }
        public string myPictureBox { get; set; }
        public int racetrackLength { get; set; }
        public int thingID { get; set; }
    }

    class Ghost1 : Thing
    {

        //Stats on the four ghosts. 
        // Ghosts were Originally named after the three stooges. Hence the names.  
        public Ghost1 ()
        {
            thingName = "Ghost1";
            thingID = 1;
        }



    }

    class Ghost2 : Thing
    {
        public Ghost2()
        {
            thingName = "Ghost2";
            thingID = 2;

        }
    }

    class Ghost3 : Thing
    {
        public Ghost3()
        {
            thingName = "Ghost3";
            thingID = 3;
        }
    }

    class Ghost4 : Thing
    {
        public Ghost4()
        {
            thingName = "Ghost4";
            thingID = 4;
        }
    }
}



    
  
