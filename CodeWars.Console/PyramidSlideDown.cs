using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.ConsoleApp
{
    public class PyramidSlideDown
    {
        //1    1 1
        //2    2 11
        //3    4 121
        //4    8 1331
        //5    16  14641

        public static int LongestSlideDown(int[][] pyramid)
        {
            int[] previousResult = pyramid[0];

            for (int lineInPyramid = 1; lineInPyramid < pyramid.Length; lineInPyramid++)
            {
                int[] currentResult = new int[lineInPyramid+1];

                for (int i = 0; i < pyramid[lineInPyramid].Length; i++)
                {
                    var ancestors = GetAncestors(previousResult, i);
                    
                    currentResult[i] = ancestors.Max() + pyramid[lineInPyramid][i];
                }

                previousResult = currentResult;
            }
            return previousResult.Max();
        }

        private static IEnumerable<int> GetAncestors(int[] previousResult, int i)
        {
            if (i == 0) return new List<int> { previousResult[0] };
            if (i == previousResult.Length) return new List<int> { previousResult[i - 1] };
            return previousResult.Skip(i - 1).Take(2);
        }
    }
}
