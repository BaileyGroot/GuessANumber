using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomnumber = random.Next(1, 11);



            Console.WriteLine("Write your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + " to Guess a number!");

            Console.WriteLine("Guess a number between 1-10.");

            Console.WriteLine("You have 3 tries.");

            Console.WriteLine("Round 1");

            Console.WriteLine("Enter a number: ");

            double guess1 = double.Parse(Console.ReadLine());



            if (guess1 == randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You guessed the correct number! Congrats on winning the game.");

            }

            else if (guess1 < randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were higher than: " + guess1);

            }

            else

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were lower" + " than: " + guess1);

            }



            Console.WriteLine("Round 2");



            Console.WriteLine("Enter a number: ");

            double guess2 = double.Parse(Console.ReadLine());



            if (guess1 == randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("System: You guessed the correct number! Congrats on winning the game.");

            }

            else if (guess2 < randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were higher than: " + guess2);

            }

            else

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were lower than: " + guess2);

            }



            Console.WriteLine("Round 3");



            Console.WriteLine("Enter a number: ");

            double guess3 = double.Parse(Console.ReadLine());



            if (guess1 == randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You guessed the correct number! Congrats on winning the game.");

            }

            else if (guess3 < randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were higher than: " + guess3);

            }

            else

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were lower than: " + guess3);

            }





            Console.ReadKey();
        }
    }
}
