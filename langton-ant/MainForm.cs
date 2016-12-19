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

        public MainForm()
        {
            InitializeComponent();

            /* After initializing our form, we create the field */
            Field map = new Field(this, MAP_SIZE);
        }

    }
}
