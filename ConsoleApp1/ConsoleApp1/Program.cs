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
            Console.WriteLine("\t欢迎使用我行我素购物管理系统\t");
            Console.WriteLine("\t1.登录系统");
            Console.WriteLine("\t2.退出");
            Console.WriteLine("*******************************************");
            Console.WriteLine("请选择，输入数字：");
            string num = Console.ReadLine();
            int num1 = Convert.ToInt32(num);
            if (num1 == 1)
            {
                Console.WriteLine("登录系统");
                if (num1 == 2)
                    Console.WriteLine("退出");
            }
        }
    }
}
