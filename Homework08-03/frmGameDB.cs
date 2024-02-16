using System;
using System.Windows.Forms;

namespace Homework08_03
{
    public partial class frmGameDB : Form
    {
        // Declare and initialize program conatnts
        const string GNF = "GAME NOT FOUND";
        const string N = "NAME:\t";
        const string PUB = "PUBLISHER:\t";
        const string PR = "PRICE:\t\t";

        string[] gameNames = { "Player Unknow's Battle Grounds", "League of Legends", "Call of Duty: Black Ops III", "Battlefield 4", "Super Mario Odyssey" };

        string[] publishers = { "Bluehole", "Riot Games", "Activision", "Electrnic Arts", "Nintendo" };

        decimal[] prices = { 35m, 0m, 60m, 20m, 60m };

        public frmGameDB()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoInput();
            if (keepGoing)
            {
                PerformTheSearch();
            }
        }

        private bool CheckForNoInput()
        {
            bool retVal = true;
            string term = txtSearchTerm.Text.Trim();

            if (term == "")
            {
                ShowErrorMessage("You Must Enter A Search Term",
                                 "SEARCH TERM LEFT EMPTY");

                ClearForm();
                retVal = false;
            }

            return retVal;
        }

        private void PerformTheSearch()
        {
            string term      = txtSearchTerm.Text.Trim();
            bool isFound     = false;
            int ind  = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < gameNames.Length; lcv++)
            {
                // Search either or both gameNames and the publishers array looking for a match
                if (gameNames[lcv].ToLower().Contains(term.ToLower()) ||
                    publishers[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    ind = lcv;
                    break;
                }
            }

            //We foiund a match
            if (isFound)
            {
                outputStr += ($"{N} {gameNames[ind]}\r\t\r\n");
                outputStr += ($"{PUB} {publishers[ind]}\r\n");
                outputStr += ($"{PR} {prices[ind]}\r\n");
            }
            else
            {
                outputStr += ($"{N} {GNF}\r\t\r\n");
                outputStr += ($"{PUB} {GNF}\r\n");
                outputStr += ($"{PR} {GNF}\r\n");
            }

            txtResults.Text = outputStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSearchTerm.Text = "";
            txtResults.Text = "";
            txtSearchTerm.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
