namespace Homework12_04
{
    public partial class frmMoviesDB : Form
    {
        // Decclare and initialize global constant
        const string MNF = "Movie Not Found";

        // Declare and initialize class variables
        List<Movie> movies = new List<Movie>()
        {
            new Movie ("Snow White and the Seven Dwarfs", "Perce Pearce", "The Grimm fairy tale gets a Technicolor treatment in Disney's first animated " +
                                                                          "feature. Jealous of Snow White's beauty, the wicked queen orders the murder of " +
                                                                          "her innocent stepdaughter, but later discovers that Snow White is still alive " +
                                                                          "and hiding in a cottage with seven friendly little miners." +
                                                                          "Disguising herself as a hag, the queen brings a poisoned apple to Snow White, " +
                                                                          "who falls into a death-like sleep that can be broken only by a kiss from the " +
                                                                          "prince."),

            new Movie ("Pinocchio", "Ben Sharpsteen", "Toymaker Gepetto creates a wooden puppet toy named Pinocchio and wishes on a star that he would be " +
                                                      "a real boy. A kindly Blue Fairy appears and grants his wish thus making Pinocchio come alive. " +
                                                      "Pinocchio learns that he must prove himself worthy in order to make his father's wish come true."),

            new Movie ("Bambi", "David Hand", "In this Disney classic a young deer named Bambi joins his new friends, a rabbit named Thumper and a skunk " +
                                              "named Flower, in exploring his forest home. As a boy, he learns from his doting mother and his father, " +
                                              "The Great Prince of the Forest, that there are dangers in the open meadows where hunters can spot the animals," +
                                              "and he meets a beautiful young doe named Faline. As Bambi grows up, he learns that there is tragedy as well " +
                                              "as beauty and joy in his forest world and on the path to adulthood."),

            new Movie ("The Lion King", "Roger Allens and Rob Minkoff", "This Disney animated feature follows the adventures of the young lion Simba, " +
                                                                        "the heir of his father, Mufasa. Simba's wicked uncle, Scar, plots to usurp Mufasa's" +
                                                                        "throne by luring father and son into a stampede of wildebeests. But Simba escapes, " +
                                                                        "and only Mufasa is killed. Simba returns as an adult to take back his homeland " +
                                                                        "from Scar with the help of his friends Timon and Pumbaa."),

            new Movie ("Fantasia", "Joe Grant and Dick Huemer", "Released in 1940, represented Disney's boldest experiment to date. " +
                                                                "Bringing to life his vision of blending animated imagery with classical music. " +
                                                                "What had begun as a vehicle to enhance Mickey Mouse's career blossomed into a full-blown feature" +
                                                                "that remains unique in the history of animation."),

            new Movie ("Toy Story", "John Lasseter", "Woody, a good-hearted cowboy doll who belongs to a young boy named Andy, sees his position as Andy's " +
                                                     "favorite toy jeopardized when his parents buy him a Buzz Lightyear action figure. " +
                                                     "Even worse, the arrogant Buzz thinks he's a real spaceman on a mission to return to his home planet. " +
                                                     "When Andy's family moves to a new house, Woody and Buzz must escape the clutches of maladjusted " +
                                                     "neighbor Sid Phillips and reunite with their boy."),

            new Movie ("Beauty and the Beast", "Gary Trousdale and Kirk Wise", "An arrogant young prince and his castle's servants fall under the spell of " +
                                                                               "a wicked enchantress, who turns him into the hideous Beast until he learns " +
                                                                               "to love and be loved in return. The spirited, headstrong village girl Belle " +
                                                                               "enters the Beast's castle after he imprisons her father Maurice. " +
                                                                               "With the help of his enchanted servants, including the matronly Mrs. Potts, " +
                                                                               "Belle begins to draw the cold-hearted Beast out of his isolation."),

            new Movie ("Shrek", "Andrew Adamson and Vicky Jenson", "Once upon a time, in a far away swamp, there lived an ogre named Shrek whose precious " +
                                                                   "solitude is suddenly shattered by an invasion of annoying fairy tale characters. " +
                                                                   "They were all banished from their kingdom by the evil Lord Farquaad. " +
                                                                   "Determined to save their home -- not to mention his -- Shrek cuts a deal with Farquaad " +
                                                                   "and sets out to rescue Princess Fiona to be Farquaad's bride. " +
                                                                   "Rescuing the Princess may be small compared to her deep, dark secret."),

            new Movie ("Cinderella", "Wifred Jackson, Hamilton Luske and Clyde Geronimi", "Cinderella, the most popular of all fairy tales, " +
                                                                                          "is a time-less story of virtue rewarded. Sweet, beautiful " +
                                                                                          "Cinderella, cruelly mistreated by her evil stepmother and " +
                                                                                          "stepsisters, is helped by her magical fairy godmother, " +
                                                                                          "who sends her off to win the heart of a handsome prince and " +
                                                                                          "live happily ever after."),

            new Movie ("Finding Nemo", "Andrew Stanton", "Marlin, a clown fish, is overly cautious with his son, Nemo, who has a foreshortened fin. " +
                                                         "When Nemo swims too close to the surface to prove himself, he is caught by a diver, and horrified " +
                                                         "Marlin must set out to find him. A blue reef fish named Dory -- who has a really short memory -- " +
                                                         "joins Marlin and complicates the encounters with sharks, jellyfish, and a host of ocean dangers. " +
                                                         "Meanwhile, Nemo plots his escape from a dentist's fish tank.")
        };
        public frmMoviesDB()
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
            string term = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(term))
            {
                ShowErrorMessage("Nothing Entered For Search Term",
                                 "SEARCH TERM TEXTBOX EMPTY");
                txtSearch.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void PerformTheSearch()
        {
            string sterm = txtSearch.Text.Trim().ToLower();

            //  Loop through list, looking for a match
            //  on either Movie Name, or Movie Director.
            for (int lcv = 0; lcv < movies.Count; lcv++)
            {
                if (movies[lcv].GetName().ToLower().Contains(sterm) ||
                    movies[lcv].GetDirector().ToLower().Contains(sterm)) 
                {
                    DisplayMovieInfo(lcv);
                    return;
                }
            }

            FillInMovieNotFound();
        }

        private void DisplayMovieInfo(int lcv)
        {
            txtSearch.Text = movies[lcv].GetName();
            lblResults.Text = "Director: \r\n\r\n" + movies[lcv].GetDirector() + "\r\n\r\nDescription:\r\n\r\n " + movies[lcv].GetDescription();
        }

        private void FillInMovieNotFound()
        {
            txtSearch.Text = MNF;
            txtSearch.Text = MNF;
            txtSearch.Text = MNF;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSearch.Text = "";
            lblResults.Text = "";
            txtSearch.Focus();
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
