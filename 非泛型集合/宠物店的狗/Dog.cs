using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 非泛型集合
{
    internal class Dog:Pet
    {
        
        //品种
        public string Strain {  get; set; }

        //无参构造方法
        public Dog():base("zhangsan",12,12)
        { 

        }
        //有参构造方法
        public Dog(string name, string strain):base(name,49,90)
        {
            this.Strain = strain;
        }

        //构造方法，构造方法没有返回值
        public Dog(string name,int health,int love,string strain):base(name,health,love)
        {
            this.Strain = strain;
        }


        //如果子类和父类方法重名，会优先使用子类的方法。
        public new void Print()
        {
            
            Console.WriteLine(base.Print()+$"是一只{Strain}");
        }

        //重写父类方法
        public override void Eat()
        {
            Console.WriteLine("狗狗开心的吃着狗粮");
            Health+=3;
        }

        public override void Hospital()
        {
            Console.WriteLine("狗打针吃药");
            Health+=10;
        }

        public void CatchingFlyDisc()
        {
            Console.WriteLine("狗玩飞盘");
            Health-=10;
            Love += 5;
        }


    }
}
