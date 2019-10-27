using System.Linq;
using System.Collections.Generic;

namespace CodeWars.ConsoleApp
{
    public static class GetPins
    {

        public static List<string> GetPINs(string observed)
        {
            var numbers = observed.Select(x => int.Parse(x.ToString()));
            var possibilitiesPerSpot = numbers.Select(n => GetAdjacents(n));

            var answers = new List<string>() { "" };

            foreach (var possibilities in possibilitiesPerSpot)
            {
                var newAnswers = new List<string>();

                foreach (var possibility in possibilities)
                {
                    foreach (var answer in answers)
                    {
                        newAnswers.Add(string.Concat(answer, possibility));
                    }
                }

                answers = newAnswers;
            }

            return answers;
        }

        public static List<int> GetAdjacents(int i)
        {
            switch (i)
            {
                case 1: return new List<int>() { 1, 2, 4 };
                case 2: return new List<int>() { 1, 2, 3, 5 };
                case 3: return new List<int>() { 2, 3, 6 };
                case 4: return new List<int>() { 1, 4, 5, 7 };
                case 5: return new List<int>() { 4, 2, 5, 8, 6 };
                case 6: return new List<int>() { 5, 3, 6, 9 };
                case 7: return new List<int>() { 4, 7, 8 };
                case 8: return new List<int>() { 7, 5, 8, 0, 9 };
                case 9: return new List<int>() { 8, 6, 9 };
                case 0: return new List<int>() { 0, 8 };
            }
            return new List<int>();
        }

    }
}
