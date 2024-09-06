using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02Solution
{
    class TrueFalse : Question
    {
        public override string Header => "True | False Question";
        public TrueFalse()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");
        }

        public override string ToString()
        {
            return $"[T/F] - {Body}";
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

            } while(!int.TryParse(Console.ReadLine(), out mark));
            this.Mark = mark; // setting the mark entered to the mark of the question

            // Getting the Correct Answer 
            int correctAnswerId;
            do
            {
                Console.WriteLine("Enter Correct Answer Id");

            } while(!int.TryParse(Console.ReadLine(), out correctAnswerId));
            this.CorrectAnswer.AnswerID = correctAnswerId; // Set Answer Id to the correct one
            this.CorrectAnswer.AnswerText = this.Answers[correctAnswerId - 1].AnswerText; // Set Answer Text to the correct one

            Console.Clear();
        }
    }
}
