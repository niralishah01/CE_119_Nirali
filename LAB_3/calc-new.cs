using System;
using System.Reflection;
[assembly: AssemblyVersion("1.0.0.0")]
namespace calc_prog
{
	public class calc_prog_class
	{
		public int addition(int num1,int num2)
		{
			Console.WriteLine("From new version\n");
			return num1+num2;
		}
		public int multiplication(int num1,int num2)
		{
			Console.WriteLine("From new version\n");
			return num1*num2;
		}
	}
}