using System;
using System.Windows.Forms;

/*	#4. Write a GUI program that determines eligibility
 *		for college applicants and:
 *	●	Prompts the user for the high-school GPA
 *		and admission test score.
 *	●	Display "Accept" if the student's GPA is
 *		3.0 or higher and their admission test score
 *		is 60 or greater.
 *	●	Display "Accept" if the student's GPA is
 *		less than 3.0 and their admission test score
 *		is 80 or greater.
 *	●	Otherwise display "Reject"
 */

namespace CollegeAdmission
{
    public partial class frmCollegeAdmission : Form
    {
        // Declare and initialize contstants
        const decimal MINGPA = 0.0m;
        const decimal MAXGPA = 4.0m;
        const int MINATS = 0;
        const int MAXATS = 100;
        const string MOII = "MISSING OR INVALID INPUT";
        const string GPACBE = "GPA Cannot Be empty.";
        const string GPAOOR = "GPA Out-Of-Range";
        const string ATSCBE = "Admin Test Score Cannot Be Empty";
        const string ATSOOR = "Admin Test Score out-Of-Range";

        // Decalre anf initialize class variables
        decimal gpa = 0m;
        int ats = 0;

        public frmCollegeAdmission()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            ValidateGPAAndAdmissionTestScore();
        }

        private void ValidateGPAAndAdmissionTestScore()
        {
            string gpaStr = txtGPA.Text.Trim();
            string atsStr = txtAdmissionTestScore.Text.Trim();
            bool result;

            // Vaidate that GPA is not empty
            if (gpaStr == "")
            {
                ShowErrorMessage(GPACBE, MOII);
                txtGPA.Focus();
                return;
            }

            // Validate that GPA is numeric and between 0.0 and 4.0
            result = decimal.TryParse(gpaStr, out gpa);
            if (!result || gpa < MINGPA || gpa > MAXGPA) 
            {
                ShowErrorMessage(GPAOOR, MOII);
                txtGPA.Text = "";
                txtGPA.Focus();
                return;
            }


            // Vaidate that ATS is not empty
            if (atsStr == "")
            {
                ShowErrorMessage(ATSCBE, MOII);
                txtAdmissionTestScore.Focus();
                return;
            }

            // Validate that ATS is numeric and between 0.0 and 4.0
            result = int.TryParse(atsStr, out ats);
            if (!result || ats < MINATS || ats > MAXATS)
            {
                ShowErrorMessage(ATSOOR, MOII);
                txtAdmissionTestScore.Text = "";
                txtAdmissionTestScore.Focus();
                return;
            }

            DetermineAcceptOrReject();
        }

        private void DetermineAcceptOrReject()
        {
            string aor = "";

            /*   ●	Display "Accept" if the student's GPA is
             * 3.0 or higher and their admission test score
             *      is 60 or greater.
             *  ●	Display "Accept" if the student's GPA is
             * less than 3.0 and their admission test score
             *      is 80 or greater.
             *  ●	Otherwise display "Reject"
             */

            if (gpa >= 3.0m && ats >= 60)
            {
                aor = "ACCEPT";
            }
            else if (gpa < 3.0m && ats >= 80)
            {
                aor = "ACCEPT";
            }
            else
            {
                aor = "REJECT";
            }

            lblAcceptOrReject.Text = aor;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtGPA.Text = "";
            txtAdmissionTestScore.Text = "";
            lblAcceptOrReject.Text = "";
            txtGPA.Focus();
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
