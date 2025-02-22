using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CPMS cpms = new CPMS();
            if (textBox2.Text == "Ahmed" && textBox1.Text == "1234")
            {
                cpms.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password or username invalid");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //string filePath = "C:\\Users\\ibrih\\OneDrive\\Desktop\\Login.png"; // Corrected file path
            //pictureBox1.Image = Image.FromFile(filePath);
        }
    }
}
