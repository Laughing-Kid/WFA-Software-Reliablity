using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Test
{
    public partial class shortcut : Form
    {
        private mainMenu mainForm = null;
        public shortcut(Form callingForm)
        {
            mainForm = callingForm as mainMenu;
            InitializeComponent();
        }

        private void shortcut_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainForm.Show();
        }

        private void shortcut_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Con
            groupBox1.
        }
    }
}
