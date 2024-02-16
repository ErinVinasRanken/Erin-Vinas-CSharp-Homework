using System;
using System.Windows.Forms;

namespace Homework08_04
{
    public partial class frmMovieDB : Form
    {
        // Array to store movie information
        private string[,] movies = new string[10, 3]
        {
            {"The Shawshank Redemption", "Frank Darabont", "1994"},
            {"The Godfather", "Francis Ford Coppola", "1972"},
            {"The Dark Knight", "Christopher Nolan", "2008"},
            {"Schindler's List", "Steven Spielberg", "1993"},
            {"Pulp Fiction", "Quentin Tarantino", "1994"},
            {"The Lord of the Rings: The Return of the King", "Peter Jackson", "2003"},
            {"Forrest Gump", "Robert Zemeckis", "1994"},
            {"Inception", "Christopher Nolan", "2010"},
            {"Fight Club", "David Fincher", "1999"},
            {"The Matrix", "Lana Wachowski, Lilly Wachowski", "1999"}
        };

        public frmMovieDB()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtMovieName.Text.Trim().ToLower();

            // Search for the movie
            bool retVal = false;

            for (int lcv = 0; lcv < movies.GetLength(0); lcv++)
            {
                if (movies[lcv, 0].ToLower().Contains(searchTerm) ||
                    movies[lcv, 1].ToLower().Contains(searchTerm))
                {
                    txtResults.Text = $"Movie: {movies[lcv, 0]}\r\nDirector: {movies[lcv, 1]}\r\nYear: {movies[lcv, 2]}";
                    retVal = true;
                    break;
                }
            }

            // Display Error Message if movie not found
            if (!retVal)
            {
                ShowErrorMessage("Movie Not Found", "ERROR IN INPUT");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtMovieName.Text = "";
            txtResults.Text = "";
            txtMovieName.Focus();
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
