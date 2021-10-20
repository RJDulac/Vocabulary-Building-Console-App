using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace VocabularyBuildingConsoleApp
{
    public class Vocabulary
    {
        private Dictionary<string, string> vocabList = new Dictionary<string, string>();
        private string fileName = "Vocabulary.txt";

        public void CreateFile()
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    System.Console.WriteLine("Doesn't exist");
                    using (FileStream fs = File.Create(fileName)) ;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }

        }
        public void ListAllVocabulary()
        {
            System.Console.WriteLine("test");
        }

    }
}