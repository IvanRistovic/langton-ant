using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace langton_ant
{
    class Field
    {
        private const int CELL_SIZE = 15;

        private Label[,] map;


        public Field(Form form, int size)
        {
            map = new Label[size, size];

            /* Starting location */
            int horizotal = CELL_SIZE;
            int vertical = CELL_SIZE;

            /* For random number generating */
            Random rand = new Random();

            /* Drawing field */
            for (int i = 0; i < size; i++) {

                for (int j = 0; j < size; j++) {

                    /* Creating new label with given size */
                    map[i, j] = new Label();
                    map[i, j].Size = new Size(CELL_SIZE, CELL_SIZE);
                    map[i, j].Location = new Point(horizotal, vertical);
                    map[i, j].BorderStyle = BorderStyle.FixedSingle;

                    /* Choosing color for our field randomly from two possible colors */
                    if (rand.Next() % 2 == 0)
                        map[i, j].BackColor = Color.Black;
                    else
                        map[i, j].BackColor = Color.White;

                    horizotal += CELL_SIZE;

                    /* Adding created label to control */
                    form.Controls.Add(map[i, j]);
                }

                horizotal = CELL_SIZE;
                vertical += CELL_SIZE;
            }
        }
    }
}
