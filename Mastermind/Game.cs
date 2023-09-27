using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Game
    {
        public Dictionary<int, string> colours = new Dictionary<int, string>()
        {
            {1,"white" },
            {2, "pink" },
            {3, "yellow" },
            {4, "green" },
            {5, "red" },
            {6, "blue" }
        };

        public List<string> GenerateCode()
        {
            Random rnd = new Random();
            List<string> list = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                list.Add(colours[rnd.Next(1, 7)]);
            }
            return list;
        }
        public int[] Check(string input, List<string> list)
        {
            int wellPlaced = 0;
            int misPlaced = 0;

            int j = 0;

            List<string> unmatched = new List<string>(list);
            List<char> unmatchedGuess = new List<char>(input.ToCharArray().ToList());


            foreach (char x in input)
            {
                int z = int.Parse(x.ToString());
                if (list[j].Equals(colours[z]))
                {
                    wellPlaced++;
                    unmatched.Remove(list[j]);
                    unmatchedGuess.Remove(x);
                }

                j++;

            }
            for (int i = 0; i < unmatchedGuess.Count; i++)
            {
                if (unmatched.Contains(unmatchedGuess[i].ToString()))
                {
                    misPlaced++;
                    unmatched.Remove(colours[int.Parse(unmatchedGuess[i].ToString())]);
                }
            }

            int[] output = {wellPlaced, misPlaced};
            return output;
        }
    }
}
