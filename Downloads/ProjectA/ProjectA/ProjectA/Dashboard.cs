using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Student mg = new Manage_Student();
            this.Hide();
            mg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Advisor ma = new Manage_Advisor();
            this.Hide();
            ma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Project mp = new Manage_Project();
            this.Hide();
            mp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Show_Student_Group ssg = new Show_Student_Group();
            this.Hide();
            ssg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manage_Project_Advisor mp = new Manage_Project_Advisor();
            this.Hide();
            mp.Show();
        }
    }
}
