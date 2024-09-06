using System;
using System.Diagnostics;

namespace Exam02Solution
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a subject with ID 1 and name "C#"
            Subject s1 = new(1, "C#");

            // Prompt user to create an exam for the subject
            s1.CreateExam();
            Console.Write("Do You Want To Start Exam Now? (Y | N): ");

            // Read user choice to start the exam
            char choice;
            do
            {
                Console.Write("Do You Want To Start Exam Now? (Y | N): ");
                choice = char.ToUpper(Console.ReadKey().KeyChar); // Read the user's input and convert to uppercase
                Console.WriteLine(); // For newline after the input

                if (choice != 'Y' && choice != 'N')
                {
                    Console.WriteLine("Invalid choice. Please enter 'Y' or 'N'.");
                }

            } while (choice != 'Y' && choice != 'N'); // Continue looping until a valid choice is made

            if (choice == 'Y')
            {
                Console.Clear();

                // Start the stopwatch to measure exam duration
                Stopwatch sw = new();
                sw.Start();

                // Display the exam and accept answers
                s1.SubjectExam.ShowExam();
                s1.SubjectExam.ShowAdditionalDetails();

                // Stop the stopwatch and display the taken time
                Console.WriteLine($"\nTaken Time = {sw.Elapsed}");
            }
            else
            {
                // If the user chooses not to start the exam
                Console.WriteLine("Thank You!");
            }
        }
    }
}
