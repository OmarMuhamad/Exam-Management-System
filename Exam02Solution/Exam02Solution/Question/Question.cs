using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02Solution
{
    // Abstract class representing a generic question
    abstract class Question
    {
        // Abstract property for the header/title of the question. 
        // It must be implemented in derived classes.
        public abstract String Header { get; }

        // Property representing the body/content of the question.
        // It can be set and get.
        public String Body { get; set; }

        // Property representing the mark/score assigned to the question.
        // It can be set and get.
        public int Mark { get; set; }

        // Array of possible answers to the question.
        // It can be set and get.
        public Answer[] Answers { get; set; }

        // Property representing the correct answer to the question.
        // It can be set and get.
        public Answer CorrectAnswer { get; set; }

        // Property representing the user's selected answer.
        // It can be set and get.
        public Answer UserAnswer { get; set; }

        // Constructor initializes CorrectAnswer and UserAnswer properties with new Answer objects.
        public Question()
        {
            this.CorrectAnswer = new Answer();
            this.UserAnswer = new Answer();
        }

        // Abstract method for adding a question.
        // Derived classes must implement this method.
        public abstract void AddQuestion();

        // Override of the ToString method to return a formatted string representing the question's header, mark, and body.
        public override string ToString()
        {
            return $"{Header} \t Mark : {Mark} \n"
                + "------------------------------------" +
                $"\n {Body} \n";
        }
    }

}
