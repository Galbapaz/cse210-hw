using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal(); 
        PromptGenerator promptGenerator = new PromptGenerator();

        bool isRunning = true; 

        while(isRunning)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine(); 
            Console.WriteLine(); 

            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry();

                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(newEntry._promptText);
                    Console.Write("> ");
                    newEntry._entryText = Console.ReadLine();

                    theJournal.AddEntry(newEntry);
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;

                case "5":
                    isRunning = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
        }

            
        }

            

        
    }