using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//取得本月一日
			DateTime dt = DateTime.Today;

			Console.WriteLine($"本月一日為:{dt:yyyy/MM/01}");

		}
	}
}
