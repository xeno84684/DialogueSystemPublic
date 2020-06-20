using System;
using DialogueStuff;


namespace TextRPG {
    class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Starting Application...");
            Console.ForegroundColor = ConsoleColor.White;
            
            while (true) {
                Console.WriteLine("Hi, whom would you like to talk to?");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("(1) Felix");
                Console.ForegroundColor = ConsoleColor.White;

                var input = Console.ReadLine();

                if (input == "1") {
                    break;
                }

                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can only choose one option for now my dude.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } 

            Events.SetupAndStart();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hope you had fun!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press Enter to exit the application");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(); //Exit
        }

    }
}
