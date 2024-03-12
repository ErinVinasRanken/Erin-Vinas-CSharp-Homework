namespace Homework12_01
{
    public partial class frmFlashCards : Form
    {
        //  Declare and initialize program constant
        //const int MAXCARDS = 20;        //  Max # of flashcard objects

        //  Declare and intialize class variables
        //int lcv = 0;                    //  Loop control varable

        //  List of flashcard objects
        List<Flashcard> flashcards = new List<Flashcard>()
        {
            new Flashcard("operating system", "System software that serves manages the hardware, the system resources, and also allows users to install other applications."),
            new Flashcard("graphical user interface", "Pronounced as gooey, basically all the windows, buttons, icons, and toolbars that you interact with on a computer."),
            new Flashcard("random access memory", "Fast and volatile short-term memory. Computers usually use RAM as temporary data storage. Data dependent on power."),
            new Flashcard("flash drive", "An external device to store data. This is also known as a pen drive or thumb drive. Typically hold 8MB - 16MB worth of data."),
            new Flashcard("internet", "A global system of interconnected computer networks that uses the Internet protocol suite to communicate between networks and devices.")};

        public frmFlashCards()
        {
            InitializeComponent();
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            bool keepGoing = WasThereATermInput();

            if (keepGoing)
            {
                DoesTheTermCurrentlyExist();
            }
            else
            {
                return;
            }
        }

        private bool WasThereATermInput()
        {
            bool retVal = true;

            if (string.IsNullOrEmpty(txtTerm.Text.Trim()))
            {
                ShowMessage("No Term Entered",
                                 "TERM TEXTBOX EMPTY");
                txtTerm.Focus();
                retVal = false;
            }

            return retVal;
        }


        private void DoesTheTermCurrentlyExist()
        {
            string term = txtTerm.Text.Trim();

            //  There was something entered into the textbox.
            //  See if there is a definition for this term.
            for (int lcv = 0; lcv < flashcards.Count; lcv++)
            {
                //  If term in list, get and show definition
                if (term.ToLower() == flashcards[lcv].GetTerm())
                {
                    txtDefinition.Text = flashcards[lcv].GetDefinition();
                    //ClearBottom();
                    txtDefinition.Visible = true;
                    return;
                }
            }

            //  There was no term by that name found
            //  Create a new one.
            PrepareToAddNewItemToList();
        }

        private void PrepareToAddNewItemToList()
        {
            ClearTop();
            lblAddNew.Visible = true;
            txtNewDefinition.Visible = true;
            txtNewDefinition.Text = "";
            txtNewDefinition.Focus();
            btnAdd.Visible = true;
            btnExit.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBottom();
            ClearTop();
        }

        private void ClearBottom()
        {
            lblAddNew.Visible = false;
            txtNewDefinition.Visible = false;
            btnAdd.Visible = false;
            btnExit.Visible = false;
        }

        private void ClearTop()
        {
            txtDefinition.Visible = false;
            txtTerm.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AttemptToAddNewItem();
        }

        private void AttemptToAddNewItem()
        {
            if (txtNewDefinition.Text.Trim() != "")
            {
                flashcards.Add(new Flashcard(txtTerm.Text,
                                             txtNewDefinition.Text));
                ShowMessage("The Term " + txtTerm.Text +
                                 " has successfully been added.",
                                 "TERM ADDED TO LIST");
                txtTerm.Text = "";
            }
            else
            {
                ShowMessage("New Term Definition Left Empty.",
                 "NOTHING TO ADD");
                ClearBottom();
                txtTerm.Focus();
            }

            ClearTop();
            ClearBottom();
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


    }
}
