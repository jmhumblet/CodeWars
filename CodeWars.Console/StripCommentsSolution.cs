using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.ConsoleApp
{
    public class StripCommentsSolution
    {
        public static string StripComments(string input, string[] commentSymbols)
        {
            string result = "";

            return string.Join('\n',
                input.Split('\n')
                    .Select(item => item.Split(commentSymbols, StringSplitOptions.None)[0].TrimEnd())
                );
        }
    }
}
