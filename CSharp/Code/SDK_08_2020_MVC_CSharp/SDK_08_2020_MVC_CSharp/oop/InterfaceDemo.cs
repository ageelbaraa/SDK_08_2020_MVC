using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp052019.basics.oop
{
    // interface 
    class Animal
    {
        public override string ToString()
        {
            return "Animal";
        }

        public string Print() { return "Animal"; }
        public virtual string Print1() { return "Animal"; }

    }
    class Bird : Animal
    {
        public override string ToString()
        {
            return "Bird";
        }
        public string Print() { return "Bird"; }
        public override string Print1() { return "Bird"; }
    }
    class Mammal : Animal
    {
        public override string ToString()
        {
            return "Mammal";
        }
        public string Print() { return "Mammal"; }
        public override string Print1() { return "Mammal"; }
    }

    class Cat : Mammal
    {
        public override string ToString()
        {
            return "Cat";
        }
        public string Print() { return "Cat"; }
        public override string Print1() { return "Cat"; }
    }
    class Bat : Mammal, IFlyable
    {
        public override string ToString()
        {
            return "Bat";
        }

        public string Print() { return "Bat"; }

        public override string Print1() { return "Bat"; }

        public string CanFly() { return ", it can Fly"; }
    }

    class Penguin : Bird
    {
        public override string ToString()
        {
            return "Penguin";
        }

        public string Print() { return "Penguin"; }
        public override string Print1() { return "Penguin"; }
    }
    class Falcon : Bird, IFlyable
    {
        public override string ToString()
        {
            return "Falcon";
        }
        public string Print() { return "Falcon"; }

        public override string Print1() { return "Falcon"; }

        public string CanFly() { return ", it can Fly"; }

    }

    class Eagel : Bird, IFlyable
    {
        public override string ToString()
        {
            return "Eagel";
        }
        public  string Print() { return "Eagel"; }

        public override string Print1() { return "Eagel"; }

        public string CanFly() { return ", it can Fly"; }

    }


    interface IFlyable
    {
        string CanFly();
    }

    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Animal[] animals = new Animal[20];

            Console.WriteLine("{0,4} : {1,20} {2,20} {3,20}", "i", "ToString()", "Print()", "Print1()");
            Console.WriteLine("----------------------------------------------------------------------------------");

            for (int i = 0; i < animals.Length; i++)
            {
                switch (rand.Next(8))
                {
                    case 0:
                        animals[i] = new Cat(); break;
                    case 1:
                        animals[i] = new Bat(); break;
                    case 2:
                        animals[i] = new Penguin(); break;
                    case 3:
                        animals[i] = new Falcon(); break;
                    case 4:
                        animals[i] = new Mammal(); break;
                    case 5:
                        animals[i] = new Bird(); break;
                    case 6:
                        animals[i] = new Eagel(); break;
                    default:
                        animals[i] = new Animal(); break;
                }

                Console.Write("{0,4} : {1,20} {2,20} {3,20} ", i, animals[i].ToString(), animals[i].Print(), animals[i].Print1());
                //if(animals[i] is Falcon)
                //    Console.WriteLine(((Falcon)animals[i]).CanFly());
                //else if (animals[i] is Bat)
                //    Console.WriteLine(((Bat)animals[i]).CanFly());
                //else
                //    Console.WriteLine();

                if (animals[i] is IFlyable)
                    Console.WriteLine(((IFlyable)animals[i]).CanFly());
                else
                    Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
