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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void applicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capabilityMaturityIndexToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void shortcutDefectDensityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            shortcut shortcutWindow = new shortcut(this);
            shortcutWindow.ShowDialog();
        }

        private void aMSAAPM2ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exponentialModelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void predictionModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "The AMSAA PM2 utilizes planning parameters that are directly influenced by program management. PM2 reliability" +
                " growth planning curves primarily consist of two components—an idealized curve, and MTBF targets";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "This model assumes that software defect density is directly related to the application type or industry.";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "This model assumes that software defect density is directly related to the SEI CMMI " +
                "level.";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "This exponential model is used to determine when the predicted defects will become observed faults.";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "This model assumes that the defect density is a function of the number of risks versus " +
                "strengths regarding this release of the software";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            shortcut shortcutWindow = new shortcut(this);
            shortcutWindow.ShowDialog();
        }
    }
}
