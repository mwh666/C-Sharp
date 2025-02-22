using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 非泛型集合
{
    internal class Program
    {
        static void text()
        {
            //非泛型集合（传统集合） ArrayList
            ArrayList arrayList = new ArrayList();


            //添加元素
            //写法一
            arrayList.Add(1);
            arrayList.Add("开心");
            arrayList.Add(3.14);
            //写法二
            ArrayList list = new ArrayList { 1, 2, 6, 4, 5 };






            //取出元素,显式转换
            int num = (int)arrayList[0];
            string str = (string)arrayList[1];
            double pi = (double)arrayList[2];

            //集合现有的元素个数 arrayList.Count
            Console.WriteLine($"集合的元素个数：{list.Count}");

            //设置集合的个数 arrayList.Capacity
            //arrayList.Capacity = 20;

            //遍历集合
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            //删除值为1的元素 list.Remove(1)
            Console.WriteLine();
            list.Remove(1);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            //逆转 list.Reverse()
            Console.WriteLine();
            list.Reverse();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            //排序 list.Sort()
            Console.WriteLine();
            list.Sort();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
