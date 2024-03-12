/*
 *		LB3 GameBreak
 *
 *		Create a searchable database for a 
 *		video game store:
 *
 *		●	The user can search by either the 
 *			name of the game or the publisher.
 *		●	If a game is found, then the program 
 *			will display information about the game.
 *		●	If a game is not found, then it will
 *			display an error message.
 *
 *		Name					Publisher					Price
 *		=========================================================
 *		Player Unknown's 
 *		Battlegrounds (PUBG)	Bluehole					$35
 *		League of Legends		Riot Games					$0
 *		Call of Duty: 
 *		Black Ops III			Activision					$60
 *		Battlefield 4			Electronic Arts (EA)		$20
 *		Super Mario Odyssey		Nintendo					$60
 *
 *		Methods:
 *
 *		SearchForGame() searches for a game by 
 *		name or publisher, returns the index of 
 *		the game or -1 if not found.
 *
 *		ShowGameInfo() takes the index of a game.
 *
 *		If the index is valid, displays the game's 
 *		information.
 *
 *		If the index is invalid, displays error 
 *		messages.
 */

namespace Homework12_03
{
    public partial class frmGameBreak : Form
    {
        // Declare and initialize global comnstants
        const int TOTALGAMES = 5;
        const string GNF = "GAME NOT FOUND";

        //  Declare and initialize class variables
        List<Game> games = new List<Game>()
        {
            new Game ("Player Unknown's Battlegrounds", "Bluehole", 35m),
            new Game ("League Of Legends", "Riot Games", 0m),
            new Game ("Call Of Duty: Black Ops III", "Activision", 60m),
            new Game ("Battlefield 4", "Electronic Arts", 20m),
            new Game ("Super Mario Odyssey", "Nintendo", 60m),
        };
        public frmGameBreak()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = WasASearchTermEntered();

            if (keepGoing)
            {
                PerformTheSearch();
            }
        }

        private bool WasASearchTermEntered()
        {
            bool retVal = true;
            string term = txtSearchTerm.Text.Trim();

            if (string.IsNullOrEmpty(term))
            {
                ShowErrorMessage("Nothing Entered For Search Term",
                                 "SEARCH TERM TEXTBOX EMPTY");
                txtSearchTerm.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void PerformTheSearch()
        {
            string sterm = txtSearchTerm.Text.Trim().ToLower();

            //  Loop through list, looking for a match
            //  on either Game Name or Game Publisher.
            for (int lcv = 0; lcv < games.Count; lcv++)
            {
                //if (games[lcv].GetName().ToLower() == sterm.ToLower() ||
                //    games[lcv].GetPublisher().ToLower() == sterm.ToLower())
                if (games[lcv].GetName().ToLower().Contains(sterm) ||
                    games[lcv].GetPublisher().ToLower().Contains(sterm))
                {
                    DisplayGameInfo(lcv);
                    return;
                }
            }

            FillInGameNotFound();
        }

        private void DisplayGameInfo(int lcv)
        {
            txtGameName.Text = games[lcv].GetName();
            txtGamePublisher.Text = games[lcv].GetPublisher();
            txtGamePrice.Text = games[lcv].GetPrice().ToString("c");
        }

        private void FillInGameNotFound()
        {
            txtGameName.Text = GNF;
            txtGamePublisher.Text = GNF;
            txtGamePrice.Text = GNF;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSearchTerm.Text = "";
            txtGameName.Text = "";
            txtGamePublisher.Text = "";
            txtGamePrice.Text = "";
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
