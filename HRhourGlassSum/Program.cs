//  Context 
//Given a  2D Array, :

//1 1 1 0 0 0
//0 1 0 0 0 0
//1 1 1 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0
//We define an hourglass in  to be a subset of values with indices falling in this pattern in 's graphical representation:

//a b c
//  d
//e f g
//There are  hourglasses in , and an hourglass sum is the sum of an hourglass' values.

//Task 
//Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.

//Note: If you have already solved the Java domain's Java 2D Array challenge, you may wish to skip this challenge.

//Input Format

//There are  lines of input, where each line contains  space-separated integers describing 2D Array ; every value in  will be in the inclusive range of  to .

//Constraints

//Output Format

//Print the largest (maximum) hourglass sum found in .

//Sample Input

//1 1 1 0 0 0
//0 1 0 0 0 0
//1 1 1 0 0 0
//0 0 2 4 4 0
//0 0 0 2 0 0
//0 0 1 2 4 0
//Sample Output

//19
//Explanation

// contains the following hourglasses:

//1 1 1   1 1 0   1 0 0   0 0 0
//  1       0       0       0
//1 1 1   1 1 0   1 0 0   0 0 0

//0 1 0   1 0 0   0 0 0   0 0 0
//  1       1       0       0
//0 0 2   0 2 4   2 4 4   4 4 0

//1 1 1   1 1 0   1 0 0   0 0 0
//  0       2       4       4
//0 0 0   0 0 2   0 2 0   2 0 0

//0 0 2   0 2 4   2 4 4   4 4 0
//  0       0       2       0
//0 0 1   0 1 2   1 2 4   2 4 0
//The hourglass with the maximum sum () is:

//2 4 4
//  2
//1 2 4



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRhourGlassSum
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
           

          int max=  maxHourGlass(arr);
          Console.WriteLine(max);
        }

        public static int maxHourGlass(int[][]arr)
        {
            int noRow = arr.GetUpperBound(0);
            int noCol = arr[0].Length;
            int max = getHourGlass(arr, 0, 0);
            //arr has all the data now
            //we will get a hour glass at each position excpept the last two
            for (int i = 0; i <=noRow- 2; i++)
            {
                for (int j = 0; j < noCol - 2; j++)
                {
                   int current = getHourGlass(arr, i, j);
                   max = Math.Max(current, max);
                }

            }
            return max;
        }
        private static int getHourGlass(int[][] arr, int r, int c)
        {
            int sum = 0; ;
            sum+= arr[r][ c] + arr[r][ c + 1] + arr[r][ c + 2] + arr[r + 1][ c + 1] + arr[r + 2][ c] + arr[r + 2][ c + 1] + arr[r + 2][ c + 2];
            return sum;
        }

    }
}
