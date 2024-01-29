/*	#1. Write a GUI program that converts distances 
 *		between miles and kilometers and:
 *	●	Declares a constant named KM_PER_MILE
 *		which holds the number of kilometers
 *		in a mile (1.6 km per mile).
 *	●	Declares a constant named MILES_PER_KM
 *		which holds the number of miles in a
 *		kilometer (0.621 miles per km).
 *	●	Prompts the user for a distance in miles or
 *		kilometers.
 *	●	The user can convert miles to kilometers.
 *	●	The user can convert kilometers to miles.
 *	●	The program displays the distance in both 
 *		kilometers and miles.
 *		For example: "3.0 miles is 4.8 kilometers"
 */

namespace HomeworkDistanceConverter
{
    public partial class frmDistanceConveter : Form
    {
        // Declare and initialize program constants
        const decimal KM_PER_MILE = 1.6m;
        const decimal MILES_PER_KM = 0.621m;
        const string FCBE = "Feild Cannot Be Empty";
        const string FCBN = "Feild Must Be Numeric And Not Negative";
        const string EII = "ERROR IN INPUT";

        // Declare and initialize class variables
        decimal miles = 0;
        decimal kilos = 0;

        public frmDistanceConveter()
        {
            InitializeComponent();
        }

        private void btnConvertToKM_Click(object sender, EventArgs e)
        {
            bool result;
            string milesStr = txtDistanceInMiles.Text.Trim();

            // Check for no input
            if (milesStr == "")
            {
                txtDistanceInMiles.Focus();
                return;
            }

            // Vlaidate feild is numeric and positive
            result = decimal.TryParse(milesStr, out miles);

            if (!result || miles < 0)
            {
                ShowErrorMessage(FCBN, EII);
                txtDistanceInMiles.Text = "";
                txtDistanceInMiles.Focus();
                return;
            }

            // Convert  miles into kilometers
            kilos = miles * KM_PER_MILE;

            // Put value into textbox
            lblResult.Text = ($"{miles:n2} miles is {kilos:n2} kilometers");
        }

        private void btnConvertToMiles_Click(object sender, EventArgs e)
        {
            bool result;
            string kiloStr = txtDistanceInKilometers.Text.Trim();

            // Check for no input
            if (kiloStr == "")
            {
                txtDistanceInKilometers.Focus();
                return;
            }

            // Vlaidate feild is numeric and positive
            result = decimal.TryParse(kiloStr, out kilos);

            if (!result || kilos < 0)
            {
                ShowErrorMessage(FCBN, EII);
                txtDistanceInKilometers.Text = "";
                txtDistanceInKilometers.Focus();
                return;
            }

            // Convert  miles into kilometers
            miles = kilos * MILES_PER_KM;

            // Put value into textbox
            lblResult.Text = ($"{kilos:n2} kilometers is {miles:n2} miles");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtDistanceInMiles.Text = "";
            txtDistanceInKilometers.Text = "";
            lblResult.Text = "";
            txtDistanceInMiles.Focus();
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
