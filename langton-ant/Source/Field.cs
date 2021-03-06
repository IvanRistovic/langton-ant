﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace LangtonAnt
{
    class Field
    {
        // Field unit size
        private const int CellSize = 10;

        // Primary and secondary field colors, of which secondary can be custom
        public Color PrimaryColor { get; private set; }
        public Color SecondaryColor { get; private set; }

        // Ant that is currently on the field
        private Ant Ant;

        // Our field map
        private Label[,] Map;
        private int MapSize;


        public Field(Form form, int size)
        {
            PrimaryColor = Color.White;
            SecondaryColor = Color.Gray;

            Map = new Label[size, size];
            MapSize = size;

            object _lock = new object();
            
            // Drawing field
            Parallel.For(0, size, i => {
                Parallel.For(0, size, j => {
                    // Creating new label with given size and setting attributes
                    Map[i, j] = new Label() {
                        Size = new Size(CellSize, CellSize),
                        Location = new Point((j + 1) * CellSize, (i + 3) * CellSize),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = PrimaryColor,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 5, FontStyle.Bold),
                        ForeColor = Color.Red
                    };
                    Map[i, j].Click += FieldLabel_Click;

                    // Saving label position in map
                    Map[i, j].Tag = new LabelPos(i, j);

                    lock (_lock) {
                        // Adding created label to control
                        form.Controls.Add(Map[i, j]);
                    }
                });
            });
        }
        
        public void RandomizeFieldSymmetric()
        {
            // For random number generating
            Random rand = new Random();

            // We only need to draw one half, the other one is symmetric
            int limit = MapSize / 2 + 1;
            Parallel.For(0, MapSize, i => {
                Parallel.For(0, MapSize, j => {
                    if (rand.Next() % 2 == 0)
                        Map[i, j].BackColor = Map[i, MapSize - j - 1].BackColor = PrimaryColor;
                    else
                        Map[i, j].BackColor = Map[i, MapSize - j - 1].BackColor = SecondaryColor;
                });
            });
        }

        public void RandomizeFieldAsymmetric()
        {
            // For random number generating
            Random rand = new Random();
            
            Parallel.For(0, MapSize, i => {
                Parallel.For(0, MapSize, j => {
                    if (rand.Next() % 2 == 0)
                        Map[i, j].BackColor = PrimaryColor;
                    else
                        Map[i, j].BackColor = SecondaryColor;
                });
            });
        }

        public void ClearField()
        {
            // Clears field by setting color to primary for each label
            Parallel.For(0, MapSize, i => {
                Parallel.For(0, MapSize, j => {
                    Map[i, j].BackColor = PrimaryColor;
                });
            });
        }

        public void SetAntAt(int x, int y)
        {
            Map[x, y].Text = "+";
        }

        public void RemoveAnt(int x, int y)
        {
            Map[x, y].Text = "";
        }

        public void FlipColor(int x, int y)
        {
            if (Map[x, y].BackColor == Color.White)
                Map[x, y].BackColor = SecondaryColor;
            else
                Map[x, y].BackColor = PrimaryColor;
        }

        public Color GetColor(int x, int y)
        {
            return Map[x, y].BackColor;
        }

        public void SetSecondaryColor(Color color)
        {
            SecondaryColor = color;
        }

        private void FieldLabel_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            MouseEventArgs me = (MouseEventArgs)e;
            LabelPos position;

            if (me.Button == MouseButtons.Left)
                // In case of left click, we flip color
                if (lbl.BackColor == Color.White)
                    lbl.BackColor = SecondaryColor;
                else
                    lbl.BackColor = PrimaryColor;
            else if (me.Button == MouseButtons.Right) {
                // In case of right click, set ant at that label position
                position = (LabelPos)lbl.Tag;
                Ant.SetXpos(position.getX());
                Ant.SetYpos(position.getY());
            } else
                return;
        }

        public void SetAnt(Ant ant)
        {
            this.Ant = ant;
        }

        public void SetFieldFromPattern(FieldPattern fp)
        {
            Parallel.For(0, fp.Size, i => {
                Parallel.For(0, fp.Size, j => {
                    if (fp.Colored[i, j])
                        Map[i, j].BackColor = SecondaryColor;
                    else
                        Map[i, j].BackColor = PrimaryColor;
                });
            });
        }
    }
}
