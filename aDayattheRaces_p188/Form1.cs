using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aDayattheRaces_p188
{
    public partial class Form1 : Form
    {

        Greyhound[] GreyhoundArray = new Greyhound[4];
        Random MyRandomizer = new Random();
        Bet JoeBet;
        Bet BobBet;
        Bet AlBet;
        Guy[] GuyArray = new Guy[3];
        Guy Joe;
        Guy Bob;
        Guy Al;


        public Form1()
        {
            InitializeComponent();

            GreyhoundArray[0] = new Greyhound() {         
                MyPictureBox = pictureBoxDog1,
                StartingPosition = pictureBoxDog1.Left,
                RacetrackLength = RaceTrackPictureBox.Width - pictureBoxDog1.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBoxDog2,
                StartingPosition = pictureBoxDog2.Left,
                RacetrackLength = RaceTrackPictureBox.Width - pictureBoxDog2.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBoxDog3,
                StartingPosition = pictureBoxDog3.Left,
                RacetrackLength = RaceTrackPictureBox.Width - pictureBoxDog3.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBoxDog4,
                StartingPosition = pictureBoxDog4.Left,
                RacetrackLength = RaceTrackPictureBox.Width - pictureBoxDog4.Width,
                Randomizer = MyRandomizer
            };

            // Initialise Bets
            JoeBet = new Bet()
            {
                Amount = 0,
                Dog = 0,
                Bettor = GuyArray[0]
            };

            BobBet = new Bet()
            {
                Amount = 0,
                Dog = 0,
                Bettor = GuyArray[1]
            };

            AlBet = new Bet()
            {
                Amount = 0,
                Dog = 0,
                Bettor  = GuyArray[2]
            };


            // initialise Guys

            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                myBet = JoeBet,
                Cash = 50,
                MyRadioButton = JoeRadioButton,   
                MyLabel = JoeBetLabel,
                                         
            };

            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                myBet = BobBet,
                Cash = 75,
                MyRadioButton = BobRadioButton,
                MyLabel = BobBetLabel,
            };

            GuyArray[2] = new Guy()
            {
                Name = "Al",
                myBet = AlBet,
                Cash = 45,
                MyRadioButton = AlRadioButton,
                MyLabel = AlBetLabel,
            };

            foreach (Guy g in GuyArray)
            {
                g.myBet.Bettor = g;
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // no code required
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<4;i++)
            {
                bool end = GreyhoundArray[i].Run();
                if(end)
                {
                    timer1.Stop();
                    int winner = i + 1;
                    MessageBox.Show("Dog"+winner+"won the race");
                    groupBox1.Enabled = true;

                    for (i=0;i<3;i++)
                    {
                        //int tempAmt = GuyArray[i].myBet.Amount;
                        //int tempDog = GuyArray[i].myBet.Dog;
                        GuyArray[i].Collect(winner);
                    }
                    break;
                }                                        
            }


        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            foreach (Greyhound g in GreyhoundArray)
            {
                g.TakeStartingPosition();
            }
            timer1.Start();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            // nothing to do here
        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }
// // // //////////////////////////////////////////////////////////////////////////////////

        private void betButton_Click(object sender, EventArgs e)  
        {
            // place betting and place it

            foreach (Guy g in GuyArray)
            if(g.MyRadioButton.Checked)
            {
                    int amount = (int)poundsNumericUpDown.Value;
                    int dog = (int)dogNumericUpDown.Value;
                    //g.myBet.Bettor = g;
                    // here we need to check if there is already a bet on, if so, remove it and put the new one
                    // as per the specs, (change of bets anytimes until race starts, then all bets are final)


                    if (g.myBet.Amount != 0)
                    {
                        g.Cash += g.myBet.Amount;  // refund the bet back to cash 
                    }


                    if (g.PlaceBet(amount, dog))
                    {
                        g.myBet = new Bet() { Amount = amount, Dog = dog, Bettor = g };
                    }
                    else
                    {
                        MessageBox.Show(g.Name + " do not have enough Cash to place bet");
                        g.myBet.Amount = 0; // reset previous previous bet if already placed
                     

                    }
                    
                    g.UpdateLabels();
            }

        }
    }

    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            // move forward 1,2, 3 or 4 spaces at random
            // update the position of myPicture on the form like this:
            // MyPictureBox.Left = StartingPosition + Location;
            

            Location += Randomizer.Next(5, 18);  // to make it a bit quicker
            MyPictureBox.Left = StartingPosition + Location;

            // return true if I won the race, i.e. if Location is the lenght of Racetrack of more
            return (Location >= RacetrackLength);
        }

        public void TakeStartingPosition()
        {
            // reset my location to 0 and myPictureBox to starting position
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }

    public class Guy
    {
        public string Name;
        public Bet myBet;
        public int Cash;

        // GUI controls on the form

        public RadioButton MyRadioButton;
        public Label MyLabel; 

        public void UpdateLabels()  // done
        {
            // Set my label to my bet´s description, and the label on my radio button 
            // to show my cash ("Joe has 43 pounds")

            MyLabel.Text = myBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " pounds";
        }

        public void ClearBet()  // done?
        {
            //Reset my Bet so it is zero
            myBet.Amount = 0 ;   // but the reference to the bettor remains! (that is fixed)
            MyLabel.Text = Name + " hasn´t placed a bet";
            // perhaps put to Zero the BetAmount and DogToWin fields in GUI?
        }

        public bool PlaceBet(int BetAmount, int DogToWin)    // done
        {
            // place a new bet and store it in a my bet field
            // return true if the guy had enough money to bet
            // to develop
            bool EnoughMoney = (Cash >= BetAmount);
            if (EnoughMoney)
            {
                Cash -= BetAmount;
                MyLabel.Text = myBet.GetDescription();
            }
            return (EnoughMoney);
        }

        public void Collect(int Winner)
        {
            // ask my bet to pay out, clear my bet, and update my labels
            //int tempwin = Winner;
            //int tempdog = myBet.Dog;
            //int temp = myBet.PayOut(Winner);
            Cash += myBet.PayOut(Winner);
            this.ClearBet();
            this.UpdateLabels();

        }
    }

    public class Bet    // DONE
    {
        public int Amount;  // amount of cash bet
        public int Dog;  // the number of dog the bet is on
        public Guy Bettor;  // the guy who placed the bet

        public string GetDescription()   // done
        {
            // return a string who says who placed the bet, how much cash was bet, and wich dog
            // he bet on "Joe bets 5 pounds on dog #4.  If the amount is zero, no bet is placed
            // Joe hasn´t placed any bet
            string s;
            if(Amount > 0)
            {
                s =  Bettor.Name + " bets " + Amount + " pounds on dog #" + Dog;
            }
            else
            {
                s = Bettor.Name + " hasn´t place a bet";
            }

            return (s);  
        }
        public int PayOut(int Winner)     // done
        {
            // Winner is the dog who wins the race.  If the dog won return the amount bet.
            // Otherwise, return the negative of the amount bet.
            // if Dog equals Winner return Amount, if not -Amount

            return (Dog == Winner ? 2*Amount : 0);
            
        }
    }
}
 