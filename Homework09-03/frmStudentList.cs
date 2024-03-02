using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Homework09_03
{
    public partial class frmStudentList : Form
    {
        private List<Student> students;

        public frmStudentList()
        {
            InitializeComponent();
            InitializeStudents();
        }

        private void InitializeStudents()
        {
            students = new List<Student>
            {
                new Student("John", "Doe", "Math", "85", "3.5"),
                new Student("Alice", "Smith", "Physics", "90", "3.9"),
                new Student("Bob", "Johnson", "Chemistry", "75", "3.2")
            };
        }

        private void SearchStudents()
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            List<Student> searchResults = new List<Student>();

            if (!string.IsNullOrEmpty(firstName))
            {
                searchResults.AddRange(students.Where(student =>
                    student.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                searchResults.AddRange(students.Where(student =>
                    student.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)
                ));
            }

            searchResults = searchResults.Distinct().ToList();

            if (searchResults.Any())
            {
                DisplaySearchResults(searchResults);
            }
            else
            {
                MessageBox.Show("No Student Found With The Provided First Or Last Name.",
                                "STUDENT NOT FOUND",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void DisplaySearchResults(List<Student> searchResults)
        {
            lblResults.Text = "";

            foreach (Student student in searchResults)
            {
                lblResults.Text += $"{student.FirstName} {student.LastName},\t\n Course: {student.Course},\t\n Grade: {student.Grade},\t\n GPA: {student.GPA}\n";
            }
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchFirst.PerformClick();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchLast.PerformClick();
            }
        }

        private void btnSearchFirst_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }

        private void btnSearchLast_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Course { get; set; }
            public string Grade { get; set; }
            public string GPA { get; set; }

            public Student(string firstName, string lastName, string course, string grade, string gpa)
            {
                FirstName = firstName;
                LastName = lastName;
                Course = course;
                Grade = grade;
                GPA = gpa;
            }
        }
    }
}
