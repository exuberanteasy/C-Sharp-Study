using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor ori = Console.ForegroundColor;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("開始");
            Console.ForegroundColor = ori;
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("????????????????????????????????????????");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("##############################################");
            Console.ForegroundColor = ori;
            Console.WriteLine("結束");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        }
    }
    class A
        {
            public static void S /* 方法名稱 */ (/* 沒有參數 */)
            {
                ConsoleColor ori = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A.S() 被呼叫了");
                Console.WriteLine("準備返回了");
                Console.ForegroundColor = ori;
            }

        }       
}
