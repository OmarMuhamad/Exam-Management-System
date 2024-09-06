using System;

namespace Exam02Solution
{
    internal class Subject
    {
        // Properties for subject ID, name, and the associated exam
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        // Constructor initializing the subject ID and name
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        // Method to create an exam (final or practical) based on user input
        public void CreateExam()
        {
            int time;
            do
            {
                Console.WriteLine("Enter Time of The Exam: ");
            } while (!int.TryParse(Console.ReadLine(), out time));

            int numberOfQuestions;
            do
            {
                Console.WriteLine("Enter Number of Questions: ");
            } while (!int.TryParse(Console.ReadLine(), out numberOfQuestions));

            int typeOfExam;
            do
            {
                Console.WriteLine("Enter Type of Exam [1] Practical, [2] Final Exam: ");
            } while (!int.TryParse(Console.ReadLine(), out typeOfExam));

            // Create either a PracticalExam or FinalExam based on user choice
            if (typeOfExam == 1)
            {
                SubjectExam = new PracticalExam(time, numberOfQuestions);
            }
            else
            {
                SubjectExam = new FinalExam(time, numberOfQuestions);
            }
            SubjectExam.CreateListOfQuestions();
        }
    }
}