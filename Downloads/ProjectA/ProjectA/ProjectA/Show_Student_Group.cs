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
    public partial class Show_Student_Group : Form
    {
        public Show_Student_Group()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Student_Group mg = new Manage_Student_Group();
            this.Hide();
            mg.Show();
        }
    }
}
