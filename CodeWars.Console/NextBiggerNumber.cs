using System;
using System.Linq;

namespace CodeWars.ConsoleApp
{
    public class NextBiggerNumber
    {
        public static long GetNextBiggerNumber(long n)
        {
            var arr = n.ToString().ToArray();
            var minI = int.MaxValue;
            var maxJ = -1;
            bool found = false;

            for (int i = arr.Length-1; i > 0; i--)
            {
                for (int j = i-1; j>= 0; j--)
                {
                    if (arr[i] > arr[j] && j > maxJ)
                    {
                        minI = i;
                        maxJ = j;
                        found = true;
                    }
                }
            }
            if (!found) return -1;

            var temp = arr[minI];
            arr[minI] = arr[maxJ];
            arr[maxJ] = temp;
            var s = string.Join("", arr.Take(maxJ + 1));
            s += string.Join("", arr.Skip(maxJ + 1).OrderBy(v => v));
            return long.Parse(s);
        }
    }
}
