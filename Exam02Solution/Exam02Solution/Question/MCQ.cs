using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02Solution
{
    internal class MCQ : Question
    {
        public override string Header => "MCQ Question";
        public MCQ()
        {
            this.Answers = new Answer[3];
        }
        // Function to Add Question
        public override void AddQuestion()
        {
            Console.WriteLine(Header);

            // Getting the Body of The Question
            Console.WriteLine("Enter Body of the Question: ");
            this.Body = Console.ReadLine();

            // Getting the Mark of The Question
            int mark;
            do
            {
                Console.WriteLine("Enter the Mark of The Question: ");

            } while (!int.TryParse(Console.ReadLine(), out mark));
            this.Mark = mark; // setting the mark entered to the mark of the question

            // Getting All Choices
            Console.WriteLine("Choices: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Choice {i + 1}");
                this.Answers[i] = new Answer
                {
                    AnswerID = i + 1,
                    AnswerText = Console.ReadLine()
                };
            }

            // Getting the Correc Answer
            int correctAnswerId;
            do
            {
                Console.WriteLine("Enter Correct Answer Id");

            } while (!int.TryParse(Console.ReadLine(), out correctAnswerId));
            this.CorrectAnswer.AnswerID = correctAnswerId; // Set Answer Id to the correct one
            this.CorrectAnswer.AnswerText = this.Answers[correctAnswerId - 1].AnswerText; // Set Answer Text to the correct one
            Console.Clear();
        }
    }
}
