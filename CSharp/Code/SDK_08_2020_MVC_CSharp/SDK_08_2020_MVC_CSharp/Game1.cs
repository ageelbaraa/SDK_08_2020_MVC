using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpCodes
{
    class Game1
    {
        private string Choice = "";
        private int CounterOne = 0;
        private int CounterTwo = 0;

        Random rand = new Random();

        public void Play()
        {
            Console.WriteLine("Welcome to RPS game");

            while (Choice != "no")
            {
                Console.WriteLine("Select any one:\n1->roke\n2->paper\n3->scissor");
                string[] Posiples = new string[3] { "roke", "paper", "scissor" };
                Random rnd = new Random();
                int choise = rnd.Next(0, 3);
                Console.Write("\n Enter your choice : ");
                string Player = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine($" You : {Player}    x    Computer: {Posiples[choise]}\n");


                if (Player == "roke" && Posiples[choise] == "scissor")
                {
                    Console.WriteLine(" You win");
                    CounterOne += 1;
                }
                else if (Player == "roke" && Posiples[choise] == "paper")
                {
                    Console.WriteLine(" Computer wins");
                    CounterTwo += 1;
                }
                else if (Player == "paper" && Posiples[choise] == "roke")
                {
                    Console.WriteLine(" You win");
                    CounterOne += 1;
                }
                else if (Player == "paper" && Posiples[choise] == "scissor")
                {
                    Console.WriteLine(" Computer Wins");
                    CounterTwo += 1;
                }
                else if (Player == "scissor" && Posiples[choise] == "roke")
                {
                    Console.WriteLine(" Computer Wins");
                    CounterTwo += 1;
                }
                else if (Player == "scissor" && Posiples[choise] == "paper")
                {
                    Console.WriteLine(" You win");
                    CounterOne += 1;
                }
                else
                {
                    Console.WriteLine(" Same choices");
                }
                Console.Write("\nDo u want to continue(yes/no):");
                Choice = Console.ReadLine().ToLower();
                Console.WriteLine("---------------------------------------");
              
                
            }
            Console.WriteLine("User wins " + CounterOne + " times");
            Console.WriteLine("Computer wins " + CounterTwo + " times");
        }

    }



    class Game
    {
        static void Main(string[] args)
        {
            Game1 game = new Game1();
            Console.WriteLine();
            Console.Write(">> ");
            game.Play();
            Console.WriteLine("\n\n");
            Console.WriteLine("Done");
            Console.ReadKey();
        }

    }

}

