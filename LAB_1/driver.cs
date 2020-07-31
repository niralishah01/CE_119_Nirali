using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L2t1ClassLibrary1;

namespace ConsoleApp1
{
    class driver
    {
        static void Main(string[] args)
        {
			addition a = new addition();
			int ans = a.sum(2, 4);
			Console.WriteLine(ans);
			Console.ReadKey();
        }
    }
}
