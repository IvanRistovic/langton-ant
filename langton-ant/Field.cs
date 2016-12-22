using System;
using System.Windows.Forms;
using System.Drawing;

namespace langton_ant
{
    class Field
    {
        private const int CELL_SIZE = 10;
        public static Color primaryColor = Color.White;
        public static Color secondaryColor = Color.Gray;
        private Color antColor = Color.Red;

        private Ant ant;

        private Label[,] map;
        private int mapSize;

        public Field(Form form, int size)
        {
            map = new Label[size, size];
            mapSize = size;

            // Starting location
            int horizotal = CELL_SIZE;
            int vertical = 3 * CELL_SIZE;

            // Drawing field
            for (int i = 0; i < size; i++) {

                for (int j = 0; j < size; j++) {

                    // Creating new label with given size
                    map[i, j] = new Label();
                    map[i, j].Size = new Size(CELL_SIZE, CELL_SIZE);
                    map[i, j].Location = new Point(horizotal, vertical);
                    map[i, j].BorderStyle = BorderStyle.FixedSingle;
                    map[i, j].BackColor = primaryColor;
                    map[i, j].AutoSize = false;
                    map[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    map[i, j].Font = new Font("Arial", 5, FontStyle.Bold);
                    map[i, j].ForeColor = Color.Red;
                    map[i, j].Click += lblFieldLabel_Click;
                    map[i, j].Tag = new LabelPos(i, j);

                    // Advancing to next column
                    horizotal += CELL_SIZE;

                    // Adding created label to control
                    form.Controls.Add(map[i, j]);
                }

                // Advancing to next row, resetting column position
                horizotal = CELL_SIZE;
                vertical += CELL_SIZE;
            }
        }
        
        public void randomizeFieldSymmetric()
        {
            // For random number generating
            Random rand = new Random();

            int limit = mapSize / 2 + 1;

            for (int i = 0; i < mapSize; i++) {
                for (int j = 0; j < limit; j++) {

                    // Choosing color for our field randomly from two possible colors
                    if (rand.Next() % 2 == 0)
                        map[i, j].BackColor = map[i, mapSize - j - 1].BackColor = primaryColor;
                    else
                        map[i, j].BackColor = map[i, mapSize - j - 1].BackColor = secondaryColor;

                }
            }
        }

        public void randomizeFieldAsymmetric()
        {
            // For random number generating
            Random rand = new Random();

            for (int i = 0; i < mapSize; i++) {
                for (int j = 0; j < mapSize; j++) {
                    
                    // Choosing color for our field randomly from two possible colors
                    if (rand.Next() % 2 == 0)
                        map[i, j].BackColor = primaryColor;
                    else
                        map[i, j].BackColor = secondaryColor;

                }
            }
        }

        public void clearField()
        {
            for (int i = 0; i < mapSize; i++) {
                for (int j = 0; j < mapSize; j++) {
                    map[i, j].BackColor = primaryColor;
                }
            }
        }

        public void setAntAt(int x, int y)
        {
            map[x, y].Text = "+";
        }

        public void removeAnt(int x, int y)
        {
            map[x, y].Text = "";
        }

        public void flipColor(int x, int y)
        {
            if (map[x, y].BackColor == Color.White)
                map[x, y].BackColor = secondaryColor;
            else
                map[x, y].BackColor = primaryColor;
        }

        public Color getColor(int x, int y)
        {
            return map[x, y].BackColor;
        }

        private void lblFieldLabel_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            MouseEventArgs me = (MouseEventArgs)e;
            LabelPos position;

            if (me.Button == System.Windows.Forms.MouseButtons.Left)
                if (lbl.BackColor == Color.White)
                    lbl.BackColor = secondaryColor;
                else
                    lbl.BackColor = primaryColor;
            else if (me.Button == System.Windows.Forms.MouseButtons.Right) {
                position = (LabelPos)lbl.Tag;
                ant.setXpos(position.getX());
                ant.setYpos(position.getY());
            } else
                return;
        }

        public void setAnt(Ant ant)
        {
            this.ant = ant;
        }
    }
}
