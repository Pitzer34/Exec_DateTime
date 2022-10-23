using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//列出指定年份的每一個星期日
			Console.Write("請輸入欲查詢年份:");

			int year = Convert.ToInt32(Console.ReadLine());
			DateTime FirstDay = new DateTime(year, 1, 1);
			
			int day = (int)FirstDay.DayOfWeek;
			DateTime FirstSunday = FirstDay.AddDays((7 - day) % 7);

			DateTime EndDay = new DateTime(year, 12, 31);
			for (DateTime i = FirstDay; i <= EndDay; i = i.AddDays(7))
			{
				Console.WriteLine(i.ToString("yyyy/MM/dd"));
			}
			
		}
	}
}
