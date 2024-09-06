# Exam Management System

## Overview

The Exam Management System project is a console-based application designed to create, manage, and administer exams. The system supports two types of exams: Final and Practical. It allows the creation of multiple-choice (MCQ) and true/false (TF) questions. Users can define exam parameters, input questions, and evaluate the results.

## Features

- **Exam Management**: Create and manage different types of exams (Final and Practical).
- **Question Types**: Support for multiple-choice (MCQ) and true/false (TF) questions.
- **Interactive Console**: Input questions and answers interactively through the console.
- **Exam Administration**: Administer the exam by displaying questions, accepting user answers, and calculating scores.
- **Timing**: Track the duration of the exam.

## Classes and Their Responsibilities

### `Exam` (Abstract Class)
- **Properties**:
  - `ExamTime`: Duration of the exam in minutes.
  - `NumberOfQuestions`: Total number of questions in the exam.
  - `Questions`: Array of `Question` objects.
- **Methods**:
  - `ShowExam()`: Displays the exam questions and handles user answers.
  - `CreateListOfQuestions()`: Abstract method for creating a list of questions.
  - `ShowAdditionalDetails()`: Abstract method for showing additional exam details.
  - `ToString()`: Custom string representation of the exam.

### `FinalExam` (Derived from `Exam`)
- **Responsibilities**: Implements specific logic for creating and managing final exams.
- **Methods**:
  - `CreateListOfQuestions()`: Prompts the user to create either MCQ or TF questions.
  - `ShowAdditionalDetails()`: Calculates and displays the score, user answers, and correct answers.

### `PracticalExam` (Derived from `Exam`)
- **Responsibilities**: Implements specific logic for creating and managing practical exams.
- **Methods**:
  - `CreateListOfQuestions()`: Creates a list of MCQ questions.
  - `ShowAdditionalDetails()`: Displays all questions with their correct answers.

### `Question` (Abstract Class)
- **Properties**:
  - `Header`: Header or title of the question.
  - `Body`: Content of the question.
  - `Mark`: Score assigned to the question.
  - `Answers`: Array of possible answers.
  - `CorrectAnswer`: The correct answer.
  - `UserAnswer`: The user's selected answer.
- **Methods**:
  - `AddQuestion()`: Abstract method for adding question details.
  - `ToString()`: Custom string representation of the question.

### `MCQ` (Derived from `Question`)
- **Responsibilities**: Represents a multiple-choice question.
- **Methods**:
  - `AddQuestion()`: Prompts the user to input question details, choices, and the correct answer.
  - `ToString()`: Custom string representation for MCQ.

### `TrueFalse` (Derived from `Question`)
- **Responsibilities**: Represents a true/false question.
- **Methods**:
  - `AddQuestion()`: Prompts the user to input question details and the correct answer.
  - `ToString()`: Custom string representation for TF questions.

### `Subject`
- **Properties**:
  - `SubjectId`: Unique identifier for the subject.
  - `SubjectName`: Name of the subject.
  - `SubjectExam`: An instance of `Exam` (either `FinalExam` or `PracticalExam`).
- **Methods**:
  - `CreateExam()`: Prompts the user to create an exam and initialize it with questions.

### `Answer`
- **Properties**:
  - `AnswerID`: Identifier for the answer.
  - `AnswerText`: Text of the answer.

### `Program`
- **Responsibilities**: Entry point of the application. Handles user interaction to create and start exams.
- **Methods**:
  - `Main()`: Main method that initiates the subject and exam creation, and handles user interaction for starting the exam.

## How to Use

1. **Run the Application**: Start the application by running the `Program` class.
2. **Create a Subject**: Enter the subject ID and name.
3. **Create an Exam**: Choose the type of exam (Practical or Final), and input the exam details such as duration and number of questions.
4. **Add Questions**: Add questions to the exam, selecting from MCQ or TF types.
5. **Take the Exam**: Choose to start the exam, answer the questions, and see the results.

## Example

Here is an example of how the application workflow looks:

```
Enter Time of The Exam: 60
Enter Number of Questions: 5
Enter Type of Exam [1] Practical, [2] Final Exam: 2
Enter type of questions [1 - MCQ]/[2 - TF]: 1
Enter Body of the Question: What is 2+2?
Enter the Mark of The Question: 1
Choices: 
Enter Choice 1
4
Enter Choice 2
5
Enter Choice 3
6
Enter Correct Answer Id: 1
...
```

## Contributing

Contributions are welcome! Please submit a pull request or open an issue if you encounter any bugs or have suggestions for improvements.
