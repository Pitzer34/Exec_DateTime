using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算三天後DVD應歸還時間
			Console.Write("請輸入DVD借出時間:");
			
			DateTime LendTime = Convert.ToDateTime(Console.ReadLine());
			DateTime RecedeTime = LendTime.AddDays(3);

			Console.WriteLine("DVD應歸還時間:"+RecedeTime.ToString("yyyy/MM/dd"));

		}
	}
}
