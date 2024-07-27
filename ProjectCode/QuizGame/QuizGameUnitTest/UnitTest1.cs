using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizGame;
using System.Collections.Generic;
using System.IO;

namespace QuizGameTests
{
    [TestClass]
    public class QuestionTests
    {
        [TestMethod]
        public void CheckAnswer_CorrectAnswer_ReturnsTrue()
        {
            // Arrange
            string questionText = "Where is Trine University?";
            string[] answers = { "Ohio", "Michigan", "Indiana", "Wisconsin" };
            string pictureLocation = "Pictures/trine.jpg";
            string narrationLocation = "Narration/q1Narration.wav";
            int correctAnswerIndex = 2;
            Question question = new Question(questionText, answers, pictureLocation, narrationLocation, correctAnswerIndex);

            // Act
            bool result = question.CheckAnswer(correctAnswerIndex);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result, "Expected answer index 2 to be correct.");
        }

        [TestMethod]
        public void CheckAnswer_WrongAnswer_ReturnsFalse()
        {
            // Arrange
            string questionText = "Where is Trine University?";
            string[] answers = { "Ohio", "Michigan", "Indiana", "Wisconsin" };
            string pictureLocation = "Pictures/trine.jpg";
            string narrationLocation = "Narration/q1Narration.wav";
            int correctAnswerIndex = 2;
            Question question = new Question(questionText, answers, pictureLocation, narrationLocation, correctAnswerIndex);

            // Act
            bool result = question.CheckAnswer(1);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result, "Expected answer index 1 to be incorrect.");
        }
    }

    [TestClass]
    public class QuestionManagerTests
    {
        private string filePath = "";

        [TestInitialize]
        public void Setup()
        {
            // Arrange
            filePath = "questions.txt";
            string[] fileLines = {
                "Where is Trine University?",
                "Ohio",
                "Michigan",
                "Indiana",
                "Wisconsin",
                "Pictures/trine.jpg",
                "Narration/q1Narration.wav",
                "2",
                "",
                "What is this class called?",
                "CS2503",
                "CS1113",
                "CS3613",
                "CS2103",
                "none",
                "Narration/q2Narration.wav",
                "0",
                "",
                "What Language is the program written in?",
                "C++",
                "C#",
                "Python",
                "C",
                "Pictures/programmingLanguages.jpg",
                "Narration/q3Narration.wav",
                "1",
                "",
                "Did you enjoy the quiz?",
                "Yes",
                "No",
                "none",
                "none",
                "none",
                "Narration/q4Narration.wav",
                "0"
            };
            File.WriteAllLines(filePath, fileLines);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        [TestMethod]
        public void LoadQuestionsFromFile_ValidFile_QuestionsLoaded()
        {
            // Arrange
            QuestionManager questionManager = new QuestionManager();

            // Act
            questionManager.LoadQuestionsFromFile(filePath);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(4, questionManager.Questions.Count, "Expected 4 questions to be loaded.");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Where is Trine University?", questionManager.Questions[0].QuestionText, "First question text does not match.");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("What is this class called?", questionManager.Questions[1].QuestionText, "Second question text does not match.");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("What Language is the program written in?", questionManager.Questions[2].QuestionText, "Third question text does not match.");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Did you enjoy the quiz?", questionManager.Questions[3].QuestionText, "Fourth question text does not match.");
        }

        [TestMethod]
        public void GetNextQuestion_QuestionsAvailable_ReturnsQuestion()
        {
            // Arrange
            string questionText = "Where is Trine University?";
            string[] answers = { "Ohio", "Michigan", "Indiana", "Wisconsin" };
            string pictureLocation = "Pictures/trine.jpg";
            string narrationLocation = "Narration/q1Narration.wav";
            int correctAnswerIndex = 2;
            Question question = new Question(questionText, answers, pictureLocation, narrationLocation, correctAnswerIndex);
            QuestionManager questionManager = new QuestionManager();
            questionManager.Questions.Add(question);

            // Act
            Question result = questionManager.GetNextQuestion();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result, "Expected a question to be returned.");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(questionText, result.QuestionText, "Returned question text does not match.");
        }

        [TestMethod]
        public void GetNextQuestion_NoMoreQuestions_ReturnsNull()
        {
            // Arrange
            QuestionManager questionManager = new QuestionManager();

            // Act
            Question result = questionManager.GetNextQuestion();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNull(result, "Expected null when there are no more questions.");
        }
    }
}
