using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_consoleapp1_2
{
    class Program2
    {
        public static void linqop()
        {
            Console.WriteLine("--------------------TASK2--------------------");
            String[] names = { "Nirali", "Hena", "Bansari", "Kavya", "Mumuksha", "Reena", "Pa", "Yes", "Kizi", "Tia" };
            var o1 = names.Where(name => name[0] == 'K');
            Console.WriteLine("Get all names with the first letter ‘K’.");
            foreach(String name in o1)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Get all names whose string length is less than 4.");
            var o2 = names.Where(name => name.Length < 4);
            foreach (String name in o2)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Get all names whose string length is equal to 3.");
            var o3 = names.Where(name => name.Length == 3);
            foreach (String name in o3)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Get all names in Ascending order.");
            var o4 = names.OrderBy(name => name);  
            foreach(String name in o4)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
