using System;
using System.Drawing;
using System.Windows.Forms;

namespace Homework09_01
{
    public partial class frmSuperhero : Form
    {
        //  Declare and initialize class variables
        string[] superHeroNames = {
        "Marvel SuperHeroes",
        "Captain America",
        "The Incredible Hulk",
        "The Invincible Iron Man",
        "The Mighty Thor",
        "The Sub-Mariner"
    };

        string[] superHeroAlterEgo = {
        "Not Applicable",
        "Steve Rogers",
        "Bruce Banner",
        "Tony Stark",
        "Thor Odinson",
        "Prince Namor"
    };

        //	Remember to change your paths to the image files accordingly!!!
        string[] superHeroImages = {
        @"C:\Users\rinla\Downloads\SuperHeroes (1)\SuperHeroes\Images\00-all.png",
        @"C:\Users\rinla\Downloads\SuperHeroes (1)\SuperHeroes\Images\01-captainamerica.png",
        @"C:\Users\rinla\Downloads\SuperHeroes (1)\SuperHeroes\Images\02-hulk.png",
        @"C:\Users\rinla\Downloads\SuperHeroes (1)\SuperHeroes\Images\03-ironman.png",
        @"C:\Users\rinla\Downloads\SuperHeroes (1)\SuperHeroes\Images\04-thor.png",
        @"C:\Users\rinla\Downloads\SuperHeroes (1)\SuperHeroes\Images\05-submariner.png"
    };

        string[] superHeroBio = {
        "The Marvel Super Heroes is an American animated television series starring five comic book superheroes from Marvel Comics. The first TV series based on Marvel characters, it debuted in syndication on U.S. television in 1966. The segments were Captain America, The Incredible Hulk, Iron Man, The Mighty Thor and The Sub-Mariner.",
        "Captain America was designed as a patriotic supersoldier who often fought the Axis powers of World War II. Captain America is the alter ego of Steve Rogers, a frail young artist enhanced to the peak of human perfection by an experimental super-soldier serum after joining the military to aid the United States government's efforts in World War II.",
        "The Hulk is a green-skinned, hulking and muscular humanoid possessing a limitless degree of physical strength, and his alter ego Dr. Robert Bruce Banner, a physically weak, socially withdrawn, and emotionally reserved physicist. The two exist as independent dissociative personalities, and resent each other, following Banner's accidental exposure to gamma rays.",
        "Iron Man is a superhero appearing in comic books published by Marvel Comics. Wealthy business magnate, playboy, philanthropist, inventor and scientist Anthony Edward Stark suffers a severe chest injury during a kidnapping. When his captors attempt to force him to build a weapon of mass destruction, he instead creates a mechanized suit of armor to save his life and escape captivity.",
        "Thor Odinson, or simply Thor, is a fictional character appearing in American comic books published by Marvel Comics. The character is based on the Norse deity of the same name, the Asgardian god of thunder whose enchanted hammer Mjolnir enables him to fly and manipulate weather, among his other superhuman attributes.",
        "Namor McKenzie, also known as the Sub-Mariner, is a fictional character appearing in American comic books published by Marvel Comics. The mutant son of a human sea captain and a princess of the mythical undersea kingdom of Atlantis, Namor possesses the super-strength and aquatic abilities of the Homo mermanus race, as well as the mutant ability of flight, along with other superhuman powers."
    };

        string[] superHeroURL = {
        "https://en.wikipedia.org/wiki/The_Marvel_Super_Heroes",
        "https://en.wikipedia.org/wiki/Captain_America",
        "https://en.wikipedia.org/wiki/Hulk",
        "https://en.wikipedia.org/wiki/Iron_Man",
        "https://en.wikipedia.org/wiki/Thor_(Marvel_Comics)",
        "https://en.wikipedia.org/wiki/Namor"
    };
        public frmSuperhero()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            picSuperHeroImage.Image = System.Drawing.Image.FromFile(superHeroImages[0]);
            lblName.Text = "";
            lblAlterEgo.Text = "";
            lblBio.Text = "";
            lblURL.Text = "";
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

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void ddlSuperhero_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSuperHeroInfo();
        }

        private void FillSuperHeroInfo()
        {
            // Grab the SelectedIndex of the selected ddl option
            int selection = ddlSuperhero.SelectedIndex;

            // Check if nothing in ddl is selected
            if (ddlSuperhero.SelectedIndex == -1)
            {
                ShowMessage("You Must Choose A Super Hero",
                            "NO SUPER HERO CHOSEN");

                return;
            }

            // A ddl optiopn WAS selected
            switch (selection)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    CreateSuperHero(selection); 
                    break;

                default: 
                    break;
            }
        }

        private void CreateSuperHero(int s)
        {
            try
            {
                picSuperHeroImage.Image = Image.FromFile(superHeroImages[s]);
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message)
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblName.Text     = $"Name: {superHeroNames[s]}";
            lblAlterEgo.Text = $"Alter Ego: {superHeroAlterEgo[s]}";
            lblBio.Text      = $"Bio: {superHeroBio[s]}";
            lblURL.Text      = $"URL: {superHeroURL[s]}";
        }

        private void lblBio_Click(object sender, EventArgs e)
        {

        }

        private void frmSuperhero_Load(object sender, EventArgs e)
        {
            // Load the ddl
            LoadTheDDL();
        }

        private void LoadTheDDL()
        {
            for (int lcv = 0; lcv < superHeroNames.Length; lcv++)
            {
                ddlSuperhero.Items.Add(superHeroNames[lcv]);
            }
        }
    }
}
