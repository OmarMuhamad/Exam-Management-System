using System;

namespace Exam02Solution
{
    internal class PracticalExam : Exam
    {
        // Constructor that initializes the PracticalExam
        public PracticalExam(int examTime, int numberOfQuestions) : base(examTime, numberOfQuestions) { }

        // Creates a list of multiple-choice questions for the exam
        public override void CreateListOfQuestions()
        {
            this.Questions = new MCQ[NumberOfQuestions]; // Create an array of MCQ questions
            for (int i = 0; i < this.Questions.Length; i++)
            {
                this.Questions[i] = new MCQ();  // Initialize each question as MCQ
                this.Questions[i].AddQuestion(); // Add the question details

                Console.Clear();  // Clear console after each question
            }
        }

        // Displays the exam and processes user input for answers
        public override void ShowAdditionalDetails()
        {
            // Display all questions and correct answers
            Console.WriteLine("All the Answers to All Questions");
            for (int i = 0; i < this.Questions.Length; i++)
            {
                Console.WriteLine($"Q {i + 1} : {this.Questions[i].Body}");
                Console.WriteLine($"Right Answer : {this.Questions[i].CorrectAnswer.AnswerText}");
            }
        }
    }
}
