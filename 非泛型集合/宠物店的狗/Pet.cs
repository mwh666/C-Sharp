using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 非泛型集合
{
    internal class Pet
    {
        //private对属性进行私有化，通过get,set方法调用，保证了安全性
        //如果不满足set方法，则返回get方法里的return(定义的属性值)。
        private int health = 50;
        public int Health
        {
            get { return health; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    health = value;
                }
            }
        }
        //亲密度
        private int love = 0;
        public int Love
        {
            get
            {
                return love;
            }
            set
            {
                if (value > 0)
                {
                    love = value;
                }
            }
        }
        //昵称
        public string Name { get; set; }

        public Pet() { }
        //构造方法
        public Pet(string name, int health, int love)
        {
            Name = name;
            Health = health;
            Love = love;
        }

        public string Print()
        {
            return $"名字是{Name},健康是{Health},和主任的亲密度是{Love}";
        }

        //定义一个虚方法,喂养
        public virtual void Eat()
        {

        }

        //看病
        public virtual void Hospital() { }
    }
}
