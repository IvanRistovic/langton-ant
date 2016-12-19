using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace langton_ant
{
    class Ant
    {
        // Ant position
        private int xpos;
        private int ypos;

        // Direction
        private int direction;

        // Map on which the ant is moving
        private Field map;
        private int mapSize;

        public Ant(Field field, int fieldSize, int xstart, int ystart)
        {
            map = field;
            mapSize = fieldSize;
            xpos = xstart;
            ypos = ystart;
            direction = 0;
            map.setAnt(xpos, ypos);
        }

        public bool move()
        {
            // At a black square, turn 90° left, flip the color of the square, move forward
            // At a white square, turn 90° right, flip the color of the square, move forward
            
            if (map.getColor(xpos, ypos) == Field.primaryColor) {

                if (direction == 0)
                    direction = 3;
                else
                    direction--;

                // Flipping color
                map.setSecondary(xpos, ypos);

            } else {

                if (direction == 3)
                    direction = 0;
                else
                    direction++;

                // Flipping color
                map.setPrimary(xpos, ypos);

            }

            // Moving ant
            map.removeAnt(xpos, ypos);

            switch (direction) {
                case 0:
                    if (ypos == 0)
                        return false;
                    ypos--;
                    break;
                case 1:
                    if (xpos == mapSize - 1)
                        return false;
                    xpos++;
                    break;
                case 2:
                    if (ypos == mapSize - 1)
                        return false;
                    ypos++;
                    break;
                case 3:
                    if (xpos == 0)
                        return false;
                    xpos--;
                    break;
                default:
                    return false;
            }

            map.setAnt(xpos, ypos);

            return true;
        }
    }
}
