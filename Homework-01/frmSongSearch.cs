using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using SongLibrary;

namespace Homework_01
{
    public partial class frmSongSearch : Form
    {
        // Decalre and initialize program costants
        const string NOTHINGINPUTTED    = "No Value Was inputted.";
        const string NOSONGTITLEFOUND   = "No Matching Song Title Found.";
        const string NOSONGARTISTFOUND  = "No Matching Song Artist Found.";
        const string NOSONGGENREFOUND   = "No matching Song Genre Found.";

        // Declare and initialize class variable
        static List<Song> songs = SongManager.LoadData();

        public frmSongSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DecideWhichFunctionToCall();
        }

        private void DecideWhichFunctionToCall()
        {
            int option = ddlSongSearch.SelectedIndex;

            switch (option)
            {
                case -1:            // No option selected
                    ShowErrorMessage("You Must Select An Option!",
                                     "NO OPTION SELECTED IN DROP DOWN LIST");
                    ddlSongSearch.Focus();
                    return;
                case 0:
                    ShowSongListByTitleAscending();
                    break;
                case 1:
                    ShowSongListByArtistAscending();
                    break;
                case 2:
                    ShowSongListByGenreAscending();
                    break;
                case 3:
                    ShowSongListByTitleCriteria();
                    break;
                case 4:
                    ShowSongListByArtistCriteria();
                    break;
                case 5:
                    ShowSongListByGenreCriteria();
                    break;
                default:
                    break;
            }
        }

        private void ShowSongListByTitleAscending()
        {
            lvSongSearch.Items.Clear();
            var titlesAscending =
                from s in songs
                orderby s.SongTitle ascending
                select s;

            lblTitle.Text = "Song List In Ascending Order By Song Title";

            // Iterate song list
            foreach (var s in titlesAscending )
            {
                ListViewItem lvItem = new ListViewItem(s.SongTitle);
                lvItem.SubItems.Add(s.SongArtist);
                lvItem.SubItems.Add(s.SongGenre);
                lvSongSearch.Items.Add(lvItem);
            }
        }

        private void ShowSongListByArtistAscending()
        {
            lvSongSearch.Items.Clear();
            var artistsAscending =
                from s in songs
                orderby s.SongArtist ascending, s.SongTitle ascending
                select s;

            //There was at least one song matching criteria
            lblTitle.Text = "Song List In Ascending Order By Song Artist";

            // Iterate song list
            // And print out matching songs
            foreach (var s in artistsAscending)
            {
                ListViewItem lvItem = new ListViewItem(s.SongTitle);
                lvItem.SubItems.Add(s.SongArtist);
                lvItem.SubItems.Add(s.SongGenre);
                lvSongSearch.Items.Add(lvItem);
            }
        }

        private void ShowSongListByGenreAscending()
        {
            lvSongSearch.Items.Clear();
            var genreAscending =
                from s in songs
                orderby s.SongGenre, s.SongArtist ascending, s.SongTitle ascending
                select s;

            lblTitle.Text = "Song List In Ascending Order By Song Genre";

            // Iterate song list
            foreach (var s in genreAscending)
            {
                ListViewItem lvItem = new ListViewItem(s.SongTitle);
                lvItem.SubItems.Add(s.SongArtist);
                lvItem.SubItems.Add(s.SongGenre);
                lvSongSearch.Items.Add(lvItem);
            }
        }

        private void ShowSongListByTitleCriteria()
        {
            lvSongSearch.Items.Clear();
            string title = Interaction.InputBox(
                "Enter A Song Tiltle To Search For (Full Or Partial Title):");

            if (title.Trim() == "")
            {   // There was no search criteria
                lvSongSearch.Items.Add(NOTHINGINPUTTED);
            }
            else
            {   // There was search criteria
                var songTitles =
                    from s in songs
                    orderby s.SongTitle ascending
                    where s.SongTitle.ToUpper().Contains(title.ToUpper())
                    select s;

                // Check for no songs matching the criteria
                if (songTitles.Count() < 1)
                {
                    ShowErrorMessage(NOSONGTITLEFOUND, "NO OUTPUT");
                    return;
                }

                lblTitle.Text = "Song Titles Matching Inputted Search Criteria";

                // Iterate song list
                foreach (var s in songTitles)
                {
                    ListViewItem lvItem = new ListViewItem(s.SongTitle);
                    lvItem.SubItems.Add(s.SongArtist);
                    lvItem.SubItems.Add(s.SongGenre);
                    lvSongSearch.Items.Add(lvItem);
                }
            }
        }

        private void ShowSongListByArtistCriteria()
        {
            lvSongSearch.Items.Clear();
            string artist = Interaction.InputBox(
                "Enter A Song Artist To Search For (Full Or Partial Artists Name):");

            if (artist.Trim() == "")
            {   // There was no search criteria
                lvSongSearch.Items.Add(NOTHINGINPUTTED);
            }
            else
            {   // There was search criteria
                var songArtists =
                    from s in songs
                    orderby s.SongArtist, s.SongTitle ascending
                    where s.SongArtist.ToUpper().Contains(artist.ToUpper())
                    select s;

                // Check for no songs matching the criteria
                if (songArtists.Count() < 1)
                {
                    ShowErrorMessage(NOSONGARTISTFOUND, "NO OUTPUT");
                    return;
                }

                lblTitle.Text = "Song Artists Matching Inputted Search Criteria";

                // Iterate song list
                foreach (var s in songArtists)
                {
                    ListViewItem lvItem = new ListViewItem(s.SongTitle);
                    lvItem.SubItems.Add(s.SongArtist);
                    lvItem.SubItems.Add(s.SongGenre);
                    lvSongSearch.Items.Add(lvItem);
                }
            }
        }

        private void ShowSongListByGenreCriteria()
        {
            lvSongSearch.Items.Clear();
            string genre = Interaction.InputBox(
                "Enter A Song Genre To Search For (Full Or Partial Genre Name):");

            if (genre.Trim() == "")
            {   // There was no search criteria
                lvSongSearch.Items.Add(NOTHINGINPUTTED);
            }
            else
            {   // There was search criteria
                var songGenres =
                    from s in songs
                    orderby s.SongGenre, s.SongArtist, s.SongTitle ascending
                    where s.SongGenre.ToUpper().Contains(genre.ToUpper())
                    select s;

                // Check for no songs matching the criteria
                if (songGenres.Count() < 1)
                {
                    ShowErrorMessage(NOSONGGENREFOUND, "NO OUTPUT");
                    return;
                }

                lblTitle.Text = "Song Genres Matching Inputted Search Criteria";

                // Iterate song list
                foreach (var s in songGenres)
                {
                    ListViewItem lvItem = new ListViewItem(s.SongTitle);
                    lvItem.SubItems.Add(s.SongArtist);
                    lvItem.SubItems.Add(s.SongGenre);
                    lvSongSearch.Items.Add(lvItem);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            lvSongSearch.Items.Clear();
            ddlSongSearch.SelectedIndex = -1;
            ddlSongSearch.Focus();
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


        private void frmSongSearch_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDropDownList();
        }

        private void LoadDropDownList()
        {
            ddlSongSearch.Items.Clear();
            ddlSongSearch.Items.Add("Show SongList By Title  Ascending");
            ddlSongSearch.Items.Add("Show SongList By Artist Ascending");
            ddlSongSearch.Items.Add("Show SongList By Genre  Ascending");
            ddlSongSearch.Items.Add("Show SongList By title  Criteria");
            ddlSongSearch.Items.Add("Show SongList By Artist Criteria");
            ddlSongSearch.Items.Add("Show SongList By Genre  Criteria");
        }
    }
}
