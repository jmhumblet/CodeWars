using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.ConsoleApp
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] input)
        {
            if (input[0].Length == 0)
                return Array.Empty<int>();

            var result = new int[input.Length * input.Length];
            var resultCount = 0;


            while (input.Length > 0)
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    result[resultCount++] = input[0][i];
                }
                input = RemoveFirstLineAndRotate(input);
            }

            return result;
        }

        //int33 => int32  int22
        //1 2 3 => 6 9 => 8 7
        //4 5 6    5 8    5 4
        //7 8 9    4 7
        private static int[][] RemoveFirstLineAndRotate(int[][] input)
        {
            
            var length = input[0].Length;
            var innerLength = input.Length - 1;
            var result = new int[length][];
            for (var i = 0; i < length; i++)
            {
                result[i] = new int[innerLength];    
            }

            for (int c = length-1; c>=0 ; c--)
            {
                for (int l = 1; l <= innerLength; l++)
                {
                    result[length - c- 1][l-1] = input[l][c];
                }
            }

            return result;
        }


        public static bool IsHorizontal(int i) => i % 2 == 1;
        public static bool IsForward(int i) => i % 4 / 2 == 1;
    }
}
