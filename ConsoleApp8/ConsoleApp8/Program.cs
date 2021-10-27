using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string daxil edin");
            string param = Console.ReadLine();
            Console.WriteLine("simvol daxil edin");
            char symbol = Convert.ToChar(Console.ReadLine());
            int[] array = GetArray(param, symbol);
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i]==0 && i==0)|| array[i]!=0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        static int [] GetArray(string param,char symbol)
        {
            int count = 0;
            int[] result = new int[param.Length];

            for (int i = 0; i < param.Length; i++)
            {
                if (param[i]==symbol)
                {
                    result[count] = i;
                    count++;

                }
            }
      
            return result;
        }
    }
}
