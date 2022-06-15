using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class BasePatterns
    {
        public static bool[,] GetPattern(string name, int size)
        {
            // Initialize empty "dead" grid
            bool[,] grid = new bool[size, size];

            switch (name)
            {
                case "Empty":
                    return grid;

                case "Fight":
                    // Spawn living cells
                    grid[1, 5] = true;
                    grid[2, 5] = true;
                    grid[1, 6] = true;
                    grid[2, 6] = true;

                    grid[13, 3] = true;
                    grid[14, 3] = true;
                    grid[12, 4] = true;
                    grid[11, 5] = true;
                    grid[11, 6] = true;
                    grid[11, 7] = true;
                    grid[12, 8] = true;
                    grid[13, 9] = true;
                    grid[14, 9] = true;
                    grid[15, 6] = true;
                    grid[16, 4] = true;
                    grid[17, 5] = true;
                    grid[17, 6] = true;
                    grid[17, 7] = true;
                    grid[16, 8] = true;
                    grid[18, 6] = true;

                    grid[21, 5] = true;
                    grid[21, 4] = true;
                    grid[21, 3] = true;
                    grid[22, 5] = true;
                    grid[22, 4] = true;
                    grid[22, 3] = true;
                    grid[23, 6] = true;
                    grid[23, 2] = true;
                    grid[25, 1] = true;
                    grid[25, 2] = true;
                    grid[25, 6] = true;
                    grid[25, 7] = true;

                    grid[35, 3] = true;
                    grid[35, 4] = true;
                    grid[36, 3] = true;
                    grid[36, 4] = true;
                    return grid;

                case "Glider":
                    grid[1, 3] = true;
                    grid[2, 1] = true;
                    grid[2, 3] = true;
                    grid[3, 2] = true;
                    grid[3, 3] = true;
                    return grid;
            }
            return null;
        }
    }
}
