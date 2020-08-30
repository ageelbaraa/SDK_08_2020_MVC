using OOPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp052019.basics.oop
{

    class Point
    {
        public int x, y, z;

        public static Point operator+ (Point p, Point p1)
        {
            Point t = new Point();
            t.x = p.x + p1.x;
            t.y = p.y + p1.y;
            t.z = p.z + p1.z;

            return t;
        }

        public int Add() { return 0; }
        public int Add(int a) { return a; }
        public int Add(int a, int b) { return a+b; }

    }
    class PolymorphismDemo
    {

        static void Main(string[] args)
        {
            // Polymorphis can be divide into 2 types 

            // 1) Static Polymorphis
            // a)  Operator overloading 

            Point p1 = new Point();
            Point p2 = new Point();
            Point p3 = p1 + p2;

            // b)  Method overloading 

            p1.Add();
            p1.Add(10);
            p1.Add(20, 5);

            // Overloading : defining more than one method using the same name but diffrent parameters list.
            // 2) Dynamic Polymorphis
            // a) Parent refrencing 

            Person p = new Person();
            Person ps = new Student();
            Person pe = new Employee();


            Student s = new Student();
            Employee e = new Employee();

            //object o = p;


            // Error:  Student sp = new Person();
            //// sp.avg = 10;



            // b) Late bindding 

            p.PrintSome();          // Person:PrintSome()
            ps.PrintSome();         // Student:PrintSome()
            pe.PrintSome();         // Employee:PrintSome()
            s.PrintSome();          // Student:PrintSome()
            e.PrintSome();          // Employee:PrintSome()


        }
    }
}
