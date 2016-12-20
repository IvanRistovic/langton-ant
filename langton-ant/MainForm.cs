using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace langton_ant
{
    public partial class MainForm : Form
    {
        // Size of the map
        private const int MAP_SIZE = 20;

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

        private void tmrMoveTimer_Tick(object sender, EventArgs e)
        {
            // If ant movement fails, stop the animation
            if (langton.move() == false)
                tmrMoveTimer.Enabled = false;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrMoveTimer.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrMoveTimer.Enabled = false;
            startToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
        }

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

        private void blankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map.clearField();
        }

        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map.randomizeField();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.Show();
        }
    }
}
