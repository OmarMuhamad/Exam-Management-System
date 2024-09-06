using System;

namespace Exam02Solution
{
    internal class FinalExam : Exam
    {
        // Constructor that calls the base class constructor
        public FinalExam(int examTime, int numberOfQuestions) : base(examTime, numberOfQuestions) { }
        // Creates the list of questions for the exam
        public override void CreateListOfQuestions()
        {
            this.Questions = new Question[this.NumberOfQuestions]; // Create an Array of Question Which will be MCQ or TF
            for (int i = 0; i < this.NumberOfQuestions; i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("Enter type of questions [1 - MCQ]/[2 - TF]");
                } while (!int.TryParse(Console.ReadLine(), out choice));

                // Add either MCQ or TrueFalse question based on user choice
                if (choice == 1)
                {
                    this.Questions[i] = new MCQ(); // MCQ Question
                    this.Questions[i].AddQuestion(); // Add the question details
                }
                else if (choice == 2)
                {
                    this.Questions[i] = new TrueFalse(); // TF Question
                    this.Questions[i].AddQuestion(); // Add the question details
                }
            }
        }

        // Displays the exam and handles user input for answers
        public override void ShowAdditionalDetails()
        {
            // Calculate the total score and grade
            int totalMark = 0, grade = 0;
            for (int i = 0; i < this.Questions.Length; i++)
            {
                totalMark += this.Questions[i].Mark;
                if (this.Questions[i].UserAnswer.AnswerID == this.Questions[i].CorrectAnswer.AnswerID)
                {
                    grade += this.Questions[i].Mark;
                }
            }

            // Display answers and final score
            Console.WriteLine("All the Answers to All Questions");
            for (int i = 0; i < this.Questions.Length; i++)
            {
                Console.WriteLine($"Q {i + 1} : {this.Questions[i].Body}");
                Console.WriteLine($"Your Answer  : {this.Questions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right Answer : {this.Questions[i].CorrectAnswer.AnswerText}");
            }
            Console.WriteLine($"You Scored {grade} out of {totalMark}");
        }        
    }
}
