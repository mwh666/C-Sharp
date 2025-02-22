using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 非泛型集合;

namespace 宠物店的狗
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //声明一个宠物集合
                ArrayList dogList = new ArrayList();
                dogList.Add(new Dog("旺财1", "拉布拉多犬"));
                dogList.Add(new Dog("旺财2", "雪纳瑞"));
                Dog dog3 = new Dog("旺财3", "京巴");
                dogList.Add(dog3);
                dogList.Add(new Dog("旺财4", "拉布拉多犬"));
                dogList.Add(new Dog("旺财5", "拉布拉多犬"));
                //获取实际的宠物个数
                Console.WriteLine($"删除前，宠物店有{dogList.Count}个狗狗宠物");
                foreach (Dog dog in dogList)
                {
                    Console.WriteLine($"{dog.Name}\t{dog.Strain}");
                }
                //删除集合中的元素
                dogList.Remove(dog3);
                Console.WriteLine();
                Console.WriteLine($"删除后，宠物店有{dogList.Count}个狗狗宠物");
                foreach (Dog dog in dogList)
                {
                    Console.WriteLine($"{dog.Name}\t{dog.Strain}");
                }
                dogList.Contains(dog3);
                //查找某个元素，条件是一个叫做“旺财5”的对象
                bool flag = false;
                foreach (Dog dog in dogList)
                {
                    if (dog.Name == "旺财5")
                    {
                        flag = true;
                        break;
                    }
                }
                Console.WriteLine($"{flag}");
            }

        }
    }

