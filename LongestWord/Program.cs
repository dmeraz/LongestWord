using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //My test text

            string line = "on a night bleak and blearry \n as I pondered weak and weary";

            //CodeEval's document path and code to skip blank lines

            //using (StreamReader reader = File.OpenText(args[0]))
            //while (!reader.EndOfStream)
            //{
            //    string line = reader.ReadLine();
            //    if (null == line)
            //        continue;

            //}

            string[] words = line.Split(' ').ToArray();//This splits each line at a space and puts them in an array.
            string longestWord = "";

            foreach (string word in words)
            {
                //Fancy code by mneudert on GitHub
                //if(word.Length > longestWord.Length)
                //  longestWord = word;


                //My idea, which I realized is the same, but with the int values declared seperately.
                int wordLength = word.Length;
                int longestWordL = longestWord.Length;

                if (wordLength > longestWordL)
                    longestWord = word;

            }

            Console.WriteLine(longestWord);
        }
    }
}
