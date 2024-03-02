using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Homework9_2.frmJobDatabase;

namespace Homework9_2
{
    public partial class frmSearchResults : Form
    {
        private List<Job> jobs;

        public frmSearchResults(List<Job> jobs)
        {
            InitializeComponent();
            this.jobs = jobs;
            PopulateSearchResults();
        }

        private void PopulateSearchResults()
        {
            lbSearchResults.Items.Clear();

            foreach (Job job in jobs)
            {
                lbSearchResults.Items.Add($"{job.Title} - {job.Industry}");
            }
        }
    }
}
