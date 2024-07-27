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
        public void CheckAnswer_CorrectAnswer_ReturnsTrue() //check if correct answer is picked if it returns true
        {
            // setup up q1
            string questionText = "Where is Trine University?";
            string[] answers = { "Ohio", "Michigan", "Indiana", "Wisconsin" };
            string pictureLocation = "Pictures/trine.jpg";
            string narrationLocation = "Narration/q1Narration.wav";
            int correctAnswerIndex = 2;
            //make question object
            Question question = new Question(questionText, answers, pictureLocation, narrationLocation, correctAnswerIndex);

            // test
            //check correct index
            bool result = question.CheckAnswer(correctAnswerIndex);

            //results
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result, "Expected answer index 2 to be correct.");
        }

        [TestMethod]
        public void CheckAnswer_WrongAnswer_ReturnsFalse() //check if wrong answer is picked if it returns false
        {
            // setup up q1
            string questionText = "Where is Trine University?";
            string[] answers = { "Ohio", "Michigan", "Indiana", "Wisconsin" };
            string pictureLocation = "Pictures/trine.jpg";
            string narrationLocation = "Narration/q1Narration.wav";
            int correctAnswerIndex = 2;
            //make question object
            Question question = new Question(questionText, answers, pictureLocation, narrationLocation, correctAnswerIndex);

            //test
            //check non correct index
            bool result = question.CheckAnswer(1);

            //results
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result, "Expected answer index 1 to be incorrect.");
        }
    }
}