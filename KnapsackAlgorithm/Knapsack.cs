using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackAlgorithm
{
    class Knapsack
    {
        public int Main(int[,,] dp_table, int[,] objects, out bool[] used)
        {
            //calculates Maximum with a dp
            //defines the most rencently added Object
            for (int k = 1; k < dp_table.GetLength(0); k++)
            {
                //defines the maximal weight for the current column
                for(int j = 1; j < dp_table.GetLength(1); j++)
                {
                    //defines the maximal volume for the current entry
                    for(int i = 1; i < dp_table.GetLength(2); i++)
                    {
 
                        //decides whether it is possible to packe the current object into a maxVolume of i and a maxWeight of j
                        if (objects[k-1,2] > i || objects[k - 1, 1]>j)
                        {
                            dp_table[k, j, i] = dp_table[k - 1, i, j];
                        }

                        //checks if we get a new maximum value for a maxVolume of i and a maxWeight of j
                        else if ((dp_table[k-1,j-objects[k-1,1],i-objects[k-1,2]] + objects[k-1,0]) > dp_table[k-1, j, i])
                        {
                            dp_table[k, j, i] = dp_table[k - 1, j - objects[k - 1, 1], i-objects[k - 1, 2]] + objects[k - 1, 0];
                        }

                        //if no new max Value was found
                        else
                        {
                            dp_table[k, j, i] = dp_table[k-1, j, i];
                        }
                    }
                }
            }

            used = new bool[objects.GetLength(0)];

            //decides which elements belong to one possible solution that reaches the max value through backtracking
            int o = dp_table.GetLength(0)-1;
            int m = dp_table.GetLength(1)-1;
            int n = dp_table.GetLength(2)-1;

            while ((o > 0 || m > 0 || n > 0) && dp_table[o,m,n] != 0)
            {
                while (dp_table[o, m, n] == dp_table[o - 1, m, n])
                {
                    o--;
                }
                used[o-1] = true;
                m = m - objects[o - 1, 1];
                n = n - objects[o - 1, 2];
            }
            
            return dp_table[dp_table.GetLength(0) - 1, dp_table.GetLength(1) - 1, dp_table.GetLength(2) - 1];
        }
    }
}
