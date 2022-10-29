using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Games";
            string[] stringArray = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
