/*using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace food_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //订单个数,最多五个
            int dingDan_XvHao = 0;
            //订单自增
            int dingDanShu = 0;
            *//*int[] caiPin_dingDan=new int[dingDanShu];*//*
            //菜品份数
            string[] caiPin_FenShu=new string[5];
            //订单人
            string[] caiPin_DingDanRen=new string[5];
            //菜品单号
            int[] caiPin_DanHao=new int[5];
            //送餐时间
            int[] songCanShiJian=new int[5];
            //送餐地址
            string[] songCanDiZhi=new string[5];
            //订单费用
            double[] dingDanFeiYong=new double[5];
            //订单状态
            int[] dingDanZhuangTai=new int[5] { 0, 0, 0, 0, 0 };
            //订单日期
            string[] dingDanRiQi=new string[5];

            string[,] caiPin = { { "1","红烧带鱼", "38.0", "0" },
                                 { "2","鱼香肉丝", "20.0", "0" },
                                 { "3","水果拼盘", "10.0", "0" } };
        next:
            Console.WriteLine("");
            Console.WriteLine("欢迎使用订餐系统");
            Console.WriteLine("****************************");
            Console.WriteLine("1.我要订餐");
            Console.WriteLine("2.查看餐袋");
            Console.WriteLine("3.签收订单");
            Console.WriteLine("4.删除订单");
            Console.WriteLine("5.我要点赞");
            Console.WriteLine("6.退出系统");
            Console.WriteLine("***************************");
            Console.WriteLine("请选择：");
            

            //输入选择的功能
            int choose=Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                
                case 1: 
                    Console.WriteLine("***我要订餐***");
                    Console.WriteLine("请输入订餐人姓名:");
                    caiPin_DingDanRen[dingDanShu] =Console.ReadLine();
                    
                    Console.WriteLine("序号\t菜名\t\t单价\t点赞数");
                    for (int i = 0; i < caiPin.GetLength(0); i++)
                    {
                        
                        for (int j = 0; j < caiPin.GetLength(1); j++)
                        {
                            Console.Write($"{caiPin[i,j]}\t");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("请选择您要点的菜品单号：");
                    caiPin_DanHao[dingDan_XvHao] =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("请选择您需要的菜品份数：");
                    caiPin_FenShu[dingDanShu] =Console.ReadLine();
                    Console.WriteLine("请输入送餐时间(送餐时间是10点到20点内整点送餐):");
                    songCanShiJian[dingDanShu] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("请输入送餐地址：");
                    songCanDiZhi[dingDanShu] =Console.ReadLine();
                    Console.WriteLine("订餐成功");
                    bool fals = true;
                    while (fals==true)
                    {
                        
                        for (int i = 0; i < caiPin.GetLength(0); i++)
                        {
                            for (int j = 0; j < caiPin.GetLength(1); j++)
                            {
                                if (i + 1 == caiPin_DanHao[dingDan_XvHao])
                                {
                                    double z = Convert.ToDouble(caiPin[i, 2]);
                                    double y=Convert.ToDouble(caiPin_FenShu[dingDanShu]);
                                    Console.WriteLine($"餐费{ z* y}元，送餐费0.0元，总计{z * y}元");
                                    dingDanFeiYong[dingDanShu] = z*y;
                                    caiPin_FenShu[dingDanShu] = caiPin[i, 1] + caiPin_FenShu[dingDanShu];
                                    Console.WriteLine($"您订的是{caiPin_FenShu[dingDanShu]}份");
                                    Console.WriteLine($"送餐时间：{songCanShiJian[dingDanShu]}点");
                                    dingDanShu++;
                                    break;
                                }
                            }
                        }
                        Console.WriteLine("输入0返回");
                        int fanHuiZhi = Convert.ToInt32(Console.ReadLine());
                        if (fanHuiZhi == 0)
                        {
                            goto next;
                        }
                    }
                    break;
                 


                case 2:
                    Console.WriteLine("***查看餐袋***");
                    Console.WriteLine("序号\t订餐人\t菜品信息\t送餐日期\t送餐地址\t总金额\t订单状态\t");
                    bool flas=true;
                    while (flas == true)
                    {
                        for (int i = 0;i < dingDanShu; i++)
                        {
                            Console.Write($"{i + 1}\t");
                            //对订单日期进行赋值
                            dingDanRiQi[dingDanShu - 1] = System.DateTime.Now.ToString("D");
                            for (int k = 0;k < dingDanShu;k++)
                            {
                                //输出订单人
                                Console.Write($"{caiPin_DingDanRen[k]}\t");
                                //输出餐品信息
                                Console.Write($"{caiPin_FenShu[k]}\t");
                                //输出送餐日期
                                Console.Write($"{dingDanRiQi[k]}\t");
                                //输出送餐地址
                                Console.Write($"{songCanDiZhi[k]}\t");
                                //输出总金额
                                Console.Write($"{dingDanFeiYong[k]}\t");
                                //输出订单状态
                                Console.Write($"{dingDanZhuangTai[k]}\t");
                                Console.WriteLine("");
                                break;
                            }
                        }
                          Console.WriteLine("输入0返回");
                            int fanHuiZhi = Convert.ToInt32(Console.ReadLine());
                            if (fanHuiZhi == 0)
                            {
                                goto next;
                            }
                    }
                    break;
                case 3:
                    Console.WriteLine("***签收订单***");
                    Console.WriteLine("请选择要签收的订单号：");
                    bool fla = true;
                    while (fla == true)
                    {
                        int qianShou_DingDanHao = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < dingDanShu; i++)
                        {
                            if (qianShou_DingDanHao == dingDanShu)
                            {
                                dingDanZhuangTai[dingDanShu-1] = 1;
                                Console.WriteLine("订单签收成功");
                            }
                        }
                        Console.WriteLine("输入0返回");
                        int fanHuiZhi = Convert.ToInt32(Console.ReadLine());
                        if (fanHuiZhi == 0)
                        {
                            goto next;
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("***删除订单***");
                    bool fl = true;
                    while(fl == true)
                    {
                        Console.WriteLine("请输入要删除的订单单号：");
                        int shanChu_DingDanHao = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < shanChu_DingDanHao; j++)
                            {
                                if (1 == dingDanZhuangTai[shanChu_DingDanHao - 1])
                                {
                                    Console.WriteLine("已签收，可以删除");
                                    caiPin_DingDanRen[shanChu_DingDanHao - 1] = caiPin_DingDanRen[shanChu_DingDanHao];
                                    caiPin_FenShu[shanChu_DingDanHao - 1] = caiPin_FenShu[shanChu_DingDanHao];
                                    dingDanRiQi[shanChu_DingDanHao - 1] = dingDanRiQi[shanChu_DingDanHao];
                                    songCanDiZhi[shanChu_DingDanHao - 1] = songCanDiZhi[shanChu_DingDanHao];
                                    dingDanFeiYong[shanChu_DingDanHao - 1] = dingDanFeiYong[shanChu_DingDanHao];
                                    dingDanZhuangTai[shanChu_DingDanHao - 1] = dingDanZhuangTai[shanChu_DingDanHao];
                                    caiPin_DingDanRen[4] = null;
                                    caiPin_FenShu[4] = null;
                                    dingDanRiQi[4] = null;
                                    songCanDiZhi[4] = null;
                                    dingDanFeiYong[4] = 0;
                                    dingDanZhuangTai[4] = 0;
                                }
                            }
                            Console.WriteLine("您选择的订单未签收，不能删除");
                        }

                            Console.WriteLine("输入0返回");
                        int fanHuiZhi = Convert.ToInt32(Console.ReadLine());
                        if (fanHuiZhi == 0)
                        {
                            goto next;
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("***我要点赞***");
                    bool f = true;
                    while (f == true)
                    {
                        Console.WriteLine("序号\t菜名\t\t单价\t点赞数");
                        for (int i = 0; i < caiPin.GetLength(0); i++)
                        {

                            for (int j = 0; j < caiPin.GetLength(1); j++)
                            {
                                Console.Write($"{caiPin[i, j]}\t");
                            }
                            Console.WriteLine("");
                        }
                        Console.WriteLine("请选择您要点赞的菜品序号：");
                        int dianZhan= Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < caiPin.GetLength(0); i++)
                        {
                            if (dianZhan == i + 1)
                            {
                                int dianZhanShu = Convert.ToInt32(caiPin[i,3]);
                                dianZhanShu++;
                                caiPin[i, 3] = $"{dianZhanShu}";
                                Console.WriteLine($"{caiPin[i, 3]}");
                                Console.WriteLine("点赞成功！");
                            }
                        }
                        Console.WriteLine("输入0返回");
                        int fanHuiZhi = Convert.ToInt32(Console.ReadLine());
                        if (fanHuiZhi == 0)
                        {
                            goto next;
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("***退出系统***");
                    break;
            }
        }
    }
}
*/



