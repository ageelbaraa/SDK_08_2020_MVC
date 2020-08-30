using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class WritingFile
    {
        static void Main()
        {
            try
            {
                StreamWriter file = File.CreateText("test.dat");
                string line;
                do
                {
                    Console.Write("Enter a sentence: ");
                    line = Console.ReadLine();
                    if (line.Length != 0)
                    {
                        file.WriteLine(line);
                    }
                } while (line.Length != 0);
                file.Close();
            }
            catch (Exception)
            { Console.WriteLine("Error!!!"); }
        }
    }


    class AppendingTextFile
    {
        static void Main()
        {
            try
            {
                StreamWriter file = File.AppendText("data.dat")
                ; string line;
                do
                {
                    Console.Write("Enter a sentence: ");
                    line = Console.ReadLine();
                    if (line != "") file.WriteLine(line);
                } while (line != "");
                file.Close();
            }
            catch (Exception)
            { Console.WriteLine("Error!!!"); }
        }
    }


    class DisplayFileContent { static void Main() { Console.Write("Enter name of file: "); string name = Console.ReadLine(); try { StreamReader file  = File.OpenText(name); string line = " "; do { line = file.ReadLine(); if (line != null) { Console.WriteLine(line); } } while (line != null); } catch (Exception e) { Console.WriteLine("Error!!!"); } } }

    class TextToHTML { private string[] html; private int lines; private int count; public TextToHTML() { count = 0; lines = 1000; html = new string[lines]; } public void ToFile(string nameFile) { try { StreamWriter file = File.CreateText(nameFile); file.WriteLine(ToString()); file.Close(); } catch (Exception e) { Console.WriteLine("Error!!!"); } } public void Add(string line) { if (count < lines) { html[count] = line; count++; } } public string ToString() { string textHtml; textHtml = "\n"; textHtml += "\n"; for (int i = 0; i < count; i++) { textHtml += " "; textHtml += html[i]; textHtml += " \n"; } textHtml += "\n"; textHtml += "\n"; return textHtml; } public void Display() { Console.Write(ToString()); } }
    class Test { static void Main() { TextToHTML textToHTML = new TextToHTML(); textToHTML.Add("Hello"); textToHTML.Add("How are you?"); textToHTML.Display(); textToHTML.ToFile("prueba.html"); } }


    class TXTtoHTML
    {
        static void Main()
        {
            Console.Write("Enter name of file: ");
            string nameTXT = Console.ReadLine();
            string nameHTML = nameTXT.Substring(0, nameTXT.Length - 4);
            if (File.Exists(nameTXT))
            {
                StreamReader fileTXT = File.OpenText(nameTXT);
                StreamWriter fileHTML = File.CreateText(nameHTML + ".html");
                fileHTML.WriteLine(""); fileHTML.WriteLine("");
                fileHTML.WriteLine(""); fileHTML.WriteLine("");
                fileHTML.WriteLine(""); string line; do
                {
                    line = fileTXT.ReadLine();
                    if (line != null) fileHTML.WriteLine(" " + line + " ");
                } while (line != null);
                fileHTML.WriteLine("");
                fileHTML.WriteLine("");
                fileTXT.Close();
                fileHTML.Close();
            }
        }
    }
}
