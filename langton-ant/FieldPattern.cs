using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langton_ant
{
    class FieldPattern
    {
        public static bool[,] Colored;
        public static int Size;

        public FieldPattern(string fileName, int size)
        {
            string[] fileContent = System.IO.File.ReadAllLines(@fileName);

            Size = size;
            Colored = new bool[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++) {
                    if (fileContent[i][j] == '1')
                        Colored[i, j] = true;
                    else
                        Colored[i, j] = false;
                }
        }
    }
}
