using System;
using System.Windows.Forms;

namespace Homework08_05
{
    public partial class frmFortuneCookie : Form
    {
        // Array of faortune cookie sayings
        private string[] fortuneSayings =
        {
            "Bithdays are like frineds. The more you have the better.",
            "Your smile is a treasure to all who know you",
            "You never hesitate to tackle the most difficult problems.",
            "The most obvious solution is not always the best.",
            "If you want a rainbow, tou will have to tolerate the rain.",
            "The early bird gets the worm, but the second mouse gets the cheese.",
            "From listening comes wisdom and from speaking repentence.",
            "A smile is your personal welcome mat.",
            "Courage is not the absence of fear, it is the conquest of it.",
            "A ship in harbor is safe, but that's not why ships are built.",
            "The wise man is the one that makes you tink that he is dumb.",
            "One that would have the fruit must climb the tree.",

        };

        public frmFortuneCookie()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            GenerateFourtune();
        }

        private void GenerateFourtune()
        {
            // Generate random phrases
            Random rand = new Random();
            int index1 = rand.Next(fortuneSayings.Length);
            int index2;

            do
            {
                index2 = rand.Next(fortuneSayings.Length);
            }
            while (index2 == index1);

            // Display the seledted fortune sayings
            txtFortune1.Text = fortuneSayings[index1];
            txtFortune2.Text = fortuneSayings[index2];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFortune1.Text = "";
            txtFortune2.Text = "";
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
    }
}
