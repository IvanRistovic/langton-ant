using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langton_ant
{
    class FieldPattern
    {
        public bool[,] Colored { get; private set; }
        public int Size { get; private set; }

        public FieldPattern(string fileName, int size)
        {
            string[] fileContent = System.IO.File.ReadAllLines(@fileName);

            Size = size;
            Colored = new bool[size, size];

            Parallel.For(0, size, i => {
                Parallel.For(0, size, j => {
                    if (fileContent[i][j] == '1')
                        Colored[i, j] = true;
                    else
                        Colored[i, j] = false;
                });
            });
        }
    }
}
