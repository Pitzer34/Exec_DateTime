using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//根據不同日期,回傳不同問安方式
			int time = DateTime.Today.Hour;

			String massage = String.Empty;
			if (time >= 6 && time < 12)
			{
				massage = "早安";
			}
			else if (time >= 12 && time < 18)
			{
				massage = "午安";
			}
			else
			{
				massage = "晚安";
			}
			Console.WriteLine(massage);
		}
	}
}