using System;
using System.Text.RegularExpressions;

namespace MyOrder
{
    internal class Program
    {
        #region 数据初始化
        //定义项目所需要的数组
        //菜品名称
        static string[] menus = { "红烧带鱼", "鱼香肉丝", "时令鲜蔬" };
        //菜品单价
        static double[] prices = { 38.0, 20.0, 10.0 };
        //菜品点赞数
        static int[] dianZans = new int[3];
        //订餐人的姓名
        static string[] names = new string[4];
        //送餐时间
        static int[] times = new int[4];
        //送餐地址
        static string[] addresses = new string[4];
        //保存订单状态： 0：已预订 1：已完成
        static int[] states = new int[4];
        //订单的总金额
        static double[] sumPrices = new double[4];
        //菜品的份数
        static int[] counts = new int[4];
        //菜品信息
        static string[] dishMegs = new string[4];
        static void InitOrder()
        {
            names[0] = "张晴";
            names[1] = "张晴";
            dishMegs[0] = "红烧带鱼 2份";
            dishMegs[1] = "鱼香肉丝 2份";
            times[0] = 12;
            times[1] = 18;
            addresses[0] = "天成路207号";
            addresses[1] = "天成路207号";

            states[0] = 1;
            states[1] = 0;
            sumPrices[0] = 76.0;
            sumPrices[1] = 45.0;
        }
        static void ShowOrder()
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

