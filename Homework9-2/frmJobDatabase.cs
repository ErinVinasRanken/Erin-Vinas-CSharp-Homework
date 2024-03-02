using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Homework9_2
{
    public partial class frmJobDatabase : Form
    {
        private List<Industry> industries;

        public frmJobDatabase()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            industries = new List<Industry>
            {
                new Industry("Information Technology", new List<Job>
                {
                    new Job("Software Engineer", "Develope software applications", "IT"),
                    new Job("Network Administrator", "Manage computer networks", "IT"),
                    new Job("Data Scientist", "Analyze and interperate complex data sets", "IT"),
                }),
                new Industry("Healthcare", new List<Job>
                {
                    new Job("Registered Nurse", "Provide patient care", "Healthcare"),
                    new Job("Medical Technologist", "Perform lab tests", "Healthcare"),
                    new Job("Physical Therapist", "Help patients manage pain and improve mobility", "Healthcare")
                }),
                new Industry("Teaching", new List<Job>
                {
                    new Job("Preschool Teacher", "Teaches kids before they start school", "Teaching"),
                    new Job("Teacher", "Teaches students from ages 5-18", "Teaching"),
                    new Job("Professor", "Teaches adults in a University or Trade School", "Teaching")
                }),
                new Industry("Animator", new List<Job>
                {
                    new Job("TV Animator", "Animates for TV shows", "Animator"),
                    new Job("Video Game Animator", "Animates for video games", "Animator"),
                    new Job("Movie Animator", "Animates for movies", "Teaching")
                })
            };

            foreach (Industry industry in  industries)
            {
                lbIndustries.Items.Add(industry.Name);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Job> selectedJobs = new List<Job>();

            foreach (string selectedIndustry in lbIndustries.SelectedItems)
            {
                Industry industry = industries.Find(i => i.Name == selectedIndustry);
                if (industry != null)
                {
                    selectedJobs.AddRange(industry.Jobs);
                }
            }

            frmSearchResults frmSearchResults = new frmSearchResults(selectedJobs);
            frmSearchResults.Show();
        }

        public class Job
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Industry { get; set; }

            public Job(string title, string description, string industry)
            {
                Title = title;
                Description = description;
                Industry = industry;
            }
        }

        public class Industry
        {
            public string Name { get; set; }
            public List<Job> Jobs { get; set; }

            public Industry(string name, List<Job> jobs)
            {
                Name = name;
                Jobs = jobs;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            lbIndustries.Items.Clear();
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
