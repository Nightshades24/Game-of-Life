using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife;

public class GameOfLife
{
    private bool[,] grid;

    public GameOfLife(int templateNumber)
    {
        switch(templateNumber)
        {
            case 0:
                // Initialize empty "dead" grid
                grid = new bool[40, 40];
                for(int i = 0; i < grid.GetLength(0); i++)
                    for(int j = 0; j < grid.GetLength(1); j++)
                        grid[i, j] = false;

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
                
                break; 
        }
    }
        
    public void Step()
    {
        bool[,] newGrid = new bool[grid.GetLength(0), grid.GetLength(1)];

        // Calculate new step
        for (int x = 0; x < grid.GetLength(0); x++)
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                int amountOfNeighbours = 0;

                // Calculate amount of neighbours
                for (int xmod = -1; xmod <= 1; xmod++)
                    for (int ymod = -1; ymod <= 1; ymod++)
                        if (xmod != 0 || ymod != 0)
                        {
                            int neighbourX = x + xmod;
                            int neighbourY = y + ymod;

                            if (neighbourX >= 0 && neighbourX < grid.GetLength(0) && neighbourY >= 0 && neighbourY < grid.GetLength(1))
                                if (grid[neighbourX, neighbourY] == true) amountOfNeighbours++;
                        }
                    
                if (grid[x, y] == true)
                {
                    // If there are 2 or 3 surrounding neighbours when alive, survive
                    if (amountOfNeighbours == 2 || amountOfNeighbours == 3) newGrid[x, y] = true;
                }
                else if (amountOfNeighbours == 3)
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
        grid = newGrid;
    }

    public void Print()
    {
        string result = "";

        for (int y = 0; y < grid.GetLength(1); y++)
        {
            string row = "";

            for (int x = 0; x < grid.GetLength(0); x++)
            {
                if(grid[x, y] == true)
                {
                    row += "O";
                }
                else
                {
                    row += " ";
                }
            }
            result += row + "\n";
            
        }
        Console.SetCursorPosition(0, Console.WindowTop);
        Console.Write(result);
    }
}