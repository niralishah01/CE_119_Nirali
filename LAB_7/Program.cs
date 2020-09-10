using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_consoleapp1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------TASK1--------------------");
            int[] num=new int[100];
            int i;
            for (i = 1; i <= 100; i++)
                num[i-1] = i;
            var o1 = num.Where(n => n % 2 == 0);
            Console.WriteLine("Get all even numbers between 1 10 100:"); 
            foreach(int n in o1)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Get all odd numbers between 1 10 100:");
            var o2 = num.Where(n => n % 2 != 0);
            foreach (int n in o2)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Select all numbers:");
            var o3 = num.Select(n=>n);
            foreach (int n in o3)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Select maximum number:");
            var o41 = num.Max();
            Console.WriteLine(o41);
            Console.WriteLine("Select minimum number:");
            var o42 = num.Min();
            Console.WriteLine(o42);
            Console.WriteLine("Find average of all numbers:");
            var o6 = num.Average();
            Console.WriteLine(o6);

            Program2.linqop();
        }
    }
}
