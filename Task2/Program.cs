using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\HomeWork\number.txt";
            Random random = new Random();
            int sum = 0;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-1000, 1000));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                   sum += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine("Сумма чисел из файла:{0}, равна {1}", path, sum);
            Console.ReadKey();

        }
    }
}
