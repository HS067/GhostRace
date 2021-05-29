using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        //Punter class
        Punter[] myPunter = new Punter[3];
        //Class containing Ghosts. Referred to in the code as things.
        Thing[] myThing = new Thing[4];
        //Race information
        Race myRace = new Race();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            Transparent();
            ResetGhosts();
            
        }


        private void LoadData() //load data method 
        {
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPerson(i);
            }

            for (int i = 0; i < 4; i++)
            {
                myThing[i] = Factory.GetAThing(i);
            }


            numThingNumber.Minimum = 1;
            //assign variables to punters
            myRace.p1Cash = myPunter[0].cash;
            myRace.p2Cash = myPunter[1].cash;
            myRace.p3Cash = myPunter[2].cash;
        }


        //Assign transparency to moving ghosts
        private void Transparent()
        {

            Application.DoEvents();

            this.PointToScreen(PB1.Location);

            PB1.Parent = pbBackground;

            PB1.BackColor = Color.Transparent;
            //
            this.PointToScreen(PB2.Location);

            PB2.Parent = pbBackground;

            PB2.BackColor = Color.Transparent;

            //
            this.PointToScreen(PB3.Location);

            PB3.Parent = pbBackground;

            PB3.BackColor = Color.Transparent;

            //
            this.PointToScreen(PB4.Location);

            PB4.Parent = pbBackground;

            PB4.BackColor = Color.Transparent;
        }


        private void allBetters_CheckedChanged(object sender, EventArgs e)
        {
            
            myRace.myRadioButton = (RadioButton) sender;
            if (myRace.myRadioButton.Checked == true)
            {
                int merino = Convert.ToInt16(myRace.myRadioButton.Tag);
                this.Text = myPunter[merino].name;
                txtMaxBet.Text = myPunter[merino].cash.ToString();
                //myPunter[merino].cash = myPunter[merino].cash - 5;


                int cash = myPunter[merino].cash;

                numBetAmount.Text = cash.ToString();
                numBetAmount.Maximum = cash;

            }



        }

      

        private void btnBet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(myRace.myRadioButton.Tag.ToString());

            int numThingZeroStart = Convert.ToInt16(numThingNumber.Text) - 1;


            int person = Convert.ToInt16(myRace.myRadioButton.Tag);

            if (person == 0)
            {
                lblBetStatus1.Text = "Player1 has put $" + numBetAmount.Text + " on " +
                                     myThing[numThingZeroStart].thingName;
                myRace.player3Thing = myThing[numThingZeroStart].thingID;
                myRace.player1Bet = true;
                myRace.p1Amount = Convert.ToInt16(numBetAmount.Text);
            }
            else if (person == 1)
            {
                lblBetStatus2.Text = "Player2 has put $" + numBetAmount.Text + " on " +
                                     myThing[numThingZeroStart].thingName;
                myRace.player2Bet = true;
                myRace.player2Thing = myThing[numThingZeroStart].thingID;
                myRace.p2Amount = Convert.ToInt16(numBetAmount.Text);
                //myRace.p2Amount = Convert.ToInt16(numBetAmount);
            }
            else
            {
                lblBetStatus3.Text = "Player3 has put $" + numBetAmount.Text + " on " +
                                     myThing[numThingZeroStart].thingName;
                myRace.player3Bet = true;
                myRace.player3Thing = myThing[numThingZeroStart].thingID;
                myRace.p3Amount = Convert.ToInt16(numBetAmount.Text);
            }

        }

       

        private void btnRace_Click(object sender, EventArgs e)
        {
            //check that Joe, Al and Bob have made bets before racing
            if (myRace.player1Bet == true && myRace.player2Bet == true && myRace.player3Bet == true)
            {
                //code for moving the ghosts
                myRace.TrackLength = Form1.ActiveForm.Width - PB1.Width;


                while (PB1.Location.X < myRace.TrackLength && PB2.Location.X < myRace.TrackLength &&
                       PB3.Location.X < myRace.TrackLength && PB4.Location.X < myRace.TrackLength)

                {
                    
                    PB1.Location = new Point(PB1.Location.X + Factory.Number(), PB1.Location.Y);
                    PB2.Location = new Point(PB2.Location.X + Factory.Number(), PB2.Location.Y);
                    PB3.Location = new Point(PB3.Location.X + Factory.Number(), PB3.Location.Y);
                    PB4.Location = new Point(PB4.Location.X + Factory.Number(), PB4.Location.Y);
                    Application.DoEvents();


                    }
                //decide what to do upon winning
                if (PB1.Location.X >= myRace.TrackLength)
                {
                    //Place flag if winner is first ghost
                    MessageBox.Show("The Winner is " + myThing[0].thingName);
                    myRace.Winner = 1;


                }
                else if (PB2.Location.X >= myRace.TrackLength)
                {
                    //Place flag if winner is second ghost
                    MessageBox.Show("The Winner is " + myThing[1].thingName);
                    myRace.Winner = 2;

                }
                else if (PB3.Location.X >= myRace.TrackLength)
                {
                    //Place flag if winner is third ghost
                    MessageBox.Show("The Winner is " + myThing[2].thingName);
                    myRace.Winner = 3;
                }
                else
                {
                    //Place flag if winner is fourth ghost
                    MessageBox.Show("The Winner is " + myThing[3].thingName);
                    myRace.Winner = 4;
                }

                //Whoever wins is awarded cash
                if (myRace.player3Thing == myRace.Winner)
                {
                    lblBetStatus1.Text = "Player1 Wins $" + myRace.p1Amount;
                    myRace.p1Cash = myRace.p1Cash + myRace.p1Amount;



                }
                else
                {
                    lblBetStatus1.Text = "Player1 Loses $" + myRace.p1Amount;
                    myRace.p1Cash = myRace.p1Cash - myRace.p1Amount;
                }
                if (myRace.player2Thing == myRace.Winner)
                {
                    lblBetStatus2.Text = "Player2 Wins $" + myRace.p2Amount;
                    myRace.p2Cash = myRace.p2Cash + myRace.p2Amount;
                }
                else
                {
                    lblBetStatus2.Text = "Player2 Loses $" + myRace.p2Amount;
                    myRace.p2Cash = myRace.p2Cash - myRace.p2Amount;
                }
                if (myRace.player3Thing == myRace.Winner)
                {
                    lblBetStatus3.Text = "Player3 Wins $" + myRace.p3Amount;
                    myRace.p3Cash = myRace.p3Cash + myRace.p3Amount;
                }
                else
                {
                    lblBetStatus3.Text = "Player3 Loses $" + myRace.p3Amount;
                    myRace.p3Cash = myRace.p3Cash - myRace.p3Amount;
                }

                //
                myPunter[0].cash = myRace.p1Cash;
                myPunter[1].cash = myRace.p2Cash;
                myPunter[2].cash = myRace.p3Cash;
                ResetAll();


                //If everyone is out of money
                if (myRace.p3Cash <= 0 && myRace.p2Cash <= 0 && myRace.p1Cash <= 0)
                {
                    MessageBox.Show("Everyone is broke. Go Home!");
                    btnBet.Enabled = false;
                    myRace.player1Bet = false;
                }
            }
            else
            {
                MessageBox.Show("You cannot do that at this time.");
            }
        }

       

        //Reset Ghosts to initial positions
        public void ResetGhosts()
        {
            PB1.Location = new Point(50, 50);
            PB2.Location = new Point(50, 100);
            PB3.Location = new Point(50, 150);
            PB4.Location = new Point(50, 200);

        }

        //reset everything
        public void ResetAll()
        {

            ResetGhosts();
           
            if (myRace.p1Cash <= 0)
            {
                p1Button.Enabled = false;
                myRace.player1Bet = true;
                lblBetStatus1.Text = "Busted";
                myRace.p3Amount = 0;
            }
            else
            {
                myRace.player1Bet = false;
            }
            if (myRace.p2Cash <= 0)
            {
                p2Button.Enabled = false;
                myRace.player2Bet = true;
              
                lblBetStatus2.Text = "Busted";
                myRace.p2Amount = 0;
            }
            else
            {
                myRace.player2Bet = false;
            }
            if (myRace.p3Cash <= 0)
            {
                p3Button.Enabled = false;
                myRace.player3Bet = true;
                lblBetStatus3.Text = "Busted";
                myRace.p1Amount = 0;
            }
            else
            {
                myRace.player3Bet = false;
            }

            p1Button.Checked = false;
            p2Button.Checked = false;
            p3Button.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
