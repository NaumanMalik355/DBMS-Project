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
    public partial class Manage_Advisor : Form
    {
        public Manage_Advisor()
        {
            InitializeComponent();
        }

        private void Manage_Advisor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectADataSet3.Advisor' table. You can move, or remove it, as needed.
            this.advisorTableAdapter.Fill(this.projectADataSet3.Advisor);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();
        }
    }
}
