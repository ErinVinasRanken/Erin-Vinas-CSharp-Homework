using System;
using System.Windows.Forms;
using System.Linq;

/*	#9.  Write a GUI application that counts the
 *		number of vowels in a phrase that is 
 *		entered by the user.
 *
 *		For this exercise, count both uppercase and
 *		lowercase vowels, but do not consider y to
 *		be a vowel.
 *
 *	Hint: Research and use String.Substring()
 *	Hint: Use a switch statement for this one.
 */

namespace VowelCount
{
    public partial class frmVowelCount : Form
    {
        // Declare and initialize constants
        const string EPTE = "Enter Phrase TextBox Empty";
        const string EII = "ERROR IN INPUT";

        // Declare and initialize class variable
        // Use An array
        string[] vowelArray = { "A", "E", "I", "O", "U" };

        
        public frmVowelCount()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            PerformVowelCount();
        }

        private void PerformVowelCount()
        {
            string phraseStr = txtEnterPhrase.Text.Trim();
            int vowelCount = 0;

            // Check for an empty textbox
            if (phraseStr == "") 
            {
                ShowErrorMessage(EPTE, EII);
                txtEnterPhrase.Focus();
                return;
            }

            phraseStr = phraseStr.ToUpper();
            //txtEnterPhrase.Text = "";
            //txtEnterPhrase.Text = phraseStr;

            // Interate through the array,
            // one Character at a time
            // If the uppcased letter is either 
            // An A, E, I, O, U increment vowle count
            // Wehn finsihed, print out the value of vowelCount.

            for (int lcv = 0; lcv < phraseStr.Length; lcv++)
            {
                // Grab a single charcater
                string currentChar = phraseStr[lcv].ToString();

                if (vowelArray.Contains(currentChar))
                {
                    vowelCount++;
                }
            }

            lblResult.Text = ($"Number Of Vowels: {vowelCount}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEnterPhrase.Text = "";
            lblResult.Text = "";
            txtEnterPhrase.Focus();
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
