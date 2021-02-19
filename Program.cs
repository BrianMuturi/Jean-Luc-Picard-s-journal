using System;
using System.IO;

namespace Jean_Luc_Picard_s_journal
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Welcome to Jean-Luc Picard’s journal\n");
                Console.WriteLine("INSTRUCTIONS");
                Console.WriteLine("Press 1: Start");
                Console.WriteLine("Press 2: end");
                string choice = Console.ReadLine();
                static void enterContent()
                {
                    Console.Write("Enter text");
                    Console.WriteLine("");
                    string input = Console.ReadLine();
                    string docPath =Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss")+".txt"), true))
                    {
                        outputFile.WriteLine(input);
                    }
                    

                }

                switch (choice)
                {
                    case "1":
                        enterContent();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                }
            }
            
        }
    }
}
