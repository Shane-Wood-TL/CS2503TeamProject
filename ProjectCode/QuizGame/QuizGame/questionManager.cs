using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace QuizGame
{
    public class Question
    {
        //setting up class variables
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public string PictureLocation { get; set; }
        public string narrationLocation { get; set; }
        public int CorrectAnswerIndex { get; set; }

        //"struct" for a question
        public Question(string questionText, string[] answers, string pictureLocation, string soundLocation, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            PictureLocation = pictureLocation;
            CorrectAnswerIndex = correctAnswerIndex;
            narrationLocation = soundLocation;
        }

        //checks if button index matches answer index
        public bool CheckAnswer(int answerIndex)
        {
            return answerIndex == CorrectAnswerIndex;
        }
    }

    //manages multiple questions and file reading
    public class QuestionManager
    {
        //setting up class variables
        public List<Question> Questions { get; set; }
        public int CurrentQuestionIndex { get; set; }

        //constructor
        public QuestionManager()
        {
            Questions = new List<Question>();
            CurrentQuestionIndex = 0;
        }

        //reading the question file
        public void LoadQuestionsFromFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath); //read the entire text file
                List<string> questionData = new List<string>();
                foreach (var line in lines) //go through each line
                {
                    if (string.IsNullOrWhiteSpace(line)) //handling some basic broken formatting by removing it
                    {
                        if (questionData.Count > 0) //if there is no answers/questions
                        {
                            AddQuestionFromData(questionData);
                            questionData.Clear();
                        }
                    }
                    else
                    {
                        questionData.Add(line.Trim()); //remove spaces
                    }
                }
                // Add the last question if the file doesn't end with a blank line
                if (questionData.Count > 0)
                {
                    AddQuestionFromData(questionData);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error reading questions from file: {ex.Message}"); //if error show in console
            }
        }

        private void AddQuestionFromData(List<string> questionData)
        {
            if (questionData.Count < 6) return; // Each question needs at least 6 lines: question, 4 answers, sound file path (+1 maybe for image)

            string questionText = questionData[0]; // Gets the question
            string[] answers = questionData.GetRange(1, 4).ToArray(); // Gets the answer strings
            string pictureLocation = questionData.Count > 7 ? questionData[5] : string.Empty; // Handle optional image path
            string soundFilePath = questionData.Count > 6 ? questionData[6] : string.Empty; // Handle optional sound file path

            // Get the correct answer index
            int correctAnswerIndex;
            if (int.TryParse(questionData[questionData.Count - 1], out correctAnswerIndex))
            {
                Questions.Add(new Question(questionText, answers, pictureLocation, soundFilePath, correctAnswerIndex)); // Add a question that was read correctly
            }
            else
            {
                Debug.WriteLine($"Invalid correct answer index: {questionData[questionData.Count - 1]}"); // Mark if answer is not possible
            }
        }

        public Question GetNextQuestion()
        {
            if (CurrentQuestionIndex < Questions.Count)
            {
                return Questions[CurrentQuestionIndex++]; //gets the next question, that way it is known when to switch to the end card
            }
            return null; // No more questions, exit
        }
    }
}
