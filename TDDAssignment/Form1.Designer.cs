namespace TDDAssignment
{
    partial class Owoda
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.car = new System.Windows.Forms.RadioButton();
            this.bus = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.noOftrips = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tollDue = new System.Windows.Forms.TextBox();
            this.yes = new System.Windows.Forms.RadioButton();
            this.no = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Vehicle Type";
            // 
            // car
            // 
            this.car.AutoSize = true;
            this.car.Location = new System.Drawing.Point(258, 70);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(59, 24);
            this.car.TabIndex = 2;
            this.car.TabStop = true;
            this.car.Text = "Car";
            this.car.UseVisualStyleBackColor = true;
            this.car.CheckedChanged += new System.EventHandler(this.car_CheckedChanged);
            // 
            // bus
            // 
            this.bus.AutoSize = true;
            this.bus.Location = new System.Drawing.Point(442, 70);
            this.bus.Name = "bus";
            this.bus.Size = new System.Drawing.Size(62, 24);
            this.bus.TabIndex = 3;
            this.bus.TabStop = true;
            this.bus.Text = "Bus";
            this.bus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter number of Trips";
            // 
            // noOftrips
            // 
            this.noOftrips.Location = new System.Drawing.Point(271, 143);
            this.noOftrips.Name = "noOftrips";
            this.noOftrips.Size = new System.Drawing.Size(100, 26);
            this.noOftrips.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Are you a N.U.R.T.W Member?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Toll Due";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tollDue
            // 
            this.tollDue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tollDue.Location = new System.Drawing.Point(404, 256);
            this.tollDue.Name = "tollDue";
            this.tollDue.Size = new System.Drawing.Size(100, 26);
            this.tollDue.TabIndex = 8;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(63, 3);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(62, 24);
            this.yes.TabIndex = 9;
            this.yes.TabStop = true;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(3, 3);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(54, 24);
            this.no.TabIndex = 10;
            this.no.TabStop = true;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.no);
            this.flowLayoutPanel1.Controls.Add(this.yes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(271, 186);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 39);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // Owoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tollDue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noOftrips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bus);
            this.Controls.Add(this.car);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Owoda";
            this.Text = "OWO DA ";
            this.Load += new System.EventHandler(this.Owoda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton car;
        private System.Windows.Forms.RadioButton bus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noOftrips;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tollDue;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.RadioButton no;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

