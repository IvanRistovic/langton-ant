using System;
using System.Drawing;
using System.Windows.Forms;

namespace LangtonAnt
{
    public partial class MainForm : Form
    {
        // Size of the map
        private const int MAP_SIZE = 61;

        // Our map
        private Field map;

        // Our hero, named langton
        private Ant langton;

        // Move counter
        private int MoveCount = 0;


        public MainForm()
        {
            // Form initialization
            InitializeComponent();
            
            // After initializing our form, we create the field
            map = new Field(this, MAP_SIZE);

            // Creating ant
            langton = new Ant(map, MAP_SIZE, MAP_SIZE / 2, MAP_SIZE / 2);

            map.SetAnt(langton);
        }
        

#pragma warning disable IDE1006 // Naming Styles

        // Timer tick function
        private void tmrMoveTimer_Tick(object sender, EventArgs e)
        {
            // If ant movement fails, stop the animation
            if (langton.Move() == false) {
                mnuMainMenuFileStop.PerformClick();
                langton.ResetAntPos();
                return;
            }

            // Otherwise, update counter
            MoveCount++;
            txtStep.Text = MoveCount.ToString();
        }

        // File -> Start
        private void mnuMainMenuFileStart_Click(object sender, EventArgs e)
        {
            tmrMoveTimer.Enabled = true;
            mnuMainMenuFileStart.Enabled = false;
            mnuMainMenuFileStop.Enabled = true;
            mnuMainMenuField.Enabled = false;
            mnuMainMenuFileReset.Enabled = false;
        }

        // File -> Stop
        private void mnuMainMenuFileStop_Click(object sender, EventArgs e)
        {
            tmrMoveTimer.Enabled = false;
            mnuMainMenuFileStart.Enabled = true;
            mnuMainMenuFileStop.Enabled = false;
            mnuMainMenuField.Enabled = true;
            mnuMainMenuFileReset.Enabled = true;
            MoveCount = 0;
        }

        // File -> Reset Ant positon
        private void mnuMainMenuFileReset_Click(object sender, EventArgs e)
        {
            mnuMainMenuFileStop.PerformClick();
            langton.ResetAntPos();
            MoveCount = 0;
        }

        // File -> Choose cell color
        private void mnuMainMenuFileChooseColor_Click(object sender, EventArgs e)
        {
            DialogResult res = clrdChooseColorDialog.ShowDialog();
            if (res == DialogResult.OK && clrdChooseColorDialog.Color != Color.White) {
                map.SetSecondaryColor(clrdChooseColorDialog.Color);
                map.ClearField();
                langton.ResetAntPos();
            }
        }

        // File -> Exit
        private void mnuMainMenuFileExit_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop) {
                // WinForms app
                Application.Exit();
            } else {
                // Console app
                Environment.Exit(1);
            }
        }

        // Field -> Blank
        private void mnuMainMenuFieldBlank_Click(object sender, EventArgs e)
        {
            map.ClearField();
        }

        // Field -> Randomize -> Asymmetric
        private void mnuMainMenuFieldRandomizeAsymmetric_Click(object sender, EventArgs e)
        {
            map.RandomizeFieldAsymmetric();
        }

        // Field -> Randomize -> Symmetric
        private void mnuMainMenuFieldRandomizeSymmetric_Click(object sender, EventArgs e)
        {
           map.RandomizeFieldSymmetric();
        }

        // Field -> Pattern -> Pattern 1
        private void mnuMainMenuFieldPatternPattern1_Click(object sender, EventArgs e)
        {
            FieldPattern fp = new FieldPattern("test.txt", MAP_SIZE);
            map.SetFieldFromPattern(fp);
        }

        // About
        private void mnuMainMenuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.Show();
        }


        // Speed Bar scroll Action
        private void tbarSpeed_Scroll(object sender, EventArgs e)
        {
            // Changing speed by changing timer interval
            tmrMoveTimer.Interval = 1000 / tbarSpeed.Value;

            // Updating speed text box
            txtSpeed.Text = tbarSpeed.Value.ToString();
        }
    }

#pragma warning restore IDE1006 // Naming Styles

}
