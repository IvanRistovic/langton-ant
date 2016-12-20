using System;
using System.Drawing;
using System.Windows.Forms;

namespace langton_ant
{
    public partial class MainForm : Form
    {
        // Size of the map
        private const int MAP_SIZE = 31;

        // Our map
        private Field map;

        // Our hero, named langton
        private Ant langton;


        public MainForm()
        {
            // Form initialization
            InitializeComponent();

            // After initializing our form, we create the field
            map = new Field(this, MAP_SIZE);

            // Creating ant
            langton = new Ant(map, MAP_SIZE, MAP_SIZE / 2, MAP_SIZE / 2);
        }


        // Timer tick function
        private void tmrMoveTimer_Tick(object sender, EventArgs e)
        {
            // If ant movement fails, stop the animation
            if (langton.move() == false) {
                stopToolStripMenuItem.PerformClick();
                langton.resetAntPos();
            }
        }

        // File -> Start
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrMoveTimer.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
            fieldToolStripMenuItem.Enabled = false;
            resetAntPositionToolStripMenuItem.Enabled = false;
        }

        // File -> Stop
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrMoveTimer.Enabled = false;
            startToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
            fieldToolStripMenuItem.Enabled = true;
            resetAntPositionToolStripMenuItem.Enabled = true;
        }

        // File -> Reset Ant positon
        private void resetAntPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopToolStripMenuItem.PerformClick();
            langton.resetAntPos();
        }

        // File -> Choose cell color
        private void chooseCellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = cdColorChooser.ShowDialog();
            if (res == DialogResult.OK && cdColorChooser.Color != Color.White) {
                Field.secondaryColor = cdColorChooser.Color;
                map.clearField();
            }
        }

        // File -> Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop) {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            } else {
                // Console app
                System.Environment.Exit(1);
            }
        }

        // Field -> Blank
        private void blankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map.clearField();
        }

        // Field -> Randomize -> Asymmetric
        private void assymetricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map.randomizeFieldAsymmetric();
        }

        // Field -> Randomize -> Symmetric
        private void symmetricToolStripMenuItem_Click(object sender, EventArgs e)
        {
           map.randomizeFieldSymmetric();
        }

        // About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.Show();
        }
    }
}
