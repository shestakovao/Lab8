using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\HomeWork\static.txt";
            string str = "";
            int countCharacters = 0;
            int countWords = 0;
            int countStrings = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine();
                    countStrings++;
                    countWords += str.Split(' ').Length;
                    countCharacters += str.Length;                  
                }

            }
            Console.WriteLine("Число строк {0}\nЧисло слов {1}\nЧисло символов {2}",countStrings,countWords,countCharacters);
            Console.ReadKey();
        }
    }
}
