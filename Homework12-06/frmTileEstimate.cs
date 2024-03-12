
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System;

namespace Homework12_06
{
    public partial class frmTileEstimate : Form
    {
        // Declare and initialize program constant
        const int MAX = 11;

        // Declare class variables
        string[] roomName    = new string[MAX];
        int[] widths         = new int[MAX];
        int[] lengths        = new int[MAX];
        int[] areas          = new int[MAX];
        int[] boxes          = new int[MAX];
        string outputStr     = "";
        int totalBoxesNeeded = 0;
        int totalRooms       = 0;
        Room? room;

        public frmTileEstimate()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                ++totalRooms;

                if (totalRooms >= MAX)
                {
                    ShowErrorMessage("No More Room In Array.",
                                     "MAX ROOMS HAVE BEEN INPUTTED");
                    return;
                }

                // Calculate values for the current room name, room width, and rom length
                roomName[totalRooms -1]  = txtRoomName.Text.Trim();
                widths[totalRooms   -1]  = int.Parse(txtRoomWidth.Text.Trim());
                lengths[totalRooms  -1]  = int.Parse(txtRoomLength.Text.Trim());

                // Calculate value for the current room area
                CalculateCurrentRoomArea();

                // Calculate the number of boxes needed for current room
                CalculateTotalBoxesNeeded();
      
                // Instantiate a new room object
                Room room = new Room(roomName[totalRooms -1],
                                     widths[totalRooms -1],
                                     lengths[totalRooms -1],
                                     areas[totalRooms - 1],
                                     boxes[totalRooms - 1]);
                DisplayOutput(room);
            }
        }

        private void CalculateCurrentRoomArea()
        {
            areas[totalRooms -1] = widths[totalRooms  - 1] *
                                   lengths[totalRooms - 1];
        }

        private bool IsValidData()
        {
            string room = txtRoomName.Text.Trim();
            string width = txtRoomWidth.Text.Trim();
            string length = txtRoomLength.Text.Trim();

            bool success = true;
            string errorMessage = "";

            // Validate room textbox
            errorMessage += Validator.IsPresent(room, "Room Name");

            // Validate the width textbox
            errorMessage += Validator.IsPresent(width, "Room Width");
            errorMessage += Validator.IsInt32(width, "Room Width");

            // Validate the length textbox
            errorMessage += Validator.IsPresent(length, "Room Length");
            errorMessage += Validator.IsInt32(length, "Room Length");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }

            return true;
        }

        private void CalculateTotalBoxesNeeded()
        {
            //boxes[totalRooms - 1] = 0;
            int tempValue          = areas[totalRooms - 1] / 12;
            boxes[totalRooms -1]   = (areas[totalRooms - 1] % 12 == 0) ? tempValue : ++tempValue;
            totalBoxesNeeded += boxes[totalRooms - 1];
        }

        private void DisplayOutput(Room room)
        {
            string headingStr = "";
            lblHeading.Text = "";
            headingStr += "Total Number Of Rooms:\t" + totalRooms.ToString();
            headingStr += "\r\nTotal Tile Boxes Needed:\t" + totalBoxesNeeded.ToString();
            lblHeading.Text = headingStr;

            outputStr += room.GetName() + "(" +
                         room.GetWidth().ToString() +
                         " * " + room.GetLength().ToString() +
                         ") needs " + room.GetBoxes().ToString() +
                         " boxes.\r\n";

            txtResults.Text = outputStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtRoomName.Text   = "";
            txtRoomWidth.Text  = "";
            txtRoomLength.Text = "";
            txtRoomName.Focus();
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
