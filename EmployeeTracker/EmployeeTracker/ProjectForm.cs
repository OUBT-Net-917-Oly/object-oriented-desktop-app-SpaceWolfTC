using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeTracker.Models;

namespace EmployeeTracker
{
    public partial class ProjectForm : Form
    {
        List<Project> _projects;
        delegate void SetText(string message);
        event SetText ShowResults;

        public ProjectForm(List<Project> projects)
        {
            InitializeComponent();
            _projects = projects;
            ShowResults += results_ShowResults;
            ShowResults("");

        }
        private void results_ShowResults(string message)
        {
            lblResult.Text = message;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            project.Id = Convert.ToInt32(projectIdTxt.Text);
            project.Name = projectNameTxt.Text;
            project.Description = projectDescriptionTxt.Text;
            project.StartDate = DateTime.Parse(startDate.Text);
            project.EndDate = DateTime.Parse(endDate.Text);
            _projects.Add(project);
            ShowResults("Saved");
        }
        private void projectIdTxt_TextChanged(object sender, EventArgs e)
        {
            ShowResults("");
        }
        private void projectNameTxt_TextChanged(object sender, EventArgs e)
        {
            ShowResults("");
        }
        private void projectDescriptionTxt_TextChanged(object sender, EventArgs e)
        {
            ShowResults("");
        }
        private void startDate_TextChanged(object sender, EventArgs e)
        {
            ShowResults("");
        }
        private void endDate_TextChanged(object sender, EventArgs e)
        {
            ShowResults("");
        }
    }
}
