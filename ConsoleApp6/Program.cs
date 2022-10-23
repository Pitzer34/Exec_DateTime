using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//根據日期,回傳今日是本月上旬,中旬,下旬
			int day = DateTime.Today.Day;

			String massage = String.Empty;
			if (day >= 1 && day <= 10)
			{
				massage = "上旬";
			}
			else if (day >= 11 && day <= 20)
			{
				massage = "中旬";
			}
			else
			{
				massage = "下旬";
			}
			Console.WriteLine("今日為本月"+massage);
		}
	}
}
