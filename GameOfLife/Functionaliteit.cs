using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class Functionaliteit
    {
        public static bool[,] Step(bool[,] grid, int[] nieuwLeven, int[] blijftLeven, int radius)
        {
            bool[,] newGrid = new bool[grid.GetLength(0), grid.GetLength(1)];

            // Calculate new step
            for (int x = 0; x < grid.GetLength(0); x++)
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    int amountOfNeighbours = 0;

                    // Calculate amount of neighbours
                    for (int xmod = -1 * radius; xmod <= radius; xmod++)
                        for (int ymod = -1 * radius; ymod <= radius; ymod++)
                            if (xmod != 0 || ymod != 0)
                            {
                                int neighbourX = endlessConverter(x + xmod, grid.GetLength(0));
                                int neighbourY = endlessConverter(y + ymod, grid.GetLength(1));

                                if (neighbourX >= 0 && neighbourX < grid.GetLength(0) && neighbourY >= 0 && neighbourY < grid.GetLength(1))
                                    if (grid[neighbourX, neighbourY] == true) amountOfNeighbours++;
                            }

                    if (grid[x, y] == true)
                    {
                        // If there are 2 or 3 surrounding neighbours when alive, survive
                        if(blijftLeven.Contains(amountOfNeighbours))
                            newGrid[x, y] = true;
                    }
                    else if (nieuwLeven.Contains(amountOfNeighbours))
                    {
                        // If there are 3 surrounding neighbours when dead, revive
                        newGrid[x, y] = true;
                    }
                    else
                    {
                        // Else, cell dies out.
                        newGrid[x, y] = false;
                    }
                }
            return newGrid;
        }

        // Method for calculating the location on an "infinite" plane 
        public static int endlessConverter(int number, int size)
        {
            if (number < 0)
                return size - Math.Abs(number);
            else if (number > size - 1)
                return Math.Abs(number) - size;
            else
                return number;
        }

    }
}
