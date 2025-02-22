using CPMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPMS
{
    public partial class AddTeams : Form
    {
        // create a new instance of the CPMSContext class
        CPMSContext context = new CPMSContext();
        // create a new instance of the Project class
        public void empty()
        {
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }
        public AddTeams()
        {
            InitializeComponent();
            LoadTeams();
        }

        private void LoadTeams()
        {
            var Teams = context.Teams.Select(s => new
            {
                s.TeamName,
                ProjectName = s.Project.ProjectName,
                s.TeamId,
                s.ProjectId,
            }).ToList();

            dataGridView2.DataSource = Teams;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var team = new Team
            {
                TeamName = textBox5.Text,
                Supervisor = textBox4.Text,
                ProjectId = int.Parse(textBox6.Text)
            };
            context.Teams.Add(team);
            context.SaveChanges();

            empty();
            LoadTeams();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CPMS CMPs = new CPMS();

            CMPs.Show();
            this.Hide();

        }
        
    }
}
