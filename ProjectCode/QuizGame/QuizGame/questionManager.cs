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
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public string PictureLocation { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string questionText, string[] answers, string pictureLocation, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            PictureLocation = pictureLocation;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool CheckAnswer(int answerIndex)
        {
            return answerIndex == CorrectAnswerIndex;
        }
    }

    public class QuestionManager
    {
        public List<Question> Questions { get; set; }
        public int CurrentQuestionIndex { get; set; }

        public QuestionManager()
        {
            Questions = new List<Question>();
            CurrentQuestionIndex = 0;
        }

        public void LoadQuestionsFromFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath); //read the entire text file
                List<string> questionData = new List<string>();
                foreach (var line in lines) //go through each line
                {
                    if (string.IsNullOrWhiteSpace(line))
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
                Console.WriteLine($"Error reading questions from file: {ex.Message}");
            }
        }

        private void AddQuestionFromData(List<string> questionData)
        {
            if (questionData.Count < 5) return; // each question needs 5 lines; question 1,2,3,4, image, answer index

            string questionText = questionData[0];
            string[] answers = questionData.GetRange(1, 4).ToArray();
            string pictureLocation = questionData.Count > 5 ? questionData[5] : string.Empty; // Handle optional image path

            //get the correct answer
            int correctAnswerIndex;
            if (int.TryParse(questionData[questionData.Count - 1], out correctAnswerIndex))
            {
                Questions.Add(new Question(questionText, answers, pictureLocation, correctAnswerIndex));
            }
            else
            {
                //use console to find errors
                Console.WriteLine($"Invalid correct answer index: {questionData[questionData.Count - 1]}");
            }
        }

        public Question GetNextQuestion()
        {
            if (CurrentQuestionIndex < Questions.Count)
            {
                return Questions[CurrentQuestionIndex++];
            }
            return null; // No more questions, exit
        }
    }
}
