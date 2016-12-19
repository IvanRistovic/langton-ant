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

        // Our hero, named langton
        private Ant langton;


        public MainForm()
        {
            // Form initialization
            InitializeComponent();

            // After initializing our form, we create the field
            Field map = new Field(this, MAP_SIZE);

            // Creating ant
            langton = new Ant(map, MAP_SIZE, MAP_SIZE / 2, MAP_SIZE / 2);
        }

        private void tmrMoveTimer_Tick(object sender, EventArgs e)
        {
            // If ant movement fails, stop the animation
            if (langton.move() == false)
                tmrMoveTimer.Enabled = false;
        }
    }
}
