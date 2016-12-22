using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langton_ant
{

    /* This class is used to save position for each label in field array */

    class LabelPos
    {
        private int x;
        private int y;

        public LabelPos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}
