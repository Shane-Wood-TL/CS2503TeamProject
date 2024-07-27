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
using System.Media;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.IO.Ports;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        
        private QuestionManager questionManager;
        private HighScoreManager highScoreManager;
        private Question currentQuestion;

        //current resolution
        private int windowHeight = 600; 
        private int windowWidth = 800;
        //sound effects option
        bool playSoundEffects = true;
        //debugging mode option
        bool debuggingMode = false;
        //narration variable
        bool narrationStatus = false;

        //current game score
        int score = 0;
        //current question index
        private int atQuestion = 0;

        public Form1()
        {
            InitializeComponent();
            string filePath2 = "highScores.txt"; //file name for high scores
            highScoreManager = new HighScoreManager(filePath2); //create high score manager
            questionManager = new QuestionManager(); //create question manager 
            LoadQuestionsFromDefaultFile(); //load questions
            DisplayHighScores(); //display scores on main menu

        }

        private void LoadQuestionsFromDefaultFile()
        {
            string filePath = "questions.txt"; // The path to the questions file
            questionManager.LoadQuestionsFromFile(filePath); //load the questions

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea; //get the active resolution of the display (minus taskbar)
            this.Size = new System.Drawing.Size(windowWidth, windowHeight); ; //set the inital
            //window size to be 65% of the active resolution
            this.Location = new System.Drawing.Point(20, 20); //open the window at position 20,20
            setScenes(true, false, false, false); //only show main menu


            settingsGroupBox.Size = new System.Drawing.Size(windowWidth, windowHeight);
            settingsGroupBox.Location = new System.Drawing.Point(0, windowHeight); //move the group box to the visble window

            MainMenuGroupBox.Size = new System.Drawing.Size(windowWidth, windowHeight);
            MainMenuGroupBox.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window

            questionForm.Size = new System.Drawing.Size(windowWidth, windowHeight);
            questionForm.Location = new System.Drawing.Point(windowWidth, 0); //move the group box to the visble window

            endScreen.Size = new System.Drawing.Size(windowWidth, windowHeight);
            endScreen.Location = new System.Drawing.Point(windowWidth, windowHeight); //move the group box to the visble window


            setRes800x600(); //start with 800x600 resolution

        }

        private void playbuttonClick(object sender, EventArgs e) //main menu, play button 
        {
            score = 0;
            scoreAmount.Text = "Score: "+score.ToString(); //display new score
            atQuestion = 0;
            questionManager.CurrentQuestionIndex = 0;
            if (debuggingMode == false)
            {
                questionForm.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window
                setScenes(false, false, true, false); //only show question form
            }
            else
            {
                questionForm.Location = new System.Drawing.Point(windowWidth, 0); //move the group box to the visble window
                setScenes(true, true, true, true); //show all
            }
            LoadNextQuestion(); //load first question
        }

        private void LoadNextQuestion()
        {
            currentQuestion = questionManager.GetNextQuestion();
            atQuestion++; //increase current question number
            questionCount.Text = atQuestion.ToString() + "/" + questionManager.Questions.Count.ToString();
            
            nextQuestion.Visible = false; //hide next question button until a answer is selected
            Answer0.Enabled = true;
            Answer1.Enabled = true;
            Answer2.Enabled = true;
            Answer3.Enabled = true; //show all buttons
            if (currentQuestion != null)
            {
                if (narrationStatus)
                {
                    Debug.WriteLine(currentQuestion.narrationLocation);
                    SoundPlayer simpleSound = new SoundPlayer(@currentQuestion.narrationLocation);
                    simpleSound.Play();
                }

                // Update UI with the current question details
                QuestionText.Text = currentQuestion.QuestionText;
                if (currentQuestion.Answers[0] != "none")
                {
                    Answer0.Visible = true;
                    Answer0.Text = currentQuestion.Answers[0];
                }
                else
                {
                    Answer0.Visible = false;
                }

                if (currentQuestion.Answers[1] != "none")
                {
                    Answer1.Visible = true;
                    Answer1.Text = currentQuestion.Answers[1];
                }
                else
                {
                    Answer1.Visible = false;
                }

                if (currentQuestion.Answers[2] != "none")
                {
                    Answer2.Visible = true;
                    Answer2.Text = currentQuestion.Answers[2];
                }
                else
                {
                    Answer2.Visible = false;
                }

                if (currentQuestion.Answers[3] != "none")
                {
                    Answer3.Visible = true;
                    Answer3.Text = currentQuestion.Answers[3];
                }
                else
                {
                    Answer3.Visible = false;
                }
                if (currentQuestion.PictureLocation == "none")
                {
                    pictureBox1.Visible = false; //hide if no picture is given
                }
                else
                {
                    pictureBox1.Visible = true; //show if picture
                    pictureBox1.ImageLocation = currentQuestion.PictureLocation; //get the image location from the question
                }
            }
            else // Handle the case where there are no more questions
            {
                
                if (!debuggingMode)
                {
                    setScenes(false, false, false, true); //show end screen
                    youScored.Text = "You Scored: " + score.ToString() + "/" + questionManager.Questions.Count.ToString(); //write score
                    endScreen.Location = new System.Drawing.Point(0, 0); //move end screen to visible
                    Application.DoEvents(); // Force UI to update before playing sounds
                }

                string[] lowestScore = HS4.Text.Split(':'); //get the lowest score
                int.TryParse(lowestScore[1].Trim(), out int lowestScoreV); //get string back to a int

                if (narrationStatus)
                {
                    SoundPlayer simpleSound1 = null;
                    if (score == 0)
                    {
                        simpleSound1 = new SoundPlayer(@"Narration/0score.wav");
                    }
                    else if (score == 1)
                    {
                        simpleSound1 = new SoundPlayer(@"Narration/1score.wav");
                    }
                    else if (score == 2)
                    {
                        simpleSound1 = new SoundPlayer(@"Narration/2score.wav");
                    }
                    else if (score == 3)
                    {
                        simpleSound1 = new SoundPlayer(@"Narration/3score.wav");
                    }
                    else if (score == 4)
                    {
                        simpleSound1 = new SoundPlayer(@"Narration/4score.wav");
                    }

                    if (simpleSound1 != null)
                    {
                        simpleSound1.PlaySync();
                    }
                }

                if (score >= lowestScoreV)
                {
                    if (narrationStatus)
                    {
                        SoundPlayer simpleSound2 = new SoundPlayer(@"Narration/scorePlaced.wav");
                        simpleSound2.PlaySync();

                        SoundPlayer simpleSound3 = new SoundPlayer(@"Narration/returnToMainMenu.wav");
                        simpleSound3.PlaySync();
                    }

                }
                else
                {
                    if (narrationStatus)
                    {
                        SoundPlayer simpleSound2 = new SoundPlayer(@"Narration/scoreNotPlaced.wav");
                        simpleSound2.PlaySync();

                        SoundPlayer simpleSound3 = new SoundPlayer(@"Narration/returnToMainMenu.wav");
                        simpleSound3.PlaySync();
                    }
                }
            }
        }

        private void quitProgram(object sender, EventArgs e) //main menu, quit button
        {
            this.Close(); //quit the program
        }


        private void returnToMainMenuEnd(object sender, EventArgs e) //mainMenuEndScreen
        {
            if (debuggingMode == false)
            {
                setScenes(true, false, false, false); //only show main menu

            }
            string name = nameTextBox.Text; //get name enter text box
            if (!string.IsNullOrEmpty(name))
            {
                highScoreManager.WriteHighScore(name, score); //write the score and name to the file
                Debug.WriteLine("saved");
            }
            else
            {
                Debug.WriteLine("no name found"); //do not write if no name is found
            }
            DisplayHighScores(); //update the scores
            nameTextBox.Text = "";

            if (narrationStatus)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Narration/titleAudio.wav");
                simpleSound.Play();
            }
        }

        private void nextQ(object sender, EventArgs e) //next button
        {
            LoadNextQuestion();
        }

        private void settingsFromMain(object sender, EventArgs e) //settings page main menu button
        {
            if (debuggingMode == false)
            {
                setScenes(true,false,false,false); //only show main menu
            }
            if (narrationStatus)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Narration/titleAudio.wav");
                simpleSound.Play();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e) //main menu settings button
        {

            if (debuggingMode == false)
            {
                settingsGroupBox.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window
                setScenes(false, true, false, false); //only show settings screen
            }
            else
            {
                settingsGroupBox.Location = new System.Drawing.Point(0, windowHeight); //move the group box to the visble window
            }
            if (narrationStatus)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Narration/settingsAudio.wav");
                simpleSound.Play();
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


        private void DebugM_CheckedChanged(object sender, EventArgs e) //enable debugging mode
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
                this.Size = new System.Drawing.Size(2 * windowWidth, 2 * windowHeight); //make the window large enough to show all groups
                settingsGroupBox.Location = new System.Drawing.Point(0, windowHeight); //move the group box back to original location
                questionForm.Location = new System.Drawing.Point(windowWidth, 0); //move the group box back to original location
                endScreen.Location = new System.Drawing.Point(windowWidth, windowHeight); //move the group box back to original location

                setScenes(true, true, true, true); //have all things be visible in debug mode
            }
        }

        private void CheckAnswer(int answerIndex)
        {
            bool isCorrect = currentQuestion.CheckAnswer(answerIndex);
            if (isCorrect)
            {
                score++;//increase current score if correct
                QuestionText.Text = "Correct!";
                nextQuestion.Visible = true; //allow the person to go to the next question
                Application.DoEvents(); // Force UI to update before playing sounds
                scoreAmount.Text = "Score: " + score.ToString(); //display new score
                if (playSoundEffects)
                {  //play correct sound effect
                    SoundPlayer simpleSound = new SoundPlayer(@"Sounds/Correct.wav");
                    simpleSound.PlaySync(); 
                }
                if (narrationStatus)
                {
                    SoundPlayer simpleSound1 = new SoundPlayer(@"Narration/correctNextQ.wav");
                    simpleSound1.PlaySync();
                }
            }
            else
            {
                QuestionText.Text = "Incorrect";
                nextQuestion.Visible = true; //allow the person to go to the next question
                Application.DoEvents(); // Force UI to update before playing sounds
                if (playSoundEffects)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"Sounds/Wrong.wav"); //play wrong sound effect
                    simpleSound.PlaySync(); 
                }
                if (narrationStatus)
                {
                    SoundPlayer simpleSound1 = new SoundPlayer(@"Narration/incorrectNextQ.wav");
                    simpleSound1.PlaySync();
                }
            }
            //disable all other button inputs
            Answer0.Enabled = false;
            Answer1.Enabled = false;
            Answer2.Enabled = false;
            Answer3.Enabled = false; 
            nextQuestion.Visible = true; //allow the person to go to the next question
            string[] lowestScore = HS4.Text.Split(':'); //get the lowest score
            int.TryParse(lowestScore[1].Trim(), out int lowestScoreV); //get string back to a int

            if (score >= lowestScoreV) //if current score is higher than the lowest then they can enter their name
            {
                notNewHighScore.Visible = false;
                enterNameLabel.Visible = true;
                nameTextBox.Visible = true;
                
            }
            else //score is too low to save
            {
                notNewHighScore.Visible = true;
                enterNameLabel.Visible = false;
                nameTextBox.Visible = false;

                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //800x600
            //1280x720
            //1920x1080
            if (comboBox1.Text == "800x600")
            {
                setRes800x600();
            }
            else if (comboBox1.Text == "1280x720")
            {
                setRes1280x720();
            }
            else if (comboBox1.Text == "1920x1080")
            {
                setRest1920x1080();
            }
            else
            {
                setRes800x600();
            }


            this.Size = new System.Drawing.Size(windowWidth, windowHeight); //update window size
            settingsGroupBox.Size = new System.Drawing.Size(windowWidth, windowHeight); //resize all group boxes, and move them

            MainMenuGroupBox.Size = new System.Drawing.Size(windowWidth, windowHeight);
            MainMenuGroupBox.Location = new System.Drawing.Point(0, 0); //move the group box to the visble window

            questionForm.Size = new System.Drawing.Size(windowWidth, windowHeight);
            questionForm.Location = new System.Drawing.Point(windowWidth, 0); //move the group box to the visble window

            endScreen.Size = new System.Drawing.Size(windowWidth, windowHeight);
            endScreen.Location = new System.Drawing.Point(windowWidth, windowHeight); //move the group box to the visble window

            setScenes(false, true, false, true); //only show settings menu
        } //code to change resolutions

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (soundEffects.Checked)
            {
                playSoundEffects = true;
            }
            else
            {
                playSoundEffects = false;
            }
        } //check box for sound effects

        private void setRes800x600()
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
            QuestionText.Size = new System.Drawing.Size(800, 60);

            pictureBox1.Location = new System.Drawing.Point(150, 80);
            pictureBox1.Size = new System.Drawing.Size(500, 250);

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

            scoreAmount.Location = new System.Drawing.Point(600, 520);
            scoreAmount.Size = new System.Drawing.Size(200, 57);

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

            enterNameLabel.Size = new System.Drawing.Size(500, 40);
            enterNameLabel.Location = new System.Drawing.Point(10, 350);

            nameTextBox.MaximumSize = new System.Drawing.Size(500, 57);
            nameTextBox.MinimumSize = new System.Drawing.Size(500, 57);
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
        } //update res to 800x600


        private void setRes1280x720()
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
            QuestionText.Size = new System.Drawing.Size(1280, 72);

            pictureBox1.Location = new System.Drawing.Point(400, 96);
            pictureBox1.Size = new System.Drawing.Size(800, 300);

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

            scoreAmount.Location = new System.Drawing.Point(1060, 624);
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
            DebugM.Location = new System.Drawing.Point(608, 272);

            soundEffects.Size = new System.Drawing.Size(480, 68);
            soundEffects.Location = new System.Drawing.Point(608, 320);

            Narration.Size = new System.Drawing.Size(480, 68);
            Narration.Location = new System.Drawing.Point(608, 368);

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

            nameTextBox.MaximumSize = new System.Drawing.Size(800, 57);
            nameTextBox.MinimumSize = new System.Drawing.Size(800, 57);
            nameTextBox.Location = new System.Drawing.Point(16, 500);

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
        } //update res to 1280x720


        private void setRest1920x1080()
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
            QuestionText.Size = new System.Drawing.Size(1920, 108);

            pictureBox1.Location = new System.Drawing.Point(720, 144);
            pictureBox1.Size = new System.Drawing.Size(1200, 450);

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

            scoreAmount.Location = new System.Drawing.Point(1600, 936);
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

            nameTextBox.MaximumSize = new System.Drawing.Size(1200, 90);
            nameTextBox.MinimumSize = new System.Drawing.Size(1200, 90);
            nameTextBox.Location = new System.Drawing.Point(24, 740);

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
        } //update res to 1920x1080


        private void setScenes(bool mainMenuVisible, bool settingsVisible, bool questionVisible, bool endScreenVisible)
        {
            if (mainMenuVisible)
            {
                MainMenuGroupBox.Visible = true;
            }
            else
            {
                MainMenuGroupBox.Visible = false;
            }

            if (settingsVisible)
            {
                settingsGroupBox.Visible = true;
            }
            else
            {
                settingsGroupBox.Visible = false;
            }

            if (questionVisible)
            {
                questionForm.Visible = true;
            }
            else
            {
                questionForm.Visible = false;
            }

            if (endScreenVisible)
            {
                endScreen.Visible = true;
            }
            else
            {
                endScreen.Visible = false;
            }
        } //pick which windows are visible


        private void DisplayHighScores() //assigns read values to text labels based on index
        {
            var highScores = highScoreManager.ReadHighScores();
            for (int i = 0; i < highScores.Count && i < 5; i++)
            {
                var highScore = highScores[i];
                if (i == 0)
                {
                    if (highScore.Score != -1)
                    {
                        HS0.Visible = true;
                        HS0_end.Visible = true;
                        HS0.Text = $"{highScore.Name}: {highScore.Score}";
                        HS0_end.Text = $"{highScore.Name}: {highScore.Score}";
                    }
                    else
                    {
                        HS0.Visible = false;
                        HS0_end.Visible = false;
                    }
                }
                if (i == 1) {
                    if (highScore.Score != -1)
                    {
                        HS1.Visible = true;
                        HS1_end.Visible = true;
                        HS1.Text = $"{highScore.Name}: {highScore.Score}";
                        HS1_end.Text = $"{highScore.Name}: {highScore.Score}";
                    }
                    else
                    {
                        HS1.Visible = false;
                        HS1_end.Visible = false;
                    }
                }
                if (i == 2) {
                    if (highScore.Score != -1)
                    {
                        HS2.Visible = true;
                        HS2_end.Visible = true;
                        HS2.Text = $"{highScore.Name}: {highScore.Score}";
                        HS2_end.Text = $"{highScore.Name}: {highScore.Score}";
                    }
                    else
                    {
                        HS2.Visible = false;
                        HS2_end.Visible = false;
                    }
                }
                if (i == 3) {
                    if (highScore.Score != -1)
                    {
                        HS3.Visible = true;
                        HS3_end.Visible = true;
                        HS3.Text = $"{highScore.Name}: {highScore.Score}";
                        HS3_end.Text = $"{highScore.Name}: {highScore.Score}";
                    }
                    else
                    {
                        HS3.Visible = false;
                        HS3_end.Visible = false;
                    }
                }
                if (i == 4) {
                    HS4.Text = $"{highScore.Name}: {highScore.Score}";//need this to determine if score is a new higher one
                    HS4_end.Text = $"{highScore.Name}: {highScore.Score}";
                    if (highScore.Score != -1)
                    {
                        HS4.Visible = true;
                        HS4_end.Visible = true;
                        
                    }
                    else
                    {
                        HS4.Visible = false;
                        HS4_end.Visible = false;
                    }
                }
            }
        }

        private void Narration_CheckedChanged(object sender, EventArgs e)
        {
            if (Narration.Checked) {
                narrationStatus = true;
            }
            else
            {
                narrationStatus = false;
            }
        }
    }
}
