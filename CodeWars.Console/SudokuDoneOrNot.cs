using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.ConsoleApp
{
    public class SudokuDoneOrNot
    {
        public static string DoneOrNot(int[][] input)
        {
            for (int i = 0; i<9; i++)
            {
                var valid = true;
                valid = valid && ValidateRegion(input[i]);
                valid = valid && ValidateRegion(input.Select(l => l[i]));
                valid = valid && ValidateRegion(GetSquare(i, input));

                if (!valid) 
                    return "Try again!";
            }

            return "Finished!";
        }

        private static IEnumerable<int> GetSquare(int i, int[][] input)
            => input.Skip((i / 3) * 3).Take(3)
                .SelectMany(l => l.Skip(i % 3 * 3).Take(3));

        private static bool ValidateRegion(IEnumerable<int> input)
            => input.Distinct().Count() == 9;
    }
}
