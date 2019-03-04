using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlusMinus(new[]{ -4, 3, -9, 0, 4, 1 });
            StairCase(100);

            Console.ReadKey();
        }

        static int diagonalDifference(int[][] arr)
        {
            var numRowCol = arr[0].Length;
            var primaryDiagonal = 0;
            var secondaryDiagonal = 0;
            for (var num = 0; num < numRowCol; num++)
            {
                primaryDiagonal += arr[num][num];
                secondaryDiagonal += arr[numRowCol - (num + 1)][num];
            }
            return Math.Abs(primaryDiagonal - secondaryDiagonal);
        }

        static void PlusMinus(int[] arr)
        {
            var elementCount = arr.Count();
            var countZero = (float)(arr.Count(n => n == 0));
            var countPositive = (float)(arr.Count(n => n > 0));
            var countNegative = (float)(arr.Count(n => n < 0));

            var ratioZero = countZero / elementCount;
            var ratioPositive = countPositive / elementCount;
            var ratioNegative = countNegative / elementCount;
            Console.WriteLine(string.Format("{0:0.000000}", ratioZero));
            Console.WriteLine(string.Format("{0:0.000000}", ratioPositive));
            Console.WriteLine(string.Format("{0:0.000000}", ratioNegative));
        }

        static void StairCase(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                string ending = new String('#',i);
                Console.WriteLine(ending.PadLeft(n));
            }
        }
    }
}
