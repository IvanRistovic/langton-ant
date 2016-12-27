namespace langton_ant
{
    class Ant
    {
        // Ant position
        private int XPos;
        private int YPos;

        // Direction
        private int Direction;

        // Map on which the ant is moving
        private Field Map;
        private int MapSize;


        public Ant(Field field, int fieldSize, int xstart, int ystart)
        {
            Map = field;
            MapSize = fieldSize;
            XPos = xstart;
            YPos = ystart;
            Direction = 0;
            Map.SetAntAt(XPos, YPos);
        }

        public bool Move()
        {
            // At a black square, turn 90° left, flip the color of the square, move forward
            // At a white square, turn 90° right, flip the color of the square, move forward
            
            if (Map.GetColor(XPos, YPos) == Field.PrimaryColor) {
                if (Direction == 0)
                    Direction = 3;
                else
                    Direction--;
            } else {
                if (Direction == 3)
                    Direction = 0;
                else
                    Direction++;
            }

            // Flipping color
            Map.FlipColor(XPos, YPos);

            // Removing ant from current location
            Map.RemoveAnt(XPos, YPos);

            // Deciding next ant location
            switch (Direction) {
                case 0:
                    if (YPos == 0)
                        return false;
                    YPos--;
                    break;
                case 1:
                    if (XPos == MapSize - 1)
                        return false;
                    XPos++;
                    break;
                case 2:
                    if (YPos == MapSize - 1)
                        return false;
                    YPos++;
                    break;
                case 3:
                    if (XPos == 0)
                        return false;
                    XPos--;
                    break;
                default:
                    return false;
            }

            // Setting ant at new location
            Map.SetAntAt(XPos, YPos);

            return true;
        }

        public void ResetAntPos()
        {
            // Removing ant from current cell
            Map.RemoveAnt(XPos, YPos);

            // Placing ant on default location
            XPos = YPos = MapSize / 2;
            Map.SetAntAt(XPos, YPos);

            // Resetting direction
            Direction = 0;
        }

        public void SetXpos(int x)
        {
            Map.RemoveAnt(XPos, YPos);
            XPos = x;
            Map.SetAntAt(XPos, YPos);
        }

        public void SetYpos(int y)
        {
            Map.RemoveAnt(XPos, YPos);
            YPos = y;
            Map.SetAntAt(XPos, YPos);
        }
    }
}
