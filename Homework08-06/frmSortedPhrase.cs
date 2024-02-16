using System;
using System.Windows.Forms;

namespace Homework08_06
{
    public partial class frmSortedPhrase : Form
    {
        public frmSortedPhrase()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortWords();
        }

        private void SortWords()
        {
            string input = txtSort.Text.Trim();

            // Check if input is empty
            if (txtSort.Text == "")
            {
                ShowErrorMessage("Please Enter Some Text To Sort",
                                 "ERROR IN INPUT");
                return;
            }

            string[] words = input.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);

            txtResults.Text = string.Join(" ", words);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleaarForm();
        }

        private void CleaarForm()
        {
            txtSort.Text = "";
            txtResults.Text = "";
            txtSort.Focus();
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
