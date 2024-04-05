using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework18_03
{
    public partial class frmStudentGardes : Form
    {
        //  Declare and initialize program constant
        private List<Student> students;

        public frmStudentGardes()
        {
            InitializeComponent();
            //  Create a list of dummy students
            students = new List<Student>
            {
                new Student("John Doe", 80, 85),
                new Student("Jane Smith", 90, 95),
                new Student("Rey Johnson", 70, 75),
                new Student("Ben McDonald", 85, 80),
                new Student("Ellie Jones", 95, 90),
                new Student("Nick Sloan", 75, 70)
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = IsThereAValueInTheTextBox();

            if (keepGoing)
            {
                SearchForStudent();
            }
        }

        private bool IsThereAValueInTheTextBox()
        {
            bool retVal = true;

            if (txtStudentName.Text.Trim() == "")
            {
                ShowErrorMessage("No Name Entered In Search Name TextBox",
                                 "SEARCH" +
                                 "TEXTBOX EMPTY!");
                txtStudentName.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void SearchForStudent()
        {
            string searchTerm = txtStudentName.Text.Trim();

            // LINQ query to search for the student by name (case insensitive)
            var query = from student in students
                        where student.Name.ToLower() == searchTerm.ToLower()
                        select student;

            Student foundStudent = query.FirstOrDefault();

            if (foundStudent != null)
            {
                lblResults.Text += $"Lab     Grade: {foundStudent.LabGrade:n2}\r\n";
                lblResults.Text += $"Test    Grade: {foundStudent.TestGrade:n2}\r\n";
               lblResults.Text += $"Overall Grade: {foundStudent.CalculateOverallGrade():n2}";
            }
            else
            {
                ShowErrorMessage($"Student {searchTerm} not found", "NO STUDENT BY THAT NAME FOUND");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtStudentName.Text = "";
            lblResults.Text = "";
            txtStudentName.Focus();
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
