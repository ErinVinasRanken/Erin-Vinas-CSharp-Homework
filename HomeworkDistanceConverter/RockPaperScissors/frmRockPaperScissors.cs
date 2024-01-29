using System;
using System.Windows.Forms;

/*	#6. You can randomly generate three numbers
 *		as follows:
 *
 *		Random rand = new Random();
 *		int num1 = rand.Next(1, 4);
 *		int num2 = rand.Next(1, 11);
 *		int num3 = rand.Next(1, 101);
 *		Console.WriteLine("{0}, {1}, {2}", num1, num2, num3);
 *
 *		See here for the official documentation of the Random class:
 *		https://msdn.microsoft.com/en-us/library/system.random(v=vs.110).aspx
 *
 *		Build a GUI program that allows the user to play
 *		 Rock Paper Scissors.  Display the total scores.
 */

namespace RockPaperScissors
{
    public partial class frmRockPaperScissors : Form
    {

        // Declare and initialize program constants
        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;
        const string PCR = "Paper Covers Rock";
        const string SCP = "Scissors Cuts Paper";
        const string RBS = "Rock Braks Scissors";
        const string BCR = "Both Chose Rock";
        const string BCP = "Both chose paper";
        const string BCS = "Both Chose Scissors";
        const string CW = "COMPUTER WINS!";
        const string UW = "USER WINS!";
        const string TG = "TIE GAME!";

        // Declare and initialize class variables
        int computerWins = 0;
        int userWins = 0;
        int tieGames = 0;
        int userChoice = 0;
        int computerChoice = 0;
        string msg = "";
        string title = "";
        Random rand = new Random();

        public frmRockPaperScissors()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            MakeComputerChoice();
            userChoice = 1;
            DetermineWinner();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            MakeComputerChoice();
            userChoice = 2;
            DetermineWinner();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            MakeComputerChoice();
            userChoice = 3;
            DetermineWinner();
        }

        private void MakeComputerChoice()
        {
            // Choose a 1 (Rock), a 2 (Paper) or a 3 (Scissors) as the computer choice
            computerChoice = rand.Next(1, 4);
        }

        private void DetermineWinner()
        {
            switch (userChoice)
            {
                case 1:     // User chose rock
                    switch (computerChoice)
                    {
                        case 1:     // computer shows rock
                            msg = BCR;
                            title = TG;
                            break;

                        case 2:     // Computer chose paper
                            msg = PCR;
                            title = CW;
                            break;

                        case 3:     // computer chose paper
                            msg = RBS;
                            title = UW;
                            break;
                    }
                    break;

                case 2:        // User chose paper
                    switch (computerChoice)
                    {
                        case 1:     // computer shows rock
                            msg = PCR;
                            title = UW;
                            break;

                        case 2:     // Computer chose paper
                            msg = BCP;
                            title = TG;
                            break;

                        case 3:     // computer chose paper
                            msg = SCP;
                            title = CW;
                            break;
                    }
                    break;

                case 3:     // User chose scissors
                    switch (computerChoice)
                    {
                        case 1:     // computer shows rock
                            msg = RBS;
                            title = CW;
                            break;

                        case 2:     // Computer chose paper
                            msg = SCP;
                            title = UW;
                            break;

                        case 3:     // computer chose paper
                            msg = BCS;
                            title = TG;
                            break;
                    }
                    break;
            }

            IncrementAppropriateCounter();
        }

        private void IncrementAppropriateCounter()
        {
            if (title == CW)
            {
                ++computerWins;
            }
            else if (title == UW)
            {
                ++userWins;
            }
            else if (title == TG)
            {
                ++tieGames;
            }

            PrintGameResults();
        }

        private void PrintGameResults()
        {
            ShowResultsMessage(msg, title);
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            txtComputerWins.Text = computerWins.ToString();
            txtUserWins.Text = userWins.ToString(); 
            txtTieGames.Text = tieGames.ToString();
        }

        private void ShowResultsMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
    
}
