namespace LangtonAnt
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFileStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFileStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFileReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainMenuFileChooseColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuField = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFieldBlank = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFieldRandomize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFieldRandomizeSymmetric = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFieldRandomizeAsymmetric = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFieldPattern = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuFieldPatternPattern1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.clrdChooseColorDialog = new System.Windows.Forms.ColorDialog();
            this.tbarSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeedTitle = new System.Windows.Forms.Label();
            this.lblStepTitle = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblUnitInfo = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMoveTimer
            // 
            this.tmrMoveTimer.Interval = 40;
            this.tmrMoveTimer.Tick += new System.EventHandler(this.tmrMoveTimer_Tick);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuFile,
            this.mnuMainMenuField,
            this.mnuMainMenuHelp});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(684, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuMainMenuFile
            // 
            this.mnuMainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuFileStart,
            this.mnuMainMenuFileStop,
            this.mnuMainMenuFileReset,
            this.mnuMainMenuFileSeparator1,
            this.mnuMainMenuFileChooseColor,
            this.mnuMainMenuFileSeparator2,
            this.mnuMainMenuFileExit});
            this.mnuMainMenuFile.Name = "mnuMainMenuFile";
            this.mnuMainMenuFile.Size = new System.Drawing.Size(50, 20);
            this.mnuMainMenuFile.Text = "Game";
            // 
            // mnuMainMenuFileStart
            // 
            this.mnuMainMenuFileStart.Name = "mnuMainMenuFileStart";
            this.mnuMainMenuFileStart.Size = new System.Drawing.Size(170, 22);
            this.mnuMainMenuFileStart.Text = "Start";
            this.mnuMainMenuFileStart.Click += new System.EventHandler(this.mnuMainMenuFileStart_Click);
            // 
            // mnuMainMenuFileStop
            // 
            this.mnuMainMenuFileStop.Enabled = false;
            this.mnuMainMenuFileStop.Name = "mnuMainMenuFileStop";
            this.mnuMainMenuFileStop.Size = new System.Drawing.Size(170, 22);
            this.mnuMainMenuFileStop.Text = "Stop";
            this.mnuMainMenuFileStop.Click += new System.EventHandler(this.mnuMainMenuFileStop_Click);
            // 
            // mnuMainMenuFileReset
            // 
            this.mnuMainMenuFileReset.Name = "mnuMainMenuFileReset";
            this.mnuMainMenuFileReset.Size = new System.Drawing.Size(170, 22);
            this.mnuMainMenuFileReset.Text = "Reset Ant position";
            this.mnuMainMenuFileReset.Click += new System.EventHandler(this.mnuMainMenuFileReset_Click);
            // 
            // mnuMainMenuFileSeparator1
            // 
            this.mnuMainMenuFileSeparator1.Name = "mnuMainMenuFileSeparator1";
            this.mnuMainMenuFileSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuMainMenuFileChooseColor
            // 
            this.mnuMainMenuFileChooseColor.Name = "mnuMainMenuFileChooseColor";
            this.mnuMainMenuFileChooseColor.Size = new System.Drawing.Size(170, 22);
            this.mnuMainMenuFileChooseColor.Text = "Choose cell color";
            this.mnuMainMenuFileChooseColor.Click += new System.EventHandler(this.mnuMainMenuFileChooseColor_Click);
            // 
            // mnuMainMenuFileSeparator2
            // 
            this.mnuMainMenuFileSeparator2.Name = "mnuMainMenuFileSeparator2";
            this.mnuMainMenuFileSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuMainMenuFileExit
            // 
            this.mnuMainMenuFileExit.Name = "mnuMainMenuFileExit";
            this.mnuMainMenuFileExit.Size = new System.Drawing.Size(170, 22);
            this.mnuMainMenuFileExit.Text = "Exit";
            this.mnuMainMenuFileExit.Click += new System.EventHandler(this.mnuMainMenuFileExit_Click);
            // 
            // mnuMainMenuField
            // 
            this.mnuMainMenuField.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuFieldBlank,
            this.mnuMainMenuFieldRandomize,
            this.mnuMainMenuFieldPattern});
            this.mnuMainMenuField.Name = "mnuMainMenuField";
            this.mnuMainMenuField.Size = new System.Drawing.Size(44, 20);
            this.mnuMainMenuField.Text = "Field";
            // 
            // mnuMainMenuFieldBlank
            // 
            this.mnuMainMenuFieldBlank.Name = "mnuMainMenuFieldBlank";
            this.mnuMainMenuFieldBlank.Size = new System.Drawing.Size(152, 22);
            this.mnuMainMenuFieldBlank.Text = "Clear";
            this.mnuMainMenuFieldBlank.Click += new System.EventHandler(this.mnuMainMenuFieldBlank_Click);
            // 
            // mnuMainMenuFieldRandomize
            // 
            this.mnuMainMenuFieldRandomize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuFieldRandomizeSymmetric,
            this.mnuMainMenuFieldRandomizeAsymmetric});
            this.mnuMainMenuFieldRandomize.Name = "mnuMainMenuFieldRandomize";
            this.mnuMainMenuFieldRandomize.Size = new System.Drawing.Size(152, 22);
            this.mnuMainMenuFieldRandomize.Text = "Randomize";
            // 
            // mnuMainMenuFieldRandomizeSymmetric
            // 
            this.mnuMainMenuFieldRandomizeSymmetric.Name = "mnuMainMenuFieldRandomizeSymmetric";
            this.mnuMainMenuFieldRandomizeSymmetric.Size = new System.Drawing.Size(138, 22);
            this.mnuMainMenuFieldRandomizeSymmetric.Text = "Symmetric";
            this.mnuMainMenuFieldRandomizeSymmetric.Click += new System.EventHandler(this.mnuMainMenuFieldRandomizeSymmetric_Click);
            // 
            // mnuMainMenuFieldRandomizeAsymmetric
            // 
            this.mnuMainMenuFieldRandomizeAsymmetric.Name = "mnuMainMenuFieldRandomizeAsymmetric";
            this.mnuMainMenuFieldRandomizeAsymmetric.Size = new System.Drawing.Size(138, 22);
            this.mnuMainMenuFieldRandomizeAsymmetric.Text = "Asymmetric";
            this.mnuMainMenuFieldRandomizeAsymmetric.Click += new System.EventHandler(this.mnuMainMenuFieldRandomizeAsymmetric_Click);
            // 
            // mnuMainMenuFieldPattern
            // 
            this.mnuMainMenuFieldPattern.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuFieldPatternPattern1});
            this.mnuMainMenuFieldPattern.Name = "mnuMainMenuFieldPattern";
            this.mnuMainMenuFieldPattern.Size = new System.Drawing.Size(152, 22);
            this.mnuMainMenuFieldPattern.Text = "Pattern";
            // 
            // mnuMainMenuFieldPatternPattern1
            // 
            this.mnuMainMenuFieldPatternPattern1.Name = "mnuMainMenuFieldPatternPattern1";
            this.mnuMainMenuFieldPatternPattern1.Size = new System.Drawing.Size(121, 22);
            this.mnuMainMenuFieldPatternPattern1.Text = "Pattern 1";
            this.mnuMainMenuFieldPatternPattern1.Click += new System.EventHandler(this.mnuMainMenuFieldPatternPattern1_Click);
            // 
            // mnuMainMenuHelp
            // 
            this.mnuMainMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuHelpAbout});
            this.mnuMainMenuHelp.Name = "mnuMainMenuHelp";
            this.mnuMainMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuMainMenuHelp.Text = "Help";
            // 
            // mnuMainMenuHelpAbout
            // 
            this.mnuMainMenuHelpAbout.Name = "mnuMainMenuHelpAbout";
            this.mnuMainMenuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuMainMenuHelpAbout.Text = "About";
            this.mnuMainMenuHelpAbout.Click += new System.EventHandler(this.mnuMainMenuHelpAbout_Click);
            // 
            // clrdChooseColorDialog
            // 
            this.clrdChooseColorDialog.Color = System.Drawing.Color.Gray;
            this.clrdChooseColorDialog.FullOpen = true;
            // 
            // tbarSpeed
            // 
            this.tbarSpeed.Location = new System.Drawing.Point(635, 92);
            this.tbarSpeed.Maximum = 80;
            this.tbarSpeed.Minimum = 1;
            this.tbarSpeed.Name = "tbarSpeed";
            this.tbarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSpeed.Size = new System.Drawing.Size(45, 315);
            this.tbarSpeed.TabIndex = 1;
            this.tbarSpeed.Value = 25;
            this.tbarSpeed.Scroll += new System.EventHandler(this.tbarSpeed_Scroll);
            // 
            // lblSpeedTitle
            // 
            this.lblSpeedTitle.AutoSize = true;
            this.lblSpeedTitle.Location = new System.Drawing.Point(631, 33);
            this.lblSpeedTitle.Name = "lblSpeedTitle";
            this.lblSpeedTitle.Size = new System.Drawing.Size(41, 13);
            this.lblSpeedTitle.TabIndex = 2;
            this.lblSpeedTitle.Text = "Speed:";
            // 
            // lblStepTitle
            // 
            this.lblStepTitle.AutoSize = true;
            this.lblStepTitle.Location = new System.Drawing.Point(636, 410);
            this.lblStepTitle.Name = "lblStepTitle";
            this.lblStepTitle.Size = new System.Drawing.Size(32, 13);
            this.lblStepTitle.TabIndex = 3;
            this.lblStepTitle.Text = "Step:";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(623, 426);
            this.txtStep.Name = "txtStep";
            this.txtStep.ReadOnly = true;
            this.txtStep.Size = new System.Drawing.Size(60, 20);
            this.txtStep.TabIndex = 4;
            this.txtStep.Text = "0";
            this.txtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(634, 49);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(37, 20);
            this.txtSpeed.TabIndex = 5;
            this.txtSpeed.Text = "25";
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnitInfo
            // 
            this.lblUnitInfo.AutoSize = true;
            this.lblUnitInfo.Location = new System.Drawing.Point(631, 72);
            this.lblUnitInfo.Name = "lblUnitInfo";
            this.lblUnitInfo.Size = new System.Drawing.Size(43, 13);
            this.lblUnitInfo.TabIndex = 6;
            this.lblUnitInfo.Text = "(in mps)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 652);
            this.Controls.Add(this.lblUnitInfo);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.lblStepTitle);
            this.Controls.Add(this.lblSpeedTitle);
            this.Controls.Add(this.tbarSpeed);
            this.Controls.Add(this.mnuMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 490);
            this.Name = "MainForm";
            this.Text = "Langton\'s Ant";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMoveTimer;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuField;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFieldBlank;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFieldRandomize;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFieldPattern;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFieldPatternPattern1;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFileStart;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFileStop;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFileChooseColor;
        private System.Windows.Forms.ColorDialog clrdChooseColorDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFileReset;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFieldRandomizeSymmetric;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFieldRandomizeAsymmetric;
        private System.Windows.Forms.ToolStripSeparator mnuMainMenuFileSeparator1;
        private System.Windows.Forms.ToolStripSeparator mnuMainMenuFileSeparator2;
        private System.Windows.Forms.TrackBar tbarSpeed;
        private System.Windows.Forms.Label lblSpeedTitle;
        private System.Windows.Forms.Label lblStepTitle;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblUnitInfo;
    }
}

