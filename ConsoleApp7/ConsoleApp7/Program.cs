using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
         int count=   GetWordCount(input);
            Console.WriteLine(count);
        }
        static int GetWordCount (string param)
        {
            int count = 0;
            for (int i = 0; i < param.Length; i++)
            {
                if (param[i]==' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
