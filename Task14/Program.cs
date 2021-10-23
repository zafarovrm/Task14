using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.ShowInfo("Dog");
            Cat cat = new Cat();
            cat.ShowInfo("Cat");
            Console.ReadKey();
        }
        public abstract class Animal
        {
            public abstract string Name { get; set; }
            public virtual void Say()
            {
            }
            public void ShowInfo(string name)
            {
                Console.WriteLine(name);
                Say();
            }
        }
        public class Dog : Animal
        {
            string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                base.Say();
                Console.WriteLine("Woof!");
            }
        }
        public class Cat : Animal
        {
            string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                base.Say();
                Console.WriteLine("Meow!");
            }
        }
    }
}
