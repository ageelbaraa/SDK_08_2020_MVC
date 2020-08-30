using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Person
    {
        private int s;
        public int id;
        public virtual void PrintSome()
        {
            Console.WriteLine("Person:PrintSome()");
        }

        public void JustInPerson()
        {

        }
    }

    class Student : Person
    {

        public int avg;
        public override void PrintSome()
        {
            Console.WriteLine("Student:PrintSome()");
        }

        public void JustInStudent()
        {

        }
    }


    class Employee : Person
    {
        public override  void PrintSome()
        {
            Console.WriteLine("Employee:PrintSome()");
        }
        public void JustInEmployee()
        {

        }
    }

    class InheritanceDemo
    {


        static void Main(string[] args)
        {

            //Rectangle r = new Rectangle(10, 5);


            Person p = new Person();
            Person ps = new Student();
            Person pe = new Employee();
            Student s = new Student();
            Employee e = new Employee();

            //object o = p;


            // Error:  Student sp = new Person();
            //// sp.avg = 10;



            p.PrintSome();          // Person:PrintSome()
            ps.PrintSome();         // Person:PrintSome()
            pe.PrintSome();         // Person:PrintSome()
            s.PrintSome();          // Student:PrintSome()
            e.PrintSome();          // Employee:PrintSome()


            

            // Shape shape = new Triangle(5,3);
            // shape.Area();

            Console.ReadKey();
        }
    }
}
