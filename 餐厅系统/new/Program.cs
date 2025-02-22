using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace @new
{
    internal class Program
    {
        #region 数据初始化
        //菜品名称
        static string[] menus = { "鱼香肉丝", "时令鲜蔬", "酸辣土豆" };
        //菜品单价
        static double[] prices = { 38.0, 20.0, 10.0 };
        //点赞数
        static int[] dianZans =new int[3];
        // 保存订餐人名称
        static string[] names = new string[4];
        // 保存菜品名及份数
        static string[] dishMegs = new string[4];
        //菜品的份数
        static int[] count=new int[3];
        // 保存送餐时间
        static int[] times = new int[4];
        // 保存送餐地址
        static string[] addresses = new string[4];
        // 保存订单状态： 0：已预订 1：已完成
        static int[] states = new int[4];
        // 保存订单的总金额
        static double[] sumPrices = new double[4];
        //订单初始化
        static void InitOrder()
        {
            names[0] = "张晴";
            dishMegs[0] = "红烧带鱼2份";
            times[0] = 3;
            addresses[0] = "天成路207号";
            sumPrices[0] = 76;
            states[0] = 1;
            names[1] = "张晴";
            dishMegs[1] = "鱼香肉丝2份";
            times[1] = 10;
            addresses[1] = "天成路207号";
            sumPrices[1] = 45;
            states[1] = 0;
        }
        #endregion

        //GetChoice选择需要的功能
        static int GetChoice()
        {
            //正则表达式(定义的字符串的匹配的规则)
            string regex = "^[1-6]{1}$";
            string str = "0";
            do
            {
                Console.Write("请选择：");
                str = Console.ReadLine();
                if (Regex.IsMatch(str, regex))
                {
                    break;
                }
                Console.WriteLine("您需要输入1-6之间的数字");
            } while (true);
            return int.Parse(str);

        }

        /*ShowMenuInfo显示我们的菜品*/
        static void ShowMenuInfo()
        {
            Console.WriteLine("序号\t菜名\t\t单价\t点赞数");
            for (int i = 0; i < menus.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t{menus[i]}\t{prices[i]}\t{dianZans[i]}\t");
            }
        }

        //获得null的下标
        static int getIndex(string[] array)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        #region 我要订餐
        static void AddMenu()
        {
            Console.WriteLine("请输入订餐人姓名：");
            string name = Console.ReadLine();
            //获取 null 的下标
            int index = getIndex(names);
            names[index] = name;
            //显示菜品
            ShowMenuInfo();
            Console.WriteLine("请输入您要点的菜品编号：");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入您需要的份数：");
            count[index] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入送餐时间：");
            times[index] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入送餐地址：");
            addresses[index] = Console.ReadLine();
            dishMegs[index] = menus[num - 1] + count[index] + "份";

            double amount = count[index] * prices[index];
            double money = 0;
            double songCanFei = 0;
            if (amount < 50)
            {
                songCanFei = 5;
                money = amount + songCanFei;
            }
            sumPrices[index] = money;
            Console.WriteLine("订餐成功");
            Console.WriteLine($"您订的是{menus[index]}");
            Console.WriteLine($"送餐时间是{times[index]}");
            Console.WriteLine($"送餐地址为{addresses[index]}");
            
            Console.WriteLine($"餐费为{amount},送餐费{songCanFei},总计{money}");
        }
        #endregion
        

        //展示订单
        static void ShowOrders()
        {
            //展示订单信息
            Console.WriteLine("序号\t订餐人\t餐品信息\t送餐日期\t送餐地址\t总金额\t订单状态");
            //数组的遍历
            for (int i = 0; i < menus.Length; i++)
            {
                if (names[i] != null)
                {
                    //三目运算符
                    string stateStr = states[i] == 0 ? "已预订" : "已完成";
                    Console.WriteLine($"{i + 1}\t{names[i]}\t{dishMegs[i]}\t{times[i]}\t" +
                        $"\t{addresses[i]}\t{sumPrices[i]}\t{stateStr}");
                }
            }
        }

        //删除订单
        static void DelOrder()
        {
            Console.Write("请选择要删除的订单编号：");
            int num = int.Parse(Console.ReadLine());
            //订单不存在或订单没有签收
            if (states[num - 1] == 0)
            {
                Console.WriteLine("您的订单没有签收，无法删除");
            }
            else
            {
                for (int j = num - 1; j < names.Length - 1; j++)
                {
                    names[j] = names[j + 1];
                    dishMegs[j] = dishMegs[j + 1];
                    times[j] = times[j + 1];
                    addresses[j] = addresses[j + 1];
                    states[j] = states[j + 1];
                    sumPrices[j] = sumPrices[j + 1];
                }
                names[names.Length - 1] = null;
                dishMegs[names.Length - 1] = null;
                times[names.Length - 1] = 0;
                addresses[names.Length - 1] = null;
                states[names.Length - 1] = 0;


            }
        }

        //签收订单
        static void QianShouOrder()
        {
            Console.Write("请选择要签收的订单编号：");
            int num = int.Parse(Console.ReadLine());
            //订单不存在或订单已经签收
            if (states[num - 1] == 1)
            {
                Console.WriteLine("您已经签收过了");
            }
            states[num - 1] = 1;
        }


        //点赞
        static void DianZanOrder()
        {
            ShowMenuInfo();
            Console.Write("请选择要点赞的菜品编号：");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                if (num == i)
                {
                    dianZans[i-1]++;
                    Console.WriteLine("点赞成功");
                }
            }
            ShowMenuInfo();
        }

        static void Main(string[] args)
        {
            //将初始化的数据导入循环中
            InitOrder();

            do
            {
                Console.WriteLine("***************************");
                Console.WriteLine("超级\"吃货系统\"");
                Console.WriteLine("1.我要订餐");
                Console.WriteLine("2.查看餐袋");
                Console.WriteLine("3.签收订单");
                Console.WriteLine("4.删除订单");
                Console.WriteLine("5.我要点赞");
                Console.WriteLine("6.退出系统");
                Console.WriteLine("***************************");
                int choice = GetChoice();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("***我要订餐***");
                        AddMenu();
                        break;
                    case 2:
                        Console.WriteLine("***查看餐袋***");
                        ShowOrders();
                        break;
                    case 3:
                        Console.WriteLine("***签收订单***");
                        QianShouOrder();
                        break;
                    case 4:
                        Console.WriteLine("***删除订单***");
                        DelOrder();
                        break;
                    case 5:
                        Console.WriteLine("***我要点赞***");
                        DianZanOrder();
                        break;
                    case 6:
                        Console.WriteLine("***退出系统***");
                        return;
                } 
            } while (true);

        }
    }
}
