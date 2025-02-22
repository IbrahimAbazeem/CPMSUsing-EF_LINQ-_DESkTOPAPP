using CPMS.Models;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPMS
{
    public partial class CPMS : Form
    {
        // create a new instance of the CPMSContext class
        CPMSContext context = new CPMSContext();
        // create a new instance of the Project class
        public void empty()
        {
            textBox1.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBox2.Text = string.Empty;
            comboBox1.SelectedItem = string.Empty;
            textBox3.Text = string.Empty;
            textBox7.Text = string.Empty;
          
            textBox6.Text = string.Empty;
            textBox8.Text = string.Empty;


        }

        public CPMS()
        {
            InitializeComponent();
        }
        // Load the form
        private void Form1_Load(object sender, EventArgs e)
        {
            var projects = context.Projects.Select(p => new
            {
                p.ProjectId,
                p.ProjectName,
                p.Status,
                p.Budget,
                p.Location,
                p.StartDate
                ,
                p.EndDate
            }).ToList();

            dataGridView1.DataSource = projects;

            var Teams = context.Teams.Select(s => new
            {
                s.TeamName,
                ProjectName = s.Project.ProjectName,
                s.TeamId,
                s.ProjectId,
            }).ToList();

            dataGridView2.DataSource = Teams;
        }


        // Add Project
        private void button1_Click(object sender, EventArgs e)
        {
            //var context = new CPMSContext() ;

            var project = new Project
            {
                ProjectName = textBox1.Text,
                StartDate = dateTimePicker1.Value,
                EndDate = dateTimePicker2.Value,
                Budget = decimal.Parse(textBox2.Text),
                Status = comboBox1.SelectedItem.ToString(),
                Location = textBox3.Text,

            };

            context.Projects.Add(project);
            context.SaveChanges();
            empty();
            Form1_Load(sender, e);

        }

        // Delete Project and teams related to the project
        private void button2_Click(object sender, EventArgs e)
        {
            var PRO = context.Projects.Where(s => s.ProjectId == int.Parse(textBox6.Text)).FirstOrDefault();
            context.Projects.Remove(PRO);
            context.SaveChanges();
            MessageBox.Show("Department deleted successfully.");

            var Projects = context.Projects.Select(s => new
            {
                s.ProjectName,
                s.ProjectId,
                s.Budget,
                s.Location,
                s.StartDate,
                s.Status,
                s.EndDate
            }).ToList();
            dataGridView1.DataSource = Projects;

            var projectId = int.Parse(textBox6.Text);
            var teamsToDelete = context.Teams.Where(s => s.ProjectId == projectId).ToList();
            context.Teams.RemoveRange(teamsToDelete);
            context.SaveChanges();
            MessageBox.Show("Teams deleted successfully.");

            var Teams = context.Teams.Select(s => new
            {
                s.Project,
                s.TeamName,
                s.TeamId,
                s.ProjectId,
                s.Supervisor,
            }).ToList();
            dataGridView2.DataSource = Teams;

        }

        // Update Project

        private void button3_Click(object sender, EventArgs e)
        {
            var projectToUpdate = context.Projects.FirstOrDefault(p => p.ProjectName == textBox1.Text);

            if (projectToUpdate != null)
            {
                projectToUpdate.Status = comboBox1.SelectedItem.ToString();
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Project not found.");
            }

            var projects = context.Projects.Select(p => new
            {
                p.ProjectId,
                p.ProjectName,
                p.Status,
                p.Budget,
                p.Location,
                p.StartDate,
                p.EndDate
            }).ToList();

            dataGridView1.DataSource = projects;
            empty();
        }



        //Add Team
        //private void button4_Click(object sender, EventArgs e)
        //{
        //    var team = new Team
        //    {
        //        TeamName = textBox4.Text,
        //        Supervisor = textBox5.Text,
        //        ProjectId = int.Parse(textBox6.Text)
        //    };
        //    context.Teams.Add(team);
        //    context.SaveChanges();
        //    Form1_Load(sender, e);
        //    empty();
        //}


        // Search Project
        private void button7_Click(object sender, EventArgs e)
        {
            var SearchText = textBox7.Text.ToLower();
            var FilterByName = context.Projects.Where(s => s.ProjectName.ToLower().StartsWith(SearchText)).Select(s => new
            {
                //project search
                ProjectName = s.ProjectName,
                ProjectId = s.ProjectId,
                PrljectBudget = s.Budget,
                s.Location,
                s.StartDate,
                s.Status,
                s.EndDate

            }).ToList();
            dataGridView1.DataSource = FilterByName;
            //team search
            var SearchT = textBox7.Text.ToLower();
            var FilterBN = context.Teams.Where(s => s.TeamName.ToLower().StartsWith(SearchT)).Select(s => new
            {
                s.TeamName,
                s.TeamId,
                s.ProjectId,
                s.Project.ProjectName,

            }).ToList();
            dataGridView2.DataSource = FilterBN;
        }
        private void button8_Click(object sender, EventArgs e)
        {

            empty();
        }
        //search by using project Id
        private void button5_Click(object sender, EventArgs e)
        {
            int searchId = int.Parse(textBox8.Text);

            var filteredProjects = context.Projects
                        .Where(p => p.ProjectId == searchId).Select(s => new
                        {
                            ProjectName = s.ProjectName,
                            ProjectId = s.ProjectId,
                            PrljectBudget = s.Budget,
                            s.Location,
                            s.StartDate,
                            s.Status,
                            s.EndDate
                        })
                        .ToList();
            dataGridView1.DataSource = filteredProjects;

            var filteredTeams = context.Teams
                        .Where(t => t.ProjectId == searchId).Select(s => new
                        {
                            s.TeamName,
                            s.TeamId,
                            s.ProjectId,
                            s.Project.ProjectName,

                        })
                        .ToList();
            dataGridView2.DataSource = filteredTeams;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddTeams AddTeams = new AddTeams();
                       
                AddTeams.Show();
                this.Hide();
          
        }
    }


}
