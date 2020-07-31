using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class my_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter second num:");
            string num2 = Console.ReadLine();
            int n1, n2, ans;
            n1 = Int32.Parse(num1);
            n2 = Int32.Parse(num2);
            ans = n1 + n2;
            Console.WriteLine("Answer is:"+ans);
        }
    }
}
