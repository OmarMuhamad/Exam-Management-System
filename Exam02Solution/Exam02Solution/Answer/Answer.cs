using System;

namespace Exam02Solution
{
    internal class Answer
    {
        // Properties for Answer ID and text
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }

        // Constructor with parameters
        public Answer(int answerId, string answerText)
        {
            AnswerID = answerId;
            AnswerText = answerText;
        }

        // Default constructor
        public Answer() { }

        // Override for custom string representation
        public override string ToString()
        {
            return $"{AnswerID} - {AnswerText}";
        }
    }
}
