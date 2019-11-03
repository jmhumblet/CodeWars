using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.ConsoleApp
{
    public class Boggle
    {
        public Boggle(char[][] board, string word)
        {
            Board = board;
            Word = word;
            // Your code here!
        }

        public char[][] Board { get; }
        public string Word { get; }

        public bool Check()
        {
            for (int i = 0; i < Board.Length; i++)
            {
                for (int j = 0; j < Board.Length; j++)
                {
                    if (Board[i][j] == Word[0])
                        if (CheckNext(new List<(int, int)>() { (i, j) }, i, j, 1))
                            return true;
                }
            }
            return false;
        }

        public bool CheckNext(IEnumerable<(int x, int y)> path, int x, int y, int next)
        {
            if (next == Word.Length)
                return true;

            var letter = Word[next];
            var nextCells = GetValidAdjacentCells(letter, x, y)
                .Where(c => !path.Any(p => p.x == c.x && p.y == c.y));
            
            if (!nextCells.Any())
                return false;
            var result = false;

            foreach (var cell in nextCells)
            {
                var innerPath = new List<(int x, int y)>(path);
                innerPath.Add(cell);
                if (CheckNext(innerPath, cell.x, cell.y, next + 1)) 
                    return true;
            }

            return result;
        }

        public IEnumerable<(int x, int y)> GetValidAdjacentCells(char letter, int x, int y)
        {
            return GetAdjacentCells(x, y)
                .Where(c => Board[c.x][c.y] == letter);
        }

        public IEnumerable<(int x,int y)> GetAdjacentCells(int x, int y)
        {

            var xs = new[] { x - 1, x, x + 1 }.Where(n => n >= 0 && n < Board.Length);
            var ys = new[] { y - 1, y, y + 1 }.Where(n => n >= 0 && n < Board.Length);

            var items = xs.SelectMany(x1 => ys, (i, y1) => new ValueTuple<int, int>(i, y1));
            items = items.Where(c => c.Item1 != x || c.Item2 != y);
            return items;
        }
    }
}
