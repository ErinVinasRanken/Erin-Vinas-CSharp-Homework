namespace Homework12_05
{
    public partial class frmJobEstimate : Form
    {
        private Job currentJob;

        public frmJobEstimate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentJob == null)
            {
                currentJob = new Job();
                currentJob.Description = txtDescription.Text;
                currentJob.HoursToComplete = Convert.ToSingle(txtHoursToComplete.Text);
                currentJob.HourlyFee = Convert.ToSingle(txtHourlyRate.Text);

                DisplayJobProperties();
            }
            else
            {
                currentJob.HoursToComplete = Convert.ToSingle(txtHoursToComplete.Text);
                currentJob.HourlyFee = Convert.ToSingle(txtHourlyRate.Text);

                DisplayJobProperties();
            }
        }

        private void DisplayJobProperties()
        {
            lblResults.Text = "Description: " + currentJob.Description + "\r\n" +
                              "\r\nHours To Complete: " + currentJob.TotalFee.ToString("0.00") + "\r\n" +
                              "\r\nHourly Rate: $" + currentJob.HoursToComplete.ToString() + "\r\n" +
                              "\r\nTotal Fee: $" + currentJob.HourlyFee.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtDescription.Text = "";
            txtHoursToComplete.Text = "";
            txtHourlyRate.Text = "";
            lblResults.Text = "";
            txtDescription.Focus();
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
