using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP012019
{
    
    class MethodsDemoClass
    {
        // Method or function : named block of code with return data type and optional input parameters 
        // All methods in C# must be written inside a class 
        // Syntax to define a method
        //      [specifier] [modifier] <return_data_type> <method_name> (<parameter_list>) { <body>}

        // Syntax to call a method
        //  [<Class_name>|<variable_name>.]methodName(<argument_list>);


        int nonStaticVariable;
        static int StaticVariable = 10;
        static void Main(string[] args)
        {
            StaticMethod();     // just from static method inside the class 

            MethodsDemoClass.StaticMethod();


            MethodsDemoClass var = new MethodsDemoClass();
            
            var.name(1,5);

            // nonStaticVariable = 10;
            StaticVariable  = 20;
        }

        void name(int v, int m){
            nonStaticVariable = 10;
            StaticVariable = 30;

            return; // return ends the method execution 

            Console.WriteLine("Unreachable code ");
        }

        int Dif(int a, int b)
        {
            if (a > b)
                return a - b;
            else
                return b - a;
        }

        static void StaticMethod()
        {

        }
    }
}
