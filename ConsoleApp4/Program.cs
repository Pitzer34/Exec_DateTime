using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//取得本月最後一日
			DateTime dt = DateTime.Today;
			int days = DateTime.DaysInMonth(dt.Year,dt.Month);

			Console.WriteLine($"本月最後一日為:{dt:yyyy/MM/}{days}");
		}
	}
}
