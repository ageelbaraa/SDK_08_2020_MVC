using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ASP012019.exceptions
{
    class ExceptionDemo2
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\target.txt1";
            StreamReader sr = null;
            try
            {
                //Console.Write("Enter the file path:");
                //filepath = Console.ReadLine();
                sr = new StreamReader(filepath);
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                //sr.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                if (sr != null)
                    sr.Dispose();
            }

            //if(null != sr)
            //    sr.Dispose();

            using (StreamReader srr = new StreamReader(filepath))
            {
                try
                {

                }
                catch (Exception)
                {

                }
            } // auto dispose
            using (StreamReader sr1 = new StreamReader(filepath))
            using (StreamWriter wr = new StreamWriter(filepath + ".bak"))
            // using (Person r = new Person())
            {
                try
                {
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }// auto Dispose for sr1 and wr


            Console.WriteLine("Done");

            Console.ReadKey();

        }
    }
}
