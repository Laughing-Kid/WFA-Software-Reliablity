
namespace WFA_Test
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.predictionModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMSAAPM2ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capabilityMaturityIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponentialModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutDefectDensityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predictionModelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // predictionModelsToolStripMenuItem
            // 
            this.predictionModelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aMSAAPM2ModelToolStripMenuItem,
            this.applicationTypeToolStripMenuItem,
            this.capabilityMaturityIndexToolStripMenuItem,
            this.exponentialModelToolStripMenuItem,
            this.shortcutDefectDensityToolStripMenuItem});
            this.predictionModelsToolStripMenuItem.Name = "predictionModelsToolStripMenuItem";
            this.predictionModelsToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.predictionModelsToolStripMenuItem.Text = "Prediction Models";
            this.predictionModelsToolStripMenuItem.Click += new System.EventHandler(this.predictionModelsToolStripMenuItem_Click);
            // 
            // aMSAAPM2ModelToolStripMenuItem
            // 
            this.aMSAAPM2ModelToolStripMenuItem.Enabled = false;
            this.aMSAAPM2ModelToolStripMenuItem.Name = "aMSAAPM2ModelToolStripMenuItem";
            this.aMSAAPM2ModelToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.aMSAAPM2ModelToolStripMenuItem.Text = "AMSAA PM2 Model";
            this.aMSAAPM2ModelToolStripMenuItem.Click += new System.EventHandler(this.aMSAAPM2ModelToolStripMenuItem_Click);
            // 
            // applicationTypeToolStripMenuItem
            // 
            this.applicationTypeToolStripMenuItem.Name = "applicationTypeToolStripMenuItem";
            this.applicationTypeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.applicationTypeToolStripMenuItem.Text = "Application Type";
            this.applicationTypeToolStripMenuItem.Click += new System.EventHandler(this.applicationTypeToolStripMenuItem_Click);
            // 
            // capabilityMaturityIndexToolStripMenuItem
            // 
            this.capabilityMaturityIndexToolStripMenuItem.Name = "capabilityMaturityIndexToolStripMenuItem";
            this.capabilityMaturityIndexToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.capabilityMaturityIndexToolStripMenuItem.Text = "Capability Maturity Index";
            this.capabilityMaturityIndexToolStripMenuItem.Click += new System.EventHandler(this.capabilityMaturityIndexToolStripMenuItem_Click_1);
            // 
            // exponentialModelToolStripMenuItem
            // 
            this.exponentialModelToolStripMenuItem.Enabled = false;
            this.exponentialModelToolStripMenuItem.Name = "exponentialModelToolStripMenuItem";
            this.exponentialModelToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.exponentialModelToolStripMenuItem.Text = "Exponential Model";
            this.exponentialModelToolStripMenuItem.Click += new System.EventHandler(this.exponentialModelToolStripMenuItem_Click);
            // 
            // shortcutDefectDensityToolStripMenuItem
            // 
            this.shortcutDefectDensityToolStripMenuItem.Name = "shortcutDefectDensityToolStripMenuItem";
            this.shortcutDefectDensityToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.shortcutDefectDensityToolStripMenuItem.Text = "Shortcut Defect Density";
            this.shortcutDefectDensityToolStripMenuItem.Click += new System.EventHandler(this.shortcutDefectDensityToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(97, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 238);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(35, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 24);
            this.button5.TabIndex = 2;
            this.button5.Text = "Exponential Model";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 24);
            this.button4.TabIndex = 2;
            this.button4.Text = "Shortcut Defect Density";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Capability Maturity Index";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Application Type";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(35, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "AMSAA PM2 Model";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(397, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 390);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(433, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 84);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Model";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem predictionModelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMSAAPM2ModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capabilityMaturityIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exponentialModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutDefectDensityToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

