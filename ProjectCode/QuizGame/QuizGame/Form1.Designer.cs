namespace QuizGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TitleLabel = new System.Windows.Forms.Label();
            PlayButton = new System.Windows.Forms.Button();
            SettingsButton = new System.Windows.Forms.Button();
            QuitButton = new System.Windows.Forms.Button();
            HSLabel = new System.Windows.Forms.Label();
            HS0 = new System.Windows.Forms.Label();
            HS1 = new System.Windows.Forms.Label();
            HS3 = new System.Windows.Forms.Label();
            HS2 = new System.Windows.Forms.Label();
            HS4 = new System.Windows.Forms.Label();
            MainMenuGroupBox = new System.Windows.Forms.GroupBox();
            questionForm = new System.Windows.Forms.GroupBox();
            nextQuestion = new System.Windows.Forms.Button();
            scoreAmount = new System.Windows.Forms.Label();
            questionCount = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Answer3 = new System.Windows.Forms.Button();
            Answer2 = new System.Windows.Forms.Button();
            Answer1 = new System.Windows.Forms.Button();
            Answer0 = new System.Windows.Forms.Button();
            QuestionText = new System.Windows.Forms.Label();
            settingsGroupBox = new System.Windows.Forms.GroupBox();
            settingsLabel = new System.Windows.Forms.Label();
            resLabel = new System.Windows.Forms.Label();
            Narration = new System.Windows.Forms.CheckBox();
            soundEffects = new System.Windows.Forms.CheckBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            DebugM = new System.Windows.Forms.CheckBox();
            mainMenuSettings = new System.Windows.Forms.Button();
            endScreen = new System.Windows.Forms.GroupBox();
            enterNameLabel = new System.Windows.Forms.Label();
            notNewHighScore = new System.Windows.Forms.Label();
            youScored = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            HS3_end = new System.Windows.Forms.Label();
            HS4_end = new System.Windows.Forms.Label();
            highScoreEnd = new System.Windows.Forms.Label();
            mainMenuEndScreen = new System.Windows.Forms.Button();
            HS0_end = new System.Windows.Forms.Label();
            HS2_end = new System.Windows.Forms.Label();
            HS1_end = new System.Windows.Forms.Label();
            MainMenuGroupBox.SuspendLayout();
            questionForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            settingsGroupBox.SuspendLayout();
            endScreen.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            TitleLabel.Location = new System.Drawing.Point(0, 0);
            TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(1000, 148);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Quiz Game";
            TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayButton
            // 
            PlayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            PlayButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            PlayButton.Font = new System.Drawing.Font("Arial", 48F);
            PlayButton.Location = new System.Drawing.Point(12, 204);
            PlayButton.Margin = new System.Windows.Forms.Padding(2);
            PlayButton.MinimumSize = new System.Drawing.Size(300, 102);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new System.Drawing.Size(350, 120);
            PlayButton.TabIndex = 1;
            PlayButton.Text = "Play!";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += playbuttonClick;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            SettingsButton.Font = new System.Drawing.Font("Arial", 48F);
            SettingsButton.Location = new System.Drawing.Point(12, 404);
            SettingsButton.Margin = new System.Windows.Forms.Padding(2);
            SettingsButton.MinimumSize = new System.Drawing.Size(300, 102);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new System.Drawing.Size(350, 120);
            SettingsButton.TabIndex = 2;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            QuitButton.Font = new System.Drawing.Font("Arial", 48F);
            QuitButton.Location = new System.Drawing.Point(12, 600);
            QuitButton.Margin = new System.Windows.Forms.Padding(2);
            QuitButton.MinimumSize = new System.Drawing.Size(300, 102);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new System.Drawing.Size(350, 120);
            QuitButton.TabIndex = 3;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += quitProgram;
            // 
            // HSLabel
            // 
            HSLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            HSLabel.Location = new System.Drawing.Point(566, 204);
            HSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HSLabel.Name = "HSLabel";
            HSLabel.Size = new System.Drawing.Size(392, 88);
            HSLabel.TabIndex = 4;
            HSLabel.Text = "High Scores";
            HSLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS0
            // 
            HS0.Font = new System.Drawing.Font("Arial", 36F);
            HS0.Location = new System.Drawing.Point(536, 291);
            HS0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS0.Name = "HS0";
            HS0.Size = new System.Drawing.Size(422, 78);
            HS0.TabIndex = 5;
            HS0.Text = "Score1";
            HS0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS1
            // 
            HS1.Font = new System.Drawing.Font("Arial", 36F);
            HS1.Location = new System.Drawing.Point(536, 369);
            HS1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS1.Name = "HS1";
            HS1.Size = new System.Drawing.Size(422, 78);
            HS1.TabIndex = 6;
            HS1.Text = "Score2";
            HS1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS3
            // 
            HS3.Font = new System.Drawing.Font("Arial", 36F);
            HS3.Location = new System.Drawing.Point(536, 524);
            HS3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS3.Name = "HS3";
            HS3.Size = new System.Drawing.Size(422, 78);
            HS3.TabIndex = 8;
            HS3.Text = "Score4";
            HS3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS2
            // 
            HS2.Font = new System.Drawing.Font("Arial", 36F);
            HS2.Location = new System.Drawing.Point(536, 446);
            HS2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS2.Name = "HS2";
            HS2.Size = new System.Drawing.Size(422, 78);
            HS2.TabIndex = 7;
            HS2.Text = "Score3";
            HS2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS4
            // 
            HS4.Font = new System.Drawing.Font("Arial", 36F);
            HS4.Location = new System.Drawing.Point(536, 600);
            HS4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS4.Name = "HS4";
            HS4.Size = new System.Drawing.Size(422, 78);
            HS4.TabIndex = 9;
            HS4.Text = "Score5";
            HS4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenuGroupBox
            // 
            MainMenuGroupBox.Controls.Add(PlayButton);
            MainMenuGroupBox.Controls.Add(HS4);
            MainMenuGroupBox.Controls.Add(SettingsButton);
            MainMenuGroupBox.Controls.Add(HS3);
            MainMenuGroupBox.Controls.Add(QuitButton);
            MainMenuGroupBox.Controls.Add(HS2);
            MainMenuGroupBox.Controls.Add(TitleLabel);
            MainMenuGroupBox.Controls.Add(HS1);
            MainMenuGroupBox.Controls.Add(HSLabel);
            MainMenuGroupBox.Controls.Add(HS0);
            MainMenuGroupBox.Location = new System.Drawing.Point(0, 0);
            MainMenuGroupBox.Margin = new System.Windows.Forms.Padding(2);
            MainMenuGroupBox.Name = "MainMenuGroupBox";
            MainMenuGroupBox.Padding = new System.Windows.Forms.Padding(2);
            MainMenuGroupBox.Size = new System.Drawing.Size(1000, 750);
            MainMenuGroupBox.TabIndex = 10;
            MainMenuGroupBox.TabStop = false;
            // 
            // questionForm
            // 
            questionForm.Controls.Add(nextQuestion);
            questionForm.Controls.Add(scoreAmount);
            questionForm.Controls.Add(questionCount);
            questionForm.Controls.Add(pictureBox1);
            questionForm.Controls.Add(Answer3);
            questionForm.Controls.Add(Answer2);
            questionForm.Controls.Add(Answer1);
            questionForm.Controls.Add(Answer0);
            questionForm.Controls.Add(QuestionText);
            questionForm.Location = new System.Drawing.Point(1042, 14);
            questionForm.Margin = new System.Windows.Forms.Padding(2);
            questionForm.Name = "questionForm";
            questionForm.Padding = new System.Windows.Forms.Padding(2);
            questionForm.Size = new System.Drawing.Size(800, 600);
            questionForm.TabIndex = 11;
            questionForm.TabStop = false;
            // 
            // nextQuestion
            // 
            nextQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            nextQuestion.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nextQuestion.Location = new System.Drawing.Point(334, 526);
            nextQuestion.Margin = new System.Windows.Forms.Padding(2);
            nextQuestion.Name = "nextQuestion";
            nextQuestion.Size = new System.Drawing.Size(138, 69);
            nextQuestion.TabIndex = 14;
            nextQuestion.Text = "Next";
            nextQuestion.UseVisualStyleBackColor = false;
            nextQuestion.Click += nextQ;
            // 
            // scoreAmount
            // 
            scoreAmount.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            scoreAmount.Location = new System.Drawing.Point(661, 552);
            scoreAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            scoreAmount.Name = "scoreAmount";
            scoreAmount.Size = new System.Drawing.Size(134, 46);
            scoreAmount.TabIndex = 13;
            scoreAmount.Text = "Score";
            scoreAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // questionCount
            // 
            questionCount.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            questionCount.Location = new System.Drawing.Point(11, 551);
            questionCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            questionCount.Name = "questionCount";
            questionCount.Size = new System.Drawing.Size(105, 46);
            questionCount.TabIndex = 12;
            questionCount.Text = "1/N";
            questionCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.Location = new System.Drawing.Point(182, 65);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(403, 209);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Answer3
            // 
            Answer3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Answer3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            Answer3.Font = new System.Drawing.Font("Arial", 48F);
            Answer3.Location = new System.Drawing.Point(435, 402);
            Answer3.Margin = new System.Windows.Forms.Padding(2);
            Answer3.MinimumSize = new System.Drawing.Size(300, 102);
            Answer3.Name = "Answer3";
            Answer3.Size = new System.Drawing.Size(350, 120);
            Answer3.TabIndex = 9;
            Answer3.Text = "D";
            Answer3.UseVisualStyleBackColor = false;
            Answer3.Click += Answer3_Click;
            // 
            // Answer2
            // 
            Answer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Answer2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            Answer2.Font = new System.Drawing.Font("Arial", 48F);
            Answer2.Location = new System.Drawing.Point(21, 398);
            Answer2.Margin = new System.Windows.Forms.Padding(2);
            Answer2.MinimumSize = new System.Drawing.Size(300, 102);
            Answer2.Name = "Answer2";
            Answer2.Size = new System.Drawing.Size(350, 120);
            Answer2.TabIndex = 8;
            Answer2.Text = "C";
            Answer2.UseVisualStyleBackColor = false;
            Answer2.Click += Answer2_Click;
            // 
            // Answer1
            // 
            Answer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Answer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            Answer1.Font = new System.Drawing.Font("Arial", 48F);
            Answer1.Location = new System.Drawing.Point(435, 281);
            Answer1.Margin = new System.Windows.Forms.Padding(2);
            Answer1.MinimumSize = new System.Drawing.Size(300, 102);
            Answer1.Name = "Answer1";
            Answer1.Size = new System.Drawing.Size(350, 120);
            Answer1.TabIndex = 7;
            Answer1.Text = "B";
            Answer1.UseVisualStyleBackColor = false;
            Answer1.Click += Answer1_Click;
            // 
            // Answer0
            // 
            Answer0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            Answer0.Font = new System.Drawing.Font("Arial", 48F);
            Answer0.Location = new System.Drawing.Point(21, 278);
            Answer0.Margin = new System.Windows.Forms.Padding(2);
            Answer0.MinimumSize = new System.Drawing.Size(300, 102);
            Answer0.Name = "Answer0";
            Answer0.Size = new System.Drawing.Size(350, 120);
            Answer0.TabIndex = 6;
            Answer0.Text = "A";
            Answer0.UseVisualStyleBackColor = false;
            Answer0.Click += Answer0_Click;
            // 
            // QuestionText
            // 
            QuestionText.BackColor = System.Drawing.Color.DodgerBlue;
            QuestionText.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            QuestionText.Location = new System.Drawing.Point(0, 16);
            QuestionText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            QuestionText.Name = "QuestionText";
            QuestionText.Size = new System.Drawing.Size(795, 66);
            QuestionText.TabIndex = 5;
            QuestionText.Text = "QuestionText?\r\n";
            QuestionText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.Controls.Add(settingsLabel);
            settingsGroupBox.Controls.Add(resLabel);
            settingsGroupBox.Controls.Add(Narration);
            settingsGroupBox.Controls.Add(soundEffects);
            settingsGroupBox.Controls.Add(comboBox1);
            settingsGroupBox.Controls.Add(DebugM);
            settingsGroupBox.Controls.Add(mainMenuSettings);
            settingsGroupBox.Location = new System.Drawing.Point(212, 771);
            settingsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            settingsGroupBox.Size = new System.Drawing.Size(800, 600);
            settingsGroupBox.TabIndex = 12;
            settingsGroupBox.TabStop = false;
            // 
            // settingsLabel
            // 
            settingsLabel.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            settingsLabel.Location = new System.Drawing.Point(64, 19);
            settingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new System.Drawing.Size(668, 148);
            settingsLabel.TabIndex = 19;
            settingsLabel.Text = "Settings";
            settingsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resLabel
            // 
            resLabel.Font = new System.Drawing.Font("Arial", 18F);
            resLabel.Location = new System.Drawing.Point(218, 180);
            resLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            resLabel.Name = "resLabel";
            resLabel.Size = new System.Drawing.Size(204, 41);
            resLabel.TabIndex = 10;
            resLabel.Text = "Resolution";
            resLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Narration
            // 
            Narration.AutoSize = true;
            Narration.Font = new System.Drawing.Font("Arial", 18F);
            Narration.Location = new System.Drawing.Point(198, 322);
            Narration.Margin = new System.Windows.Forms.Padding(2);
            Narration.Name = "Narration";
            Narration.Size = new System.Drawing.Size(159, 39);
            Narration.TabIndex = 18;
            Narration.Text = "Narration";
            Narration.UseVisualStyleBackColor = true;
            Narration.CheckedChanged += Narration_CheckedChanged;
            // 
            // soundEffects
            // 
            soundEffects.AutoSize = true;
            soundEffects.Checked = true;
            soundEffects.CheckState = System.Windows.Forms.CheckState.Checked;
            soundEffects.Font = new System.Drawing.Font("Arial", 18F);
            soundEffects.Location = new System.Drawing.Point(198, 275);
            soundEffects.Margin = new System.Windows.Forms.Padding(2);
            soundEffects.Name = "soundEffects";
            soundEffects.Size = new System.Drawing.Size(221, 39);
            soundEffects.TabIndex = 17;
            soundEffects.Text = "Sound Effects";
            soundEffects.UseVisualStyleBackColor = true;
            soundEffects.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "800x600", "1280x720", "1920x1080" });
            comboBox1.Location = new System.Drawing.Point(64, 188);
            comboBox1.Margin = new System.Windows.Forms.Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(150, 27);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "800x600";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DebugM
            // 
            DebugM.AutoSize = true;
            DebugM.Font = new System.Drawing.Font("Arial", 18F);
            DebugM.Location = new System.Drawing.Point(198, 228);
            DebugM.Margin = new System.Windows.Forms.Padding(2);
            DebugM.Name = "DebugM";
            DebugM.Size = new System.Drawing.Size(266, 39);
            DebugM.TabIndex = 15;
            DebugM.Text = "Debugging Mode";
            DebugM.UseVisualStyleBackColor = true;
            DebugM.CheckedChanged += DebugM_CheckedChanged;
            // 
            // mainMenuSettings
            // 
            mainMenuSettings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            mainMenuSettings.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            mainMenuSettings.Location = new System.Drawing.Point(345, 336);
            mainMenuSettings.Margin = new System.Windows.Forms.Padding(2);
            mainMenuSettings.MinimumSize = new System.Drawing.Size(300, 102);
            mainMenuSettings.Name = "mainMenuSettings";
            mainMenuSettings.Size = new System.Drawing.Size(451, 120);
            mainMenuSettings.TabIndex = 14;
            mainMenuSettings.Text = "Main Menu";
            mainMenuSettings.UseVisualStyleBackColor = false;
            mainMenuSettings.Click += settingsFromMain;
            // 
            // endScreen
            // 
            endScreen.Controls.Add(enterNameLabel);
            endScreen.Controls.Add(notNewHighScore);
            endScreen.Controls.Add(youScored);
            endScreen.Controls.Add(nameTextBox);
            endScreen.Controls.Add(HS3_end);
            endScreen.Controls.Add(HS4_end);
            endScreen.Controls.Add(highScoreEnd);
            endScreen.Controls.Add(mainMenuEndScreen);
            endScreen.Controls.Add(HS0_end);
            endScreen.Controls.Add(HS2_end);
            endScreen.Controls.Add(HS1_end);
            endScreen.Location = new System.Drawing.Point(1094, 682);
            endScreen.Margin = new System.Windows.Forms.Padding(2);
            endScreen.Name = "endScreen";
            endScreen.Padding = new System.Windows.Forms.Padding(2);
            endScreen.Size = new System.Drawing.Size(800, 600);
            endScreen.TabIndex = 13;
            endScreen.TabStop = false;
            // 
            // enterNameLabel
            // 
            enterNameLabel.Font = new System.Drawing.Font("Arial", 18F);
            enterNameLabel.Location = new System.Drawing.Point(44, 264);
            enterNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            enterNameLabel.Name = "enterNameLabel";
            enterNameLabel.Size = new System.Drawing.Size(439, 46);
            enterNameLabel.TabIndex = 19;
            enterNameLabel.Text = "Enter Name:";
            enterNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notNewHighScore
            // 
            notNewHighScore.Font = new System.Drawing.Font("Arial", 18F);
            notNewHighScore.Location = new System.Drawing.Point(44, 209);
            notNewHighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            notNewHighScore.Name = "notNewHighScore";
            notNewHighScore.Size = new System.Drawing.Size(439, 46);
            notNewHighScore.TabIndex = 18;
            notNewHighScore.Text = "Try Again Next Time";
            notNewHighScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // youScored
            // 
            youScored.Font = new System.Drawing.Font("Arial", 18F);
            youScored.Location = new System.Drawing.Point(145, 134);
            youScored.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            youScored.Name = "youScored";
            youScored.Size = new System.Drawing.Size(260, 46);
            youScored.TabIndex = 17;
            youScored.Text = "You Scored: 0";
            youScored.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nameTextBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nameTextBox.Location = new System.Drawing.Point(74, 324);
            nameTextBox.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            nameTextBox.MaximumSize = new System.Drawing.Size(1000, 1000);
            nameTextBox.MaxLength = 8;
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Play";
            nameTextBox.Size = new System.Drawing.Size(381, 66);
            nameTextBox.TabIndex = 16;
            nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nameTextBox.WordWrap = false;
            // 
            // HS3_end
            // 
            HS3_end.Font = new System.Drawing.Font("Arial", 24F);
            HS3_end.Location = new System.Drawing.Point(461, 269);
            HS3_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS3_end.Name = "HS3_end";
            HS3_end.Size = new System.Drawing.Size(334, 54);
            HS3_end.TabIndex = 13;
            HS3_end.Text = "Score4";
            HS3_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS4_end
            // 
            HS4_end.Font = new System.Drawing.Font("Arial", 24F);
            HS4_end.Location = new System.Drawing.Point(461, 328);
            HS4_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS4_end.Name = "HS4_end";
            HS4_end.Size = new System.Drawing.Size(334, 39);
            HS4_end.TabIndex = 14;
            HS4_end.Text = "Score5";
            HS4_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highScoreEnd
            // 
            highScoreEnd.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            highScoreEnd.Location = new System.Drawing.Point(214, 30);
            highScoreEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            highScoreEnd.Name = "highScoreEnd";
            highScoreEnd.Size = new System.Drawing.Size(415, 88);
            highScoreEnd.TabIndex = 15;
            highScoreEnd.Text = "High Scores:";
            highScoreEnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainMenuEndScreen
            // 
            mainMenuEndScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            mainMenuEndScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            mainMenuEndScreen.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            mainMenuEndScreen.Location = new System.Drawing.Point(178, 401);
            mainMenuEndScreen.Margin = new System.Windows.Forms.Padding(2);
            mainMenuEndScreen.MinimumSize = new System.Drawing.Size(300, 102);
            mainMenuEndScreen.Name = "mainMenuEndScreen";
            mainMenuEndScreen.Size = new System.Drawing.Size(451, 120);
            mainMenuEndScreen.TabIndex = 13;
            mainMenuEndScreen.Text = "Main Menu";
            mainMenuEndScreen.UseVisualStyleBackColor = false;
            mainMenuEndScreen.Click += returnToMainMenuEnd;
            // 
            // HS0_end
            // 
            HS0_end.Font = new System.Drawing.Font("Arial", 24F);
            HS0_end.Location = new System.Drawing.Point(471, 118);
            HS0_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS0_end.Name = "HS0_end";
            HS0_end.Size = new System.Drawing.Size(329, 46);
            HS0_end.TabIndex = 10;
            HS0_end.Text = "Score1";
            HS0_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS2_end
            // 
            HS2_end.Font = new System.Drawing.Font("Arial", 24F);
            HS2_end.Location = new System.Drawing.Point(461, 229);
            HS2_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS2_end.Name = "HS2_end";
            HS2_end.Size = new System.Drawing.Size(324, 54);
            HS2_end.TabIndex = 12;
            HS2_end.Text = "Score3";
            HS2_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS1_end
            // 
            HS1_end.Font = new System.Drawing.Font("Arial", 24F);
            HS1_end.Location = new System.Drawing.Point(471, 186);
            HS1_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HS1_end.Name = "HS1_end";
            HS1_end.Size = new System.Drawing.Size(324, 42);
            HS1_end.TabIndex = 11;
            HS1_end.Text = "Score2";
            HS1_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(2108, 1218);
            Controls.Add(endScreen);
            Controls.Add(settingsGroupBox);
            Controls.Add(questionForm);
            Controls.Add(MainMenuGroupBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(799, 598);
            Name = "Form1";
            Text = "Quiz Game";
            Load += Form1_Load;
            MainMenuGroupBox.ResumeLayout(false);
            questionForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            settingsGroupBox.ResumeLayout(false);
            settingsGroupBox.PerformLayout();
            endScreen.ResumeLayout(false);
            endScreen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label HSLabel;
        private System.Windows.Forms.Label HS0;
        private System.Windows.Forms.Label HS1;
        private System.Windows.Forms.Label HS3;
        private System.Windows.Forms.Label HS2;
        private System.Windows.Forms.Label HS4;
        private System.Windows.Forms.GroupBox MainMenuGroupBox;
        private System.Windows.Forms.GroupBox questionForm;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.Button Answer0;
        private System.Windows.Forms.Label questionCount;
        private System.Windows.Forms.Label scoreAmount;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.GroupBox endScreen;
        private System.Windows.Forms.Button mainMenuEndScreen;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button mainMenuSettings;
        private System.Windows.Forms.CheckBox DebugM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox Narration;
        private System.Windows.Forms.CheckBox soundEffects;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label highScoreEnd;
        private System.Windows.Forms.Label HS4_end;
        private System.Windows.Forms.Label HS3_end;
        private System.Windows.Forms.Label HS0_end;
        private System.Windows.Forms.Label HS2_end;
        private System.Windows.Forms.Label HS1_end;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Label notNewHighScore;
        private System.Windows.Forms.Label youScored;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

