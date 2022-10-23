using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算圖書下個月歸還時間
			Console.Write("請輸入圖書借出時間:");

			DateTime LendTime = Convert.ToDateTime(Console.ReadLine());
			DateTime RecedeTime = LendTime.AddMonths(1);

			Console.WriteLine("圖書應歸還時間"+RecedeTime.ToString("yyyy/MM/dd"));
		}
	}
}