        #endregion

        //定义方法
        // 修饰符 数据类型 方法名(){方法体}
        static int GetChoice()
        {
            Console.Write("请选择：");
            int choice = int.Parse(Console.ReadLine());
            while (choice < 1 || choice > 6)
            {
                Console.Write("请输入1-6之间的数字：");
                choice = int.Parse(Console.ReadLine());
            }
            return choice;
        }
        static int GetChoiceByRegex()
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
        #region 我要订餐
        static void AddOrder()
        {
            Console.Write("请输入订餐人姓名：");
            string name = Console.ReadLine();
            //获取 null 的下标
            int index = getIndex(names);
            names[index] = name;
            ShowMenuInfo();
            Console.Write("请输入您要点的菜品编号：");
            int num = int.Parse(Console.ReadLine());
            Console.Write("请输入您需要的份数：");
            counts[index] = int.Parse(Console.ReadLine());
            Console.Write("请输入送餐时间：");
            times[index] = int.Parse(Console.ReadLine());
            Console.Write("请输入送餐地址：");
            addresses[index] = Console.ReadLine();
            dishMegs[index] = menus[num - 1] + counts[index] + "份";

            double amount = counts[index] * prices[index];
            double money = 0;
            double songCanFei = 0;
            if (amount < 50)
            {
                songCanFei = 5;
                money = amount + songCanFei;
            }
            sumPrices[index] = money;
            Console.WriteLine("订餐成功");
            Console.WriteLine($"您订的是：{menus[index]}");
            Console.WriteLine($"送餐时间是：{times[index]}");
            Console.WriteLine($"送餐地址：{addresses[index]}");

            Console.WriteLine($"餐费：{amount},送餐费{songCanFei},总计:{money}");
        }
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
        /*
         * ShowMenuInfo 显示我们的菜品
         */
        static void ShowMenuInfo()
        {
            Console.WriteLine("序号\t菜名\t\t单价\t点赞数");
            //数组的遍历
            for (int i = 0; i < menus.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t{menus[i]}\t{prices[i]}\t{dianZans[i]}");
            }
        }
        #endregion

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
        static void Main(string[] args)
        {
            InitOrder();
            do
            {
                Console.WriteLine();
                Console.WriteLine("欢迎使用\"吃货联盟订餐系统\"");
                Console.WriteLine("************************************");
                Console.WriteLine("1、我要订餐");
                Console.WriteLine("2、查看餐袋");
                Console.WriteLine("3、签收订单");
                Console.WriteLine("4、删除订单");
                Console.WriteLine("5、我要点赞");
                Console.WriteLine("6、退出系统");
                Console.WriteLine("************************************");
                //调用方法，获取用户的选择
                int choice = GetChoiceByRegex();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("***我要订餐***");
                        //调用我要订餐的方法
                        AddOrder();
                        break;
                    case 2:
                        Console.WriteLine("***查看餐袋***");
                        ShowOrder();
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
                        break;
                    case 6:
                        Console.WriteLine("***退出系统***");
                        return;
                }
            } while (true);
        }
    }
}
