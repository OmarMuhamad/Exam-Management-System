using System;

namespace Exam02Solution
{
    internal abstract class Exam
    {
        // Properties for exam time, number of questions, and the list of questions
        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        // Constructor initializing exam time and number of questions
        public Exam(int examTime, int numberOfQuestions)
        {
            ExamTime = examTime;
            NumberOfQuestions = numberOfQuestions;
        }

        // Abstract methods for showing and creating exam questions
        public void ShowExam()
        {
            foreach (Question q in Questions)
            {
                Console.WriteLine(q);
                for (int i = 0; i < q.Answers.Length; i++)
                {
                    Console.WriteLine(q.Answers[i]);
                }
                Console.WriteLine("____________________________________");

                // Accept user input for answer and assign it to UserAnswer
                int userAnswer;
                do
                {
                    Console.WriteLine("Enter Your Answer: ");
                } while (!int.TryParse(Console.ReadLine(), out userAnswer));

                q.UserAnswer.AnswerID = userAnswer;
                q.UserAnswer.AnswerText = q.Answers[userAnswer - 1].AnswerText;
                Console.WriteLine("____________________________________");
            }
        }
        public abstract void CreateListOfQuestions();
        public abstract void ShowAdditionalDetails();

        // Override for custom string representation
        public override string ToString()
        {
            return $"{NumberOfQuestions} questions, {ExamTime} minutes";
        }
    }
}
