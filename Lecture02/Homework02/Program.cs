using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入毫秒數:");
            string keyin = Console.ReadLine();
            bool keyin2 = int.TryParse(keyin, out int keyin3);

            if (!keyin2)
            {
                Console.WriteLine("數值輸入錯誤");
                return;
            }
            int msecs = keyin3 % 1000;
            int hours = (keyin3 / 1000 / 3600);
            int mins = (keyin3 / 1000 - hours * 3600) / 60;
            int secs = ((keyin3 / 1000) - (hours * 3600) - (mins * 60));

            Console.WriteLine("經計算為{0}時{1}分{2}.{3}秒", hours, mins, secs, msecs);
        }
    }
}