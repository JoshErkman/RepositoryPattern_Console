using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        // Method that runs/starts the application
        public void Run()
        {
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                // Get the users input
                string input = Console.ReadLine();


                // Evaluate the user input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        break;
                    case "2":
                        //View All Content
                        break;
                    case "3":
                        //View content by title
                        break;
                    case "4":
                        //Update Existing Content
                        break;
                    case "5":
                        //Delete Existing Content
                        break;
                    case "6":
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;


                }
            }
        }
    }
}
