using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langton_ant
{
    class FieldPattern
    {
        public static bool[,] colored;
        public static int size;

        public FieldPattern(string fileName, int size)
        {
            string[] fileContent = System.IO.File.ReadAllLines(@fileName);

            FieldPattern.size = size;
            colored = new bool[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++) {
                    if (fileContent[i][j] == '1')
                        colored[i, j] = true;
                    else
                        colored[i, j] = false;
                }
        }
    }
}
