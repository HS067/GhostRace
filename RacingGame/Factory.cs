using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    

    public static class Factory
    {
        public static Random Random = new Random(); // random number

        private static int randomNumber;


        
        public static Punter GetAPerson(int id) 
        {

            
            switch (id)
            {
                case 0:
                    return new Player1();
                case 1:
                    return new Player2();
                case 2:
                    return new Player3();


                    
            }
            return new Player1();

        }

        
        public static Thing GetAThing(int id)
        {
            switch (id)
            {
                case 0:
                    return new Ghost1();
                case 1:
                    return new Ghost2();
                case 2:
                    return new Ghost3();
                case 3:
                    return new Ghost4();



            }
            return new Ghost1();

        }
        
        //Generates a random number to advance the ghosts 
        public static int Number()
        {
            return randomNumber = Random.Next(0, 10);
        }


    }
                

    }


