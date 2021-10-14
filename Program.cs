using System;

namespace VocabularyBuildingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            do
            {
                Console.WriteLine("**Vocabulary Builder***");
                Console.WriteLine("Press 'Q' to quit.");

                string input = Console.ReadLine().ToUpper();

                if (input == "Q")
                {
                    isRunning = false;
                }
            } while (isRunning == true);
        }
    }
}
