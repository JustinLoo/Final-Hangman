using System;
using System.Threading;
using System.Collections.Generic;

namespace HangMan
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HangMan. Enter your guess");
            Guess();
        }

        public static void GenerateHangMan(int limbs)
        {
            if (limbs == 1)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine("\n");
            }

            if (limbs == 2)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
            }

            if (limbs == 3)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
            }

            if (limbs == 4)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
            }

            if (limbs == 5)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   /");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
            }

            if (limbs == 6)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / \\");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
            }
        }

        public static void Guess()
        {
            int limbs = 0;

            var random = new Random();
            var nameList = new List<string> { "justin", "samson", "samson", "samson" };
            int randomName = random.Next(nameList.Count);

            //creates remain array
            char[] remain = nameList[randomName].ToCharArray();
            //creates result array
            char[] result = new char[remain.Length];

            Console.WriteLine("|----+");
            Console.WriteLine("|    |");
            Console.WriteLine("|    ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("+-------+");
            Console.WriteLine("\n");
            while (true)
            {
                Console.WriteLine("Please type your guess: ");

                string x = Console.ReadLine();

                while (x.Length != 1)
                {
                    Console.WriteLine("Invalid Input, please try typing only one letter.");
                    x = Console.ReadLine();
                }

                char personInput = Convert.ToChar(x);
                Console.WriteLine(" ");
                //the process of switching remian to result
                var guessedCorrect = false;

                for (int i = 0; i < remain.Length; i++)
                {
                    if (personInput == remain[i])
                    {
                        char temp = remain[i];
                        remain[i] = ' ';
                        result[i] = temp;
                        guessedCorrect = true;
                    }
                }

                if (guessedCorrect)
                {
                    Console.WriteLine("That letter is correct. Your current guess");
                }
                if (!guessedCorrect)
                {
                    limbs++;
                    Console.WriteLine("That letter was incorrect.");
                }

                for (int i = 0; i < remain.Length; i++)
                {
                    Console.Write(result[i]);
                }
                Console.WriteLine("   ");
                Console.Write("");
                Console.Write("");

                var win = true;
                for (int i = 0; i < remain.Length; i++)
                {
                    if (remain[i] != ' ')
                    {
                        win = false;
                    }
                }
                if (win)
                {
                    Console.WriteLine("Congrats! You Won!");
                    break;
                }

                GenerateHangMan(limbs);

                if (limbs == 6)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("YOU LOSE.");
                    Console.WriteLine("The word was " + nameList[randomName]);
                    break;
                }
            }
        }
    }
}




