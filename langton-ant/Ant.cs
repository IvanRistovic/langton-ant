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
            } else {
                if (direction == 3)
                    direction = 0;
                else
                    direction++;
            }

            // Flipping color
            map.flipColor(xpos, ypos);

            // Removing ant from current location
            map.removeAnt(xpos, ypos);

            // Deciding next ant location
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

            // Setting ant at new location
            map.setAnt(xpos, ypos);

            return true;
        }

        public void resetAntPos()
        {
            // Removing ant from current cell
            map.removeAnt(xpos, ypos);

            // Placing ant on default location
            xpos = ypos = mapSize / 2;
            map.setAnt(xpos, ypos);
        }
    }
}
