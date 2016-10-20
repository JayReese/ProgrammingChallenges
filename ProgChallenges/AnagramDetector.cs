using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgChallenges
{
    class AnagramDetector
    {

        Dictionary<char, int> AnagramCounter;

        public AnagramDetector(string s)
        {
            AnagramCounter = new Dictionary<char, int>();

            CountLetters(s.ToCharArray());
        }

        void CountLetters(char[] splitWord)
        {
            foreach(char s in splitWord)
            {
                AnagramCounter.Add(s, 1);

                for(int i = 0; i < AnagramCounter.Count(); i++)
                {
                    if (char.ToLower(s) != char.ToLower(AnagramCounter.ElementAt(i).Key)
                        )
                        AnagramCounter.Add(s, 1);
                    else if (s.ToString().ToLower() == AnagramCounter.ElementAt(i).Key.ToString().ToLower())
                        AnagramCounter[s]++;
                }
            }

            foreach(KeyValuePair<char, int> s in AnagramCounter)
            {
                Console.WriteLine(string.Format("{0} : {1}", s.Key.ToString().ToLower(), s.Value));
            }
        }

        //style="padding:2px 0px 4px; display:block; width:500px; font-weight:normal; font-size:10px;text-decoration:underline;"
    }
}
