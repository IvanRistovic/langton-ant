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
        private const int MAP_SIZE = 20;
        private const int CELL_SIZE = 15;

        private Label[,] map;

        public MainForm()
        {
            InitializeComponent();

            /* After initializing our form, we create the field */
            map = new Label[MAP_SIZE, MAP_SIZE];
            CreateField();
        }

        private void CreateField()
        {
            /* Starting location */
            int horizotal = CELL_SIZE;
            int vertical = CELL_SIZE;

            /* Drawing field */
            for (int i = 0; i < MAP_SIZE; i++) {

                for (int j = 0; j < MAP_SIZE; j++) {

                    /* Creating new label with given size */
                    map[i, j] = new Label();
                    map[i, j].Size = new Size(CELL_SIZE, CELL_SIZE);
                    map[i, j].Location = new Point(horizotal, vertical);
                    map[i, j].BorderStyle = BorderStyle.FixedSingle;

                    horizotal += CELL_SIZE;

                    /* Adding created label to control */
                    this.Controls.Add(map[i, j]);
                }

                horizotal = CELL_SIZE;
                vertical += CELL_SIZE;
            }
        }

    }
}
