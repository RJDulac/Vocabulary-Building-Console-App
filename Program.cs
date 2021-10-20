using System;
using System.Collections.Generic;

namespace VocabularyBuildingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            Vocabulary myVocabulary = new Vocabulary();
            myVocabulary.CreateFile();

            // Dictionary<string, string> vocabList = new Dictionary<string, string>()
            // {
            //     {"Lucid", "very clear and easy to understand"},
            //     {"Erudite", "having or showing great knowledge"},
            //     {"Opaque", "not able to be seen through; not easily understood"}
            // };
            // vocabList.Add("Abscond", "leave hurriedly and secretly");

            do
            {
                Console.WriteLine("**Vocabulary Builder***");
                Console.WriteLine("Type 'Q' to quit.");
                Console.WriteLine("Type 'L' to get the entire vocabulary list.");


                myVocabulary.ListAllVocabulary();

                string input = Console.ReadLine().ToUpper();

                if (input == "Q")
                {
                    isRunning = false;
                }
                // if (input == "L")
                // {
                //     foreach (KeyValuePair<string, string> kvp in vocabList)
                //     {
                //         Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                //     }
                // }
            } while (isRunning == true);
        }
    }
}
