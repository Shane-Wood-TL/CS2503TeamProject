using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace QuizGame
{   
    public partial class Form1 : Form
    {
        bool debuggingMode = false;
        int score = 0;
        private QuestionManager questionManager;
        private Question currentQuestion;
        public Form1()
        {
            InitializeComponent();
            questionManager = new QuestionManager();
            LoadQuestionsFromDefaultFile();
        }

        private void LoadQuestionsFromDefaultFile()
        {
            string filePath = "questions.txt"; // The path to the questions file
            if (File.Exists(filePath))
            {
                questionManager.LoadQuestionsFromFile(filePath);
            }
            else
            {
                Debug.WriteLine($"The file {filePath} was not found.", "File Not Found");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea; //get the active resolution of the display (minus taskbar)
            this.Size = new System.Drawing.Size(800, 600); //set the inital
            //window size to be 65% of the active resolution
            this.Location = new System.Drawing.Point(20, 20); //open the window at position 20,20
            MainMenuGroupBox.Visible = true;
            settingsGroupBox.Visible = false;
            questionForm.Visible = false;
            endScreen.Visible = false;
        }

        private void playbuttonClick(object sender, EventArgs e) //main menu, play button 
        {
            score = 0;
            scoreAmount.Text = score.ToString(); //display new score
            questionManager.CurrentQuestionIndex = 0;
            if (debuggingMode == false)
            {
                questionForm.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window
                MainMenuGroupBox.Visible = false;
                settingsGroupBox.Visible = false;
                questionForm.Visible = true;
            }
            else
            {
                questionForm.Location = new System.Drawing.Point(800, 0); //move the group box to the visble window
                MainMenuGroupBox.Visible = true;
                settingsGroupBox.Visible = true;
                questionForm.Visible = true;
            }
            endScreen.Visible = false;
            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            currentQuestion = questionManager.GetNextQuestion();
            if (currentQuestion != null)
            {
                // Update UI with the current question details
                QuestionText.Text = currentQuestion.QuestionText;
                Answer0.Text = currentQuestion.Answers[0];
                Answer1.Text = currentQuestion.Answers[1];
                Answer2.Text = currentQuestion.Answers[2];
                Answer3.Text = currentQuestion.Answers[3];
                if (currentQuestion.PictureLocation == "none")
                {
                    pictureBox1.Visible = false; //hide if no picture is given
                }
                else
                {
                    pictureBox1.Visible = true; //show if picture
                    pictureBox1.ImageLocation = currentQuestion.PictureLocation;
                }
            }
            else
            {
                // Handle the case where there are no more questions
                if (debuggingMode == false)
                {
                    questionForm.Visible = false;
                    endScreen.Visible = true;
                    endScreen.Location = new System.Drawing.Point(0, 0);
                }
            }
        }

        private void quitProgram(object sender, EventArgs e) //main menu, quit button
        {
            this.Close();
        }


        private void returnToMainMenuEnd(object sender, EventArgs e) //mainMenuEndScreen
        {
            if (debuggingMode == false)
            {
                MainMenuGroupBox.Visible = true;
                settingsGroupBox.Visible = false;
                questionForm.Visible = false;
                endScreen.Visible = false;
            }
        }

        private void nextQ(object sender, EventArgs e) //next button
        {
            
            if (debuggingMode == false)
            {
                endScreen.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window
                MainMenuGroupBox.Visible = false;
                settingsGroupBox.Visible = false;
                questionForm.Visible = false;
                endScreen.Visible = true;
            }
            else
            {
                endScreen.Location = new System.Drawing.Point(800, 600); //move the group box to the visble window
            }
        }

        private void settingsFromMain(object sender, EventArgs e) //settings page main menu button
        {
            if (debuggingMode == false)
            {
                MainMenuGroupBox.Visible = true;
                settingsGroupBox.Visible = false;
                questionForm.Visible = false;
                endScreen.Visible = false;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e) //main menu settings button
        { 
            
            if (debuggingMode == false)
            {
                settingsGroupBox.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window
                MainMenuGroupBox.Visible = false; //only hide windows in not debugging
                settingsGroupBox.Visible = true;
                questionForm.Visible = false;
                endScreen.Visible = false;
            }
            else
            {
                settingsGroupBox.Location = new System.Drawing.Point(0, 600); //move the group box to the visble window
            }
        }

        private void Answer0_Click(object sender, EventArgs e) //answer top left
        {
            CheckAnswer(0);
        }

        private void Answer1_Click(object sender, EventArgs e) //answer top right
        {
            CheckAnswer(1);
        }

        private void Answer2_Click(object sender, EventArgs e) //answer bottom left
        {
            CheckAnswer(2);
        }

        private void Answer3_Click(object sender, EventArgs e) //answer bottom right
        {
            CheckAnswer(3);
        }


        private void DebugM_CheckedChanged(object sender, EventArgs e)
        {
            if (debuggingMode == true)
            {
                debuggingMode = false;
                this.Size = new System.Drawing.Size(800, 600); //keep the window at its starting size
                settingsGroupBox.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window
            }
            else
            {
                debuggingMode = true;
                this.Size = new System.Drawing.Size(1600, 1200); //make the window large enough to show all groups
                settingsGroupBox.Location = new System.Drawing.Point(0, 600); //move the group box back to original location
                questionForm.Location = new System.Drawing.Point(800, 0); //move the group box back to original location
                endScreen.Location = new System.Drawing.Point(800, 600); //move the group box back to original location

                MainMenuGroupBox.Visible = true; //only hide windows in not debugging
                settingsGroupBox.Visible = true;
                questionForm.Visible = true;
                endScreen.Visible = true;
            }
        }

        private void CheckAnswer(int answerIndex)
        {
            bool isCorrect = currentQuestion.CheckAnswer(answerIndex);
            if (isCorrect)
            {
                score++;//increase current score if correct
                scoreAmount.Text = score.ToString(); //display new score
            }
            LoadNextQuestion();
        }




    }
}
