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
        private int windowHeight = 600;
        private int windowWidth = 800;

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
            windowWidth = 1920;
            windowHeight = 1080;
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea; //get the active resolution of the display (minus taskbar)
            this.Size = new System.Drawing.Size(windowWidth, windowHeight); ; //set the inital
            //window size to be 65% of the active resolution
            this.Location = new System.Drawing.Point(20, 20); //open the window at position 20,20
            MainMenuGroupBox.Visible = true;
            settingsGroupBox.Visible = false;
            questionForm.Visible = false;
            endScreen.Visible = false;


            settingsGroupBox.Size = new System.Drawing.Size(windowWidth, windowHeight);
            settingsGroupBox.Location = new System.Drawing.Point(0, windowHeight); //move the group box to the visble window

            MainMenuGroupBox.Size = new System.Drawing.Size(windowWidth, windowHeight);
            MainMenuGroupBox.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window

            questionForm.Size = new System.Drawing.Size(windowWidth, windowHeight);
            questionForm.Location = new System.Drawing.Point(windowWidth, 0); //move the group box to the visble window

            endScreen.Size = new System.Drawing.Size(windowWidth, windowHeight);
            endScreen.Location = new System.Drawing.Point(windowWidth, windowHeight); //move the group box to the visble window






            TitleLabel.Size = new System.Drawing.Size(1920, 216);
            TitleLabel.Location = new System.Drawing.Point(0, 0);

            PlayButton.Location = new System.Drawing.Point(48, 252);
            PlayButton.Size = new System.Drawing.Size(768, 216);

            SettingsButton.Location = new System.Drawing.Point(48, 504);
            SettingsButton.Size = new System.Drawing.Size(768, 216);

            QuitButton.Location = new System.Drawing.Point(48, 774);
            QuitButton.Size = new System.Drawing.Size(768, 216);

            HSLabel.Location = new System.Drawing.Point(864, 216);
            HSLabel.Size = new System.Drawing.Size(1056, 126);

            HS0.Location = new System.Drawing.Point(864, 360);
            HS0.Size = new System.Drawing.Size(1056, 100);

            HS1.Location = new System.Drawing.Point(864, 486);
            HS1.Size = new System.Drawing.Size(1056, 100);

            HS2.Location = new System.Drawing.Point(864, 630);
            HS2.Size = new System.Drawing.Size(1056, 100);

            HS3.Location = new System.Drawing.Point(864, 774);
            HS3.Size = new System.Drawing.Size(1056, 100);

            HS4.Location = new System.Drawing.Point(864, 900);
            HS4.Size = new System.Drawing.Size(1056, 100);

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
                questionForm.Location = new System.Drawing.Point(windowWidth, 0); //move the group box to the visble window
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
                endScreen.Location = new System.Drawing.Point(windowWidth, windowHeight); //move the group box to the visble window
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
                settingsGroupBox.Location = new System.Drawing.Point(0, windowHeight); //move the group box to the visble window
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
                this.Size = new System.Drawing.Size(windowWidth, windowHeight); //keep the window at its starting size
                settingsGroupBox.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window
            }
            else
            {
                debuggingMode = true;
                this.Size = new System.Drawing.Size(2* windowWidth, 2* windowHeight); //make the window large enough to show all groups
                settingsGroupBox.Location = new System.Drawing.Point(0, windowHeight); //move the group box back to original location
                questionForm.Location = new System.Drawing.Point(windowWidth, 0); //move the group box back to original location
                endScreen.Location = new System.Drawing.Point(windowWidth, windowHeight); //move the group box back to original location

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //800x600
            //1280x720
            //1920x1080
            //3840 × 2160
            if (comboBox1.Text == "800x600")
            {
                windowHeight = 600;
                windowWidth = 800;

                //update all text and buttons
                //title page
                TitleLabel.Size = new System.Drawing.Size(800, 120);
                TitleLabel.Location = new System.Drawing.Point(0, 0);

                PlayButton.Location = new System.Drawing.Point(20, 140);
                PlayButton.Size = new System.Drawing.Size(320, 120);

                SettingsButton.Location = new System.Drawing.Point(20, 280);
                SettingsButton.Size = new System.Drawing.Size(320, 120);

                QuitButton.Location = new System.Drawing.Point(20, 430);
                QuitButton.Size = new System.Drawing.Size(320, 120);

                HSLabel.Location = new System.Drawing.Point(360, 120);
                HSLabel.Size = new System.Drawing.Size(440, 70);

                HS0.Location = new System.Drawing.Point(360, 200);
                HS0.Size = new System.Drawing.Size(440, 56);

                HS1.Location = new System.Drawing.Point(360, 270);
                HS1.Size = new System.Drawing.Size(440, 56);

                HS2.Location = new System.Drawing.Point(360, 350);
                HS2.Size = new System.Drawing.Size(440, 56);

                HS3.Location = new System.Drawing.Point(360, 430);
                HS3.Size = new System.Drawing.Size(440, 56);

                HS4.Location = new System.Drawing.Point(360, 500);
                HS4.Size = new System.Drawing.Size(440, 56);



                //question page
                QuestionText.Location = new System.Drawing.Point(0, 0);
                QuestionText.Size = new System.Drawing.Size(800, 180);

                pictureBox1.Location = new System.Drawing.Point(0, 180);
                pictureBox1.Size = new System.Drawing.Size(800, 250);

                Answer0.Location = new System.Drawing.Point(0, 344);
                Answer0.Size = new System.Drawing.Size(400, 57);

                Answer1.Location = new System.Drawing.Point(400, 344);
                Answer1.Size = new System.Drawing.Size(400, 57);

                Answer2.Location = new System.Drawing.Point(0, 421);
                Answer2.Size = new System.Drawing.Size(400, 57);

                Answer3.Location = new System.Drawing.Point(400, 421);
                Answer3.Size = new System.Drawing.Size(400, 57);

                questionCount.Location = new System.Drawing.Point(0, 520);
                questionCount.Size = new System.Drawing.Size(100, 57);

                scoreAmount.Location = new System.Drawing.Point(700, 520);
                scoreAmount.Size = new System.Drawing.Size(100, 57);

                nextQuestion.Size = new System.Drawing.Size(300, 57);
                nextQuestion.Location = new System.Drawing.Point(250, 503);

                //Settings Menu
                settingsLabel.Size = new System.Drawing.Size(800, 120);
                settingsLabel.Location = new System.Drawing.Point(0, 0);

                comboBox1.Size = new System.Drawing.Size(120, 57);
                comboBox1.Location = new System.Drawing.Point(400, 178);

                resLabel.Size = new System.Drawing.Size(150, 57);
                resLabel.Location = new System.Drawing.Point(250, 160);

                DebugM.Size = new System.Drawing.Size(300, 57);
                DebugM.Location = new System.Drawing.Point(380, 210);

                soundEffects.Size = new System.Drawing.Size(300, 57);
                soundEffects.Location = new System.Drawing.Point(380, 250);

                Narration.Size = new System.Drawing.Size(300, 57);
                Narration.Location = new System.Drawing.Point(380, 290);

                mainMenuSettings.Size = new System.Drawing.Size(500, 57);
                mainMenuSettings.Location = new System.Drawing.Point(150, 475);


                //End screen
                highScoreEnd.Size = new System.Drawing.Size(800, 140);
                highScoreEnd.Location = new System.Drawing.Point(0, 0);

                youScored.Size = new System.Drawing.Size(500, 57);
                youScored.Location = new System.Drawing.Point(10, 190);

                notNewHighScore.Size = new System.Drawing.Size(500, 57);
                notNewHighScore.Location = new System.Drawing.Point(10, 250);

                enterNameLabel.Size = new System.Drawing.Size(500, 57);
                enterNameLabel.Location = new System.Drawing.Point(10, 350);

                nameTextBox.Size = new System.Drawing.Size(500, 57);
                nameTextBox.Location = new System.Drawing.Point(10, 400);

                HS0_end.Size = new System.Drawing.Size(300, 57);
                HS0_end.Location = new System.Drawing.Point(500, 150);

                HS1_end.Size = new System.Drawing.Size(300, 57);
                HS1_end.Location = new System.Drawing.Point(500, 210);

                HS2_end.Size = new System.Drawing.Size(300, 57);
                HS2_end.Location = new System.Drawing.Point(500, 270);

                HS3_end.Size = new System.Drawing.Size(300, 57);
                HS3_end.Location = new System.Drawing.Point(500, 330);

                HS4_end.Size = new System.Drawing.Size(300, 57);
                HS4_end.Location = new System.Drawing.Point(500, 400);

                mainMenuEndScreen.Size = new System.Drawing.Size(500, 57);
                mainMenuEndScreen.Location = new System.Drawing.Point(150, 475);


            }
            else if (comboBox1.Text == "1280x720")
            {
                windowWidth = 1280;
                windowHeight = 720;

                TitleLabel.Size = new System.Drawing.Size(1280, 144);
                TitleLabel.Location = new System.Drawing.Point(0, 0);

                PlayButton.Location = new System.Drawing.Point(32, 168);
                PlayButton.Size = new System.Drawing.Size(512, 144);

                SettingsButton.Location = new System.Drawing.Point(32, 336);
                SettingsButton.Size = new System.Drawing.Size(512, 144);

                QuitButton.Location = new System.Drawing.Point(32, 516);
                QuitButton.Size = new System.Drawing.Size(512, 144);

                HSLabel.Location = new System.Drawing.Point(576, 144);
                HSLabel.Size = new System.Drawing.Size(704, 84);

                HS0.Location = new System.Drawing.Point(576, 240);
                HS0.Size = new System.Drawing.Size(704, 67);

                HS1.Location = new System.Drawing.Point(576, 324);
                HS1.Size = new System.Drawing.Size(704, 67);

                HS2.Location = new System.Drawing.Point(576, 420);
                HS2.Size = new System.Drawing.Size(704, 67);

                HS3.Location = new System.Drawing.Point(576, 516);
                HS3.Size = new System.Drawing.Size(704, 67);

                HS4.Location = new System.Drawing.Point(576, 600);
                HS4.Size = new System.Drawing.Size(704, 67);

                //question page
                QuestionText.Location = new System.Drawing.Point(0, 0);
                QuestionText.Size = new System.Drawing.Size(1280, 216);

                pictureBox1.Location = new System.Drawing.Point(0, 216);
                pictureBox1.Size = new System.Drawing.Size(1280, 300);

                Answer0.Location = new System.Drawing.Point(0, 412);
                Answer0.Size = new System.Drawing.Size(640, 68);

                Answer1.Location = new System.Drawing.Point(640, 412);
                Answer1.Size = new System.Drawing.Size(640, 68);

                Answer2.Location = new System.Drawing.Point(0, 505);
                Answer2.Size = new System.Drawing.Size(640, 68);

                Answer3.Location = new System.Drawing.Point(640, 505);
                Answer3.Size = new System.Drawing.Size(640, 68);

                questionCount.Location = new System.Drawing.Point(0, 624);
                questionCount.Size = new System.Drawing.Size(160, 68);

                scoreAmount.Location = new System.Drawing.Point(1120, 624);
                scoreAmount.Size = new System.Drawing.Size(160, 68);

                nextQuestion.Size = new System.Drawing.Size(480, 68);
                nextQuestion.Location = new System.Drawing.Point(400, 603);

                //Settings Menu
                settingsLabel.Size = new System.Drawing.Size(1280, 144);
                settingsLabel.Location = new System.Drawing.Point(0, 0);

                comboBox1.Size = new System.Drawing.Size(120, 57);
                comboBox1.Location = new System.Drawing.Point(640, 214);

                resLabel.Size = new System.Drawing.Size(240, 68);
                resLabel.Location = new System.Drawing.Point(400, 192);

                DebugM.Size = new System.Drawing.Size(480, 68);
                DebugM.Location = new System.Drawing.Point(608, 252);

                soundEffects.Size = new System.Drawing.Size(480, 68);
                soundEffects.Location = new System.Drawing.Point(608, 300);

                Narration.Size = new System.Drawing.Size(480, 68);
                Narration.Location = new System.Drawing.Point(608, 348);

                mainMenuSettings.Size = new System.Drawing.Size(800, 68);
                mainMenuSettings.Location = new System.Drawing.Point(240, 570);

                //end screen
                highScoreEnd.Size = new System.Drawing.Size(1280, 168);
                highScoreEnd.Location = new System.Drawing.Point(0, 0);

                youScored.Size = new System.Drawing.Size(800, 68);
                youScored.Location = new System.Drawing.Point(16, 228);

                notNewHighScore.Size = new System.Drawing.Size(800, 68);
                notNewHighScore.Location = new System.Drawing.Point(16, 300);

                enterNameLabel.Size = new System.Drawing.Size(800, 68);
                enterNameLabel.Location = new System.Drawing.Point(16, 420);

                nameTextBox.Size = new System.Drawing.Size(800, 68);
                nameTextBox.Location = new System.Drawing.Point(16, 480);

                HS0_end.Size = new System.Drawing.Size(480, 68);
                HS0_end.Location = new System.Drawing.Point(800, 180);

                HS1_end.Size = new System.Drawing.Size(480, 68);
                HS1_end.Location = new System.Drawing.Point(800, 252);

                HS2_end.Size = new System.Drawing.Size(480, 68);
                HS2_end.Location = new System.Drawing.Point(800, 324);

                HS3_end.Size = new System.Drawing.Size(480, 68);
                HS3_end.Location = new System.Drawing.Point(800, 396);

                HS4_end.Size = new System.Drawing.Size(480, 68);
                HS4_end.Location = new System.Drawing.Point(800, 480);

                mainMenuEndScreen.Size = new System.Drawing.Size(800, 68);
                mainMenuEndScreen.Location = new System.Drawing.Point(240, 570);

            }
            else if (comboBox1.Text == "1920x1080")
            {
                windowWidth = 1920;
                windowHeight = 1080;


                TitleLabel.Size = new System.Drawing.Size(1920, 216);
                TitleLabel.Location = new System.Drawing.Point(0, 0);

                PlayButton.Location = new System.Drawing.Point(48, 252);
                PlayButton.Size = new System.Drawing.Size(768, 216);

                SettingsButton.Location = new System.Drawing.Point(48, 504);
                SettingsButton.Size = new System.Drawing.Size(768, 216);

                QuitButton.Location = new System.Drawing.Point(48, 774);
                QuitButton.Size = new System.Drawing.Size(768, 216);

                HSLabel.Location = new System.Drawing.Point(864, 216);
                HSLabel.Size = new System.Drawing.Size(1056, 126);

                HS0.Location = new System.Drawing.Point(864, 360);
                HS0.Size = new System.Drawing.Size(1056, 100);

                HS1.Location = new System.Drawing.Point(864, 486);
                HS1.Size = new System.Drawing.Size(1056, 100);

                HS2.Location = new System.Drawing.Point(864, 630);
                HS2.Size = new System.Drawing.Size(1056, 100);

                HS3.Location = new System.Drawing.Point(864, 774);
                HS3.Size = new System.Drawing.Size(1056, 100);

                HS4.Location = new System.Drawing.Point(864, 900);
                HS4.Size = new System.Drawing.Size(1056, 100);

                //question page
                QuestionText.Location = new System.Drawing.Point(0, 0);
                QuestionText.Size = new System.Drawing.Size(1920, 324);

                pictureBox1.Location = new System.Drawing.Point(0, 324);
                pictureBox1.Size = new System.Drawing.Size(1920, 450);

                Answer0.Location = new System.Drawing.Point(0, 618);
                Answer0.Size = new System.Drawing.Size(960, 102);

                Answer1.Location = new System.Drawing.Point(960, 618);
                Answer1.Size = new System.Drawing.Size(960, 102);

                Answer2.Location = new System.Drawing.Point(0, 757);
                Answer2.Size = new System.Drawing.Size(960, 102);

                Answer3.Location = new System.Drawing.Point(960, 757);
                Answer3.Size = new System.Drawing.Size(960, 102);

                questionCount.Location = new System.Drawing.Point(0, 936);
                questionCount.Size = new System.Drawing.Size(240, 102);

                scoreAmount.Location = new System.Drawing.Point(1680, 936);
                scoreAmount.Size = new System.Drawing.Size(240, 102);

                nextQuestion.Size = new System.Drawing.Size(720, 102);
                nextQuestion.Location = new System.Drawing.Point(600, 904);

                //Settings Menu
                settingsLabel.Size = new System.Drawing.Size(1920, 120);
                settingsLabel.Location = new System.Drawing.Point(0, 0);

                comboBox1.Size = new System.Drawing.Size(150, 57);
                comboBox1.Location = new System.Drawing.Point(960, 320);

                resLabel.Size = new System.Drawing.Size(360, 56);
                resLabel.Location = new System.Drawing.Point(600, 308);

                DebugM.Size = new System.Drawing.Size(720, 102);
                DebugM.Location = new System.Drawing.Point(912, 398);

                soundEffects.Size = new System.Drawing.Size(720, 102);
                soundEffects.Location = new System.Drawing.Point(912, 470);

                Narration.Size = new System.Drawing.Size(720, 102);
                Narration.Location = new System.Drawing.Point(912, 542);

                mainMenuSettings.Size = new System.Drawing.Size(1200, 102);
                mainMenuSettings.Location = new System.Drawing.Point(360, 855);

                //End screen
                highScoreEnd.Size = new System.Drawing.Size(1920, 252);
                highScoreEnd.Location = new System.Drawing.Point(0, 0);

                youScored.Size = new System.Drawing.Size(1200, 102);
                youScored.Location = new System.Drawing.Point(24, 342);

                notNewHighScore.Size = new System.Drawing.Size(1200, 102);
                notNewHighScore.Location = new System.Drawing.Point(24, 450);

                enterNameLabel.Size = new System.Drawing.Size(1200, 102);
                enterNameLabel.Location = new System.Drawing.Point(24, 630);

                nameTextBox.Size = new System.Drawing.Size(1200, 102);
                nameTextBox.Location = new System.Drawing.Point(24, 720);

                HS0_end.Size = new System.Drawing.Size(720, 102);
                HS0_end.Location = new System.Drawing.Point(1200, 270);

                HS1_end.Size = new System.Drawing.Size(720, 102);
                HS1_end.Location = new System.Drawing.Point(1200, 378);

                HS2_end.Size = new System.Drawing.Size(720, 102);
                HS2_end.Location = new System.Drawing.Point(1200, 486);

                HS3_end.Size = new System.Drawing.Size(720, 102);
                HS3_end.Location = new System.Drawing.Point(1200, 594);

                HS4_end.Size = new System.Drawing.Size(720, 102);
                HS4_end.Location = new System.Drawing.Point(1200, 702);

                mainMenuEndScreen.Size = new System.Drawing.Size(1200, 102);
                mainMenuEndScreen.Location = new System.Drawing.Point(360, 855);

            }
            else
            {
                windowWidth = 800;
                windowHeight = 600;


                TitleLabel.Size = new System.Drawing.Size(800, 120);
                TitleLabel.Location = new System.Drawing.Point(0, 0);

                PlayButton.Location = new System.Drawing.Point(20, 140);
                PlayButton.Size = new System.Drawing.Size(320, 120);

                SettingsButton.Location = new System.Drawing.Point(20, 280);
                SettingsButton.Size = new System.Drawing.Size(320, 120);

                QuitButton.Location = new System.Drawing.Point(20, 430);
                QuitButton.Size = new System.Drawing.Size(320, 120);

                HSLabel.Location = new System.Drawing.Point(360, 120);
                HSLabel.Size = new System.Drawing.Size(440, 70);

                HS0.Location = new System.Drawing.Point(360, 200);
                HS0.Size = new System.Drawing.Size(440, 56);

                HS1.Location = new System.Drawing.Point(360, 270);
                HS1.Size = new System.Drawing.Size(440, 56);

                HS2.Location = new System.Drawing.Point(360, 350);
                HS2.Size = new System.Drawing.Size(440, 56);

                HS3.Location = new System.Drawing.Point(360, 430);
                HS3.Size = new System.Drawing.Size(440, 56);

                HS4.Location = new System.Drawing.Point(360, 500);
                HS4.Size = new System.Drawing.Size(440, 56);


                //question page
                QuestionText.Location = new System.Drawing.Point(0, 0);
                QuestionText.Size = new System.Drawing.Size(800, 180);

                pictureBox1.Location = new System.Drawing.Point(0, 180);
                pictureBox1.Size = new System.Drawing.Size(800, 250);

                Answer0.Location = new System.Drawing.Point(0, 344);
                Answer0.Size = new System.Drawing.Size(400, 57);

                Answer1.Location = new System.Drawing.Point(400, 344);
                Answer1.Size = new System.Drawing.Size(400, 57);

                Answer2.Location = new System.Drawing.Point(0, 421);
                Answer2.Size = new System.Drawing.Size(400, 57);

                Answer3.Location = new System.Drawing.Point(400, 421);
                Answer3.Size = new System.Drawing.Size(400, 57);

                questionCount.Location = new System.Drawing.Point(0, 520);
                questionCount.Size = new System.Drawing.Size(100, 57);

                scoreAmount.Location = new System.Drawing.Point(700, 520);
                scoreAmount.Size = new System.Drawing.Size(100, 57);

                nextQuestion.Size = new System.Drawing.Size(300, 57);
                nextQuestion.Location = new System.Drawing.Point(250, 503);

                //Settings Menu
                settingsLabel.Size = new System.Drawing.Size(800, 120);
                settingsLabel.Location = new System.Drawing.Point(0, 0);

                comboBox1.Size = new System.Drawing.Size(120, 57);
                comboBox1.Location = new System.Drawing.Point(400, 178);

                resLabel.Size = new System.Drawing.Size(150, 57);
                resLabel.Location = new System.Drawing.Point(250, 160);

                DebugM.Size = new System.Drawing.Size(300, 57);
                DebugM.Location = new System.Drawing.Point(380, 210);

                soundEffects.Size = new System.Drawing.Size(300, 57);
                soundEffects.Location = new System.Drawing.Point(380, 250);

                Narration.Size = new System.Drawing.Size(300, 57);
                Narration.Location = new System.Drawing.Point(380, 290);

                mainMenuSettings.Size = new System.Drawing.Size(500, 57);
                mainMenuSettings.Location = new System.Drawing.Point(150, 475);

                //End screen
                highScoreEnd.Size = new System.Drawing.Size(800, 140);
                highScoreEnd.Location = new System.Drawing.Point(0, 0);

                youScored.Size = new System.Drawing.Size(500, 57);
                youScored.Location = new System.Drawing.Point(10, 190);

                notNewHighScore.Size = new System.Drawing.Size(500, 57);
                notNewHighScore.Location = new System.Drawing.Point(10, 250);

                enterNameLabel.Size = new System.Drawing.Size(500, 57);
                enterNameLabel.Location = new System.Drawing.Point(10, 350);

                nameTextBox.Size = new System.Drawing.Size(500, 57);
                nameTextBox.Location = new System.Drawing.Point(10, 400);

                HS0_end.Size = new System.Drawing.Size(300, 57);
                HS0_end.Location = new System.Drawing.Point(500, 150);

                HS1_end.Size = new System.Drawing.Size(300, 57);
                HS1_end.Location = new System.Drawing.Point(500, 210);

                HS2_end.Size = new System.Drawing.Size(300, 57);
                HS2_end.Location = new System.Drawing.Point(500, 270);

                HS3_end.Size = new System.Drawing.Size(300, 57);
                HS3_end.Location = new System.Drawing.Point(500, 330);

                HS4_end.Size = new System.Drawing.Size(300, 57);
                HS4_end.Location = new System.Drawing.Point(500, 400);

                mainMenuEndScreen.Size = new System.Drawing.Size(500, 57);
                mainMenuEndScreen.Location = new System.Drawing.Point(150, 475);


            }
            this.Size = new System.Drawing.Size(windowWidth, windowHeight);
            settingsGroupBox.Size= new System.Drawing.Size(windowWidth, windowHeight);
            //settingsGroupBox.Location = new System.Drawing.Point(0, windowHeight); //move the group box to the visble window

            MainMenuGroupBox.Size = new System.Drawing.Size(windowWidth, windowHeight);
            MainMenuGroupBox.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window
            MainMenuGroupBox.Hide();

            questionForm.Size = new System.Drawing.Size(windowWidth, windowHeight);
            questionForm.Location = new System.Drawing.Point(windowWidth, 0); //move the group box to the visble window
            questionForm.Hide();

            endScreen.Size = new System.Drawing.Size(windowWidth, windowHeight);
            endScreen.Location = new System.Drawing.Point(windowWidth, windowHeight); //move the group box to the visble window
            endScreen.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
