namespace langton_ant
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tmrMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAntPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.chooseCellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symmetricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assymetricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptn1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdColorChooser = new System.Windows.Forms.ColorDialog();
            this.tbSpeedBar = new System.Windows.Forms.TrackBar();
            this.lblSpeedLabel = new System.Windows.Forms.Label();
            this.lblStepLabel = new System.Windows.Forms.Label();
            this.tbStepBox = new System.Windows.Forms.TextBox();
            this.tbSpeedBox = new System.Windows.Forms.TextBox();
            this.lblMPS = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMoveTimer
            // 
            this.tmrMoveTimer.Interval = 40;
            this.tmrMoveTimer.Tick += new System.EventHandler(this.tmrMoveTimer_Tick);
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fieldToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(684, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.resetAntPositionToolStripMenuItem,
            this.toolStripMenuItem2,
            this.chooseCellColorToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // resetAntPositionToolStripMenuItem
            // 
            this.resetAntPositionToolStripMenuItem.Name = "resetAntPositionToolStripMenuItem";
            this.resetAntPositionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.resetAntPositionToolStripMenuItem.Text = "Reset Ant position";
            this.resetAntPositionToolStripMenuItem.Click += new System.EventHandler(this.resetAntPositionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // chooseCellColorToolStripMenuItem
            // 
            this.chooseCellColorToolStripMenuItem.Name = "chooseCellColorToolStripMenuItem";
            this.chooseCellColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.chooseCellColorToolStripMenuItem.Text = "Choose cell color";
            this.chooseCellColorToolStripMenuItem.Click += new System.EventHandler(this.chooseCellColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fieldToolStripMenuItem
            // 
            this.fieldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blankToolStripMenuItem,
            this.randomizeToolStripMenuItem,
            this.patternToolStripMenuItem});
            this.fieldToolStripMenuItem.Name = "fieldToolStripMenuItem";
            this.fieldToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fieldToolStripMenuItem.Text = "Field";
            // 
            // blankToolStripMenuItem
            // 
            this.blankToolStripMenuItem.Name = "blankToolStripMenuItem";
            this.blankToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.blankToolStripMenuItem.Text = "Blank";
            this.blankToolStripMenuItem.Click += new System.EventHandler(this.blankToolStripMenuItem_Click);
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symmetricToolStripMenuItem,
            this.assymetricToolStripMenuItem});
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            // 
            // symmetricToolStripMenuItem
            // 
            this.symmetricToolStripMenuItem.Name = "symmetricToolStripMenuItem";
            this.symmetricToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.symmetricToolStripMenuItem.Text = "Symmetric";
            this.symmetricToolStripMenuItem.Click += new System.EventHandler(this.symmetricToolStripMenuItem_Click);
            // 
            // assymetricToolStripMenuItem
            // 
            this.assymetricToolStripMenuItem.Name = "assymetricToolStripMenuItem";
            this.assymetricToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.assymetricToolStripMenuItem.Text = "Asymmetric";
            this.assymetricToolStripMenuItem.Click += new System.EventHandler(this.assymetricToolStripMenuItem_Click);
            // 
            // patternToolStripMenuItem
            // 
            this.patternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ptn1ToolStripMenuItem});
            this.patternToolStripMenuItem.Name = "patternToolStripMenuItem";
            this.patternToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.patternToolStripMenuItem.Text = "Pattern";
            // 
            // ptn1ToolStripMenuItem
            // 
            this.ptn1ToolStripMenuItem.Name = "ptn1ToolStripMenuItem";
            this.ptn1ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ptn1ToolStripMenuItem.Text = "Pattern 1";
            this.ptn1ToolStripMenuItem.Click += new System.EventHandler(this.ptn1ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cdColorChooser
            // 
            this.cdColorChooser.Color = System.Drawing.Color.Gray;
            this.cdColorChooser.FullOpen = true;
            // 
            // tbSpeedBar
            // 
            this.tbSpeedBar.Location = new System.Drawing.Point(635, 92);
            this.tbSpeedBar.Maximum = 80;
            this.tbSpeedBar.Minimum = 1;
            this.tbSpeedBar.Name = "tbSpeedBar";
            this.tbSpeedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSpeedBar.Size = new System.Drawing.Size(45, 315);
            this.tbSpeedBar.TabIndex = 1;
            this.tbSpeedBar.Value = 25;
            this.tbSpeedBar.Scroll += new System.EventHandler(this.tbSpeedBar_Scroll);
            // 
            // lblSpeedLabel
            // 
            this.lblSpeedLabel.AutoSize = true;
            this.lblSpeedLabel.Location = new System.Drawing.Point(631, 33);
            this.lblSpeedLabel.Name = "lblSpeedLabel";
            this.lblSpeedLabel.Size = new System.Drawing.Size(41, 13);
            this.lblSpeedLabel.TabIndex = 2;
            this.lblSpeedLabel.Text = "Speed:";
            // 
            // lblStepLabel
            // 
            this.lblStepLabel.AutoSize = true;
            this.lblStepLabel.Location = new System.Drawing.Point(636, 410);
            this.lblStepLabel.Name = "lblStepLabel";
            this.lblStepLabel.Size = new System.Drawing.Size(32, 13);
            this.lblStepLabel.TabIndex = 3;
            this.lblStepLabel.Text = "Step:";
            // 
            // tbStepBox
            // 
            this.tbStepBox.Location = new System.Drawing.Point(623, 426);
            this.tbStepBox.Name = "tbStepBox";
            this.tbStepBox.ReadOnly = true;
            this.tbStepBox.Size = new System.Drawing.Size(60, 20);
            this.tbStepBox.TabIndex = 4;
            this.tbStepBox.Text = "0";
            this.tbStepBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSpeedBox
            // 
            this.tbSpeedBox.Location = new System.Drawing.Point(634, 49);
            this.tbSpeedBox.Name = "tbSpeedBox";
            this.tbSpeedBox.ReadOnly = true;
            this.tbSpeedBox.Size = new System.Drawing.Size(37, 20);
            this.tbSpeedBox.TabIndex = 5;
            this.tbSpeedBox.Text = "25";
            this.tbSpeedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMPS
            // 
            this.lblMPS.AutoSize = true;
            this.lblMPS.Location = new System.Drawing.Point(631, 72);
            this.lblMPS.Name = "lblMPS";
            this.lblMPS.Size = new System.Drawing.Size(43, 13);
            this.lblMPS.TabIndex = 6;
            this.lblMPS.Text = "(in mps)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 652);
            this.Controls.Add(this.lblMPS);
            this.Controls.Add(this.tbSpeedBox);
            this.Controls.Add(this.tbStepBox);
            this.Controls.Add(this.lblStepLabel);
            this.Controls.Add(this.lblSpeedLabel);
            this.Controls.Add(this.tbSpeedBar);
            this.Controls.Add(this.msMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 490);
            this.Name = "MainForm";
            this.Text = "Langton\'s Ant";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMoveTimer;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptn1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseCellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ColorDialog cdColorChooser;
        private System.Windows.Forms.ToolStripMenuItem resetAntPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symmetricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assymetricToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.TrackBar tbSpeedBar;
        private System.Windows.Forms.Label lblSpeedLabel;
        private System.Windows.Forms.Label lblStepLabel;
        private System.Windows.Forms.TextBox tbStepBox;
        private System.Windows.Forms.TextBox tbSpeedBox;
        private System.Windows.Forms.Label lblMPS;
    }
}

