using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_键值对集合
{
    internal class Program
    {
        static void Test()
        {
            //获取Hashtable包含的键值对个数 Count
            //hashtable不保留写入顺序，随机读取
            //hashtable通过键来操作值
            //表示国家的全称和简称
            Hashtable hashtable = new Hashtable();

            hashtable.Add("CN", "中国");
            hashtable.Add("US", "美国");
            hashtable.Add("RU", "俄罗斯");
            hashtable.Add("RZ", "占山");

            //集合中有多少国家
            Console.WriteLine($"集合中有{hashtable.Count}个国家");

            //取出所有国家的键值
            Console.Write("键值为");
            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine(key + " ");
            }

            //取出所有国家的全称
            Console.Write("国家的全称为");
            foreach (string value in hashtable.Values)
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();

            //通过键找到值
            string China = (string)hashtable["CN"];
            Console.WriteLine($"查询CN代码对应的全称：{China}");
            Console.WriteLine();

            //修改RZ对应的值
            hashtable["RZ"] = "小日本";
            foreach (string value in hashtable.Values)
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();

            //删除
            hashtable.Remove("RZ");
            foreach (string value in hashtable.Values)
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();

            //清空
            Console.WriteLine("清空集合的元素");
            hashtable.Clear();
            Console.WriteLine($"有{hashtable.Count}个元素");
        }


        static void Main(string[] args)
        {
            


        }
    }
}
