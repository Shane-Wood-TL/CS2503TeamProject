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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.HSLabel = new System.Windows.Forms.Label();
            this.HS0 = new System.Windows.Forms.Label();
            this.HS1 = new System.Windows.Forms.Label();
            this.HS3 = new System.Windows.Forms.Label();
            this.HS2 = new System.Windows.Forms.Label();
            this.HS4 = new System.Windows.Forms.Label();
            this.MainMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.questionForm = new System.Windows.Forms.GroupBox();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.scoreAmount = new System.Windows.Forms.Label();
            this.questionCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Answer1 = new System.Windows.Forms.Button();
            this.Answer0 = new System.Windows.Forms.Button();
            this.QuestionText = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.Narration = new System.Windows.Forms.CheckBox();
            this.soundEffects = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DebugM = new System.Windows.Forms.CheckBox();
            this.mainMenuSettings = new System.Windows.Forms.Button();
            this.endScreen = new System.Windows.Forms.GroupBox();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.notNewHighScore = new System.Windows.Forms.Label();
            this.youScored = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.HS3_end = new System.Windows.Forms.Label();
            this.HS4_end = new System.Windows.Forms.Label();
            this.highScoreEnd = new System.Windows.Forms.Label();
            this.mainMenuEndScreen = new System.Windows.Forms.Button();
            this.HS0_end = new System.Windows.Forms.Label();
            this.HS2_end = new System.Windows.Forms.Label();
            this.HS1_end = new System.Windows.Forms.Label();
            this.MainMenuGroupBox.SuspendLayout();
            this.questionForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            this.endScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Sans Serif Collection", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1000, 148);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Quiz Game";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayButton
            // 
            this.PlayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(12, 204);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(2);
            this.PlayButton.MinimumSize = new System.Drawing.Size(300, 102);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(350, 120);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play!";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.playbuttonClick);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(12, 404);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.SettingsButton.MinimumSize = new System.Drawing.Size(300, 102);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(350, 120);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(12, 600);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuitButton.MinimumSize = new System.Drawing.Size(300, 102);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(350, 120);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.quitProgram);
            // 
            // HSLabel
            // 
            this.HSLabel.Font = new System.Drawing.Font("Sans Serif Collection", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSLabel.Location = new System.Drawing.Point(566, 204);
            this.HSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HSLabel.Name = "HSLabel";
            this.HSLabel.Size = new System.Drawing.Size(392, 88);
            this.HSLabel.TabIndex = 4;
            this.HSLabel.Text = "High Scores";
            this.HSLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS0
            // 
            this.HS0.Font = new System.Drawing.Font("Sans Serif Collection", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS0.Location = new System.Drawing.Point(536, 291);
            this.HS0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS0.Name = "HS0";
            this.HS0.Size = new System.Drawing.Size(422, 78);
            this.HS0.TabIndex = 5;
            this.HS0.Text = "Score1";
            this.HS0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS1
            // 
            this.HS1.Font = new System.Drawing.Font("Sans Serif Collection", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS1.Location = new System.Drawing.Point(536, 369);
            this.HS1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS1.Name = "HS1";
            this.HS1.Size = new System.Drawing.Size(422, 78);
            this.HS1.TabIndex = 6;
            this.HS1.Text = "Score2";
            this.HS1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS3
            // 
            this.HS3.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS3.Location = new System.Drawing.Point(536, 524);
            this.HS3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS3.Name = "HS3";
            this.HS3.Size = new System.Drawing.Size(422, 78);
            this.HS3.TabIndex = 8;
            this.HS3.Text = "Score4";
            this.HS3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS2
            // 
            this.HS2.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS2.Location = new System.Drawing.Point(536, 446);
            this.HS2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS2.Name = "HS2";
            this.HS2.Size = new System.Drawing.Size(422, 78);
            this.HS2.TabIndex = 7;
            this.HS2.Text = "Score3";
            this.HS2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS4
            // 
            this.HS4.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS4.Location = new System.Drawing.Point(536, 600);
            this.HS4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS4.Name = "HS4";
            this.HS4.Size = new System.Drawing.Size(422, 78);
            this.HS4.TabIndex = 9;
            this.HS4.Text = "Score5";
            this.HS4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenuGroupBox
            // 
            this.MainMenuGroupBox.Controls.Add(this.PlayButton);
            this.MainMenuGroupBox.Controls.Add(this.HS4);
            this.MainMenuGroupBox.Controls.Add(this.SettingsButton);
            this.MainMenuGroupBox.Controls.Add(this.HS3);
            this.MainMenuGroupBox.Controls.Add(this.QuitButton);
            this.MainMenuGroupBox.Controls.Add(this.HS2);
            this.MainMenuGroupBox.Controls.Add(this.TitleLabel);
            this.MainMenuGroupBox.Controls.Add(this.HS1);
            this.MainMenuGroupBox.Controls.Add(this.HSLabel);
            this.MainMenuGroupBox.Controls.Add(this.HS0);
            this.MainMenuGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MainMenuGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.MainMenuGroupBox.Name = "MainMenuGroupBox";
            this.MainMenuGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.MainMenuGroupBox.Size = new System.Drawing.Size(1000, 750);
            this.MainMenuGroupBox.TabIndex = 10;
            this.MainMenuGroupBox.TabStop = false;
            this.MainMenuGroupBox.Enter += new System.EventHandler(this.MainMenuGroupBox_Enter);
            // 
            // questionForm
            // 
            this.questionForm.Controls.Add(this.nextQuestion);
            this.questionForm.Controls.Add(this.scoreAmount);
            this.questionForm.Controls.Add(this.questionCount);
            this.questionForm.Controls.Add(this.pictureBox1);
            this.questionForm.Controls.Add(this.Answer3);
            this.questionForm.Controls.Add(this.Answer2);
            this.questionForm.Controls.Add(this.Answer1);
            this.questionForm.Controls.Add(this.Answer0);
            this.questionForm.Controls.Add(this.QuestionText);
            this.questionForm.Location = new System.Drawing.Point(1042, 14);
            this.questionForm.Margin = new System.Windows.Forms.Padding(2);
            this.questionForm.Name = "questionForm";
            this.questionForm.Padding = new System.Windows.Forms.Padding(2);
            this.questionForm.Size = new System.Drawing.Size(800, 600);
            this.questionForm.TabIndex = 11;
            this.questionForm.TabStop = false;
            // 
            // nextQuestion
            // 
            this.nextQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestion.Location = new System.Drawing.Point(334, 526);
            this.nextQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(138, 69);
            this.nextQuestion.TabIndex = 14;
            this.nextQuestion.Text = "Next";
            this.nextQuestion.UseVisualStyleBackColor = false;
            this.nextQuestion.Click += new System.EventHandler(this.nextQ);
            // 
            // scoreAmount
            // 
            this.scoreAmount.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreAmount.Location = new System.Drawing.Point(661, 552);
            this.scoreAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreAmount.Name = "scoreAmount";
            this.scoreAmount.Size = new System.Drawing.Size(134, 46);
            this.scoreAmount.TabIndex = 13;
            this.scoreAmount.Text = "Score";
            this.scoreAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // questionCount
            // 
            this.questionCount.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionCount.Location = new System.Drawing.Point(11, 551);
            this.questionCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionCount.Name = "questionCount";
            this.questionCount.Size = new System.Drawing.Size(105, 46);
            this.questionCount.TabIndex = 12;
            this.questionCount.Text = "1/N";
            this.questionCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(78, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 182);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Answer3
            // 
            this.Answer3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Answer3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer3.Location = new System.Drawing.Point(435, 402);
            this.Answer3.Margin = new System.Windows.Forms.Padding(2);
            this.Answer3.MinimumSize = new System.Drawing.Size(300, 102);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(350, 120);
            this.Answer3.TabIndex = 9;
            this.Answer3.Text = "D";
            this.Answer3.UseVisualStyleBackColor = false;
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // Answer2
            // 
            this.Answer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Answer2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2.Location = new System.Drawing.Point(21, 402);
            this.Answer2.Margin = new System.Windows.Forms.Padding(2);
            this.Answer2.MinimumSize = new System.Drawing.Size(300, 102);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(350, 120);
            this.Answer2.TabIndex = 8;
            this.Answer2.Text = "C";
            this.Answer2.UseVisualStyleBackColor = false;
            this.Answer2.Click += new System.EventHandler(this.Answer2_Click);
            // 
            // Answer1
            // 
            this.Answer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Answer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1.Location = new System.Drawing.Point(435, 281);
            this.Answer1.Margin = new System.Windows.Forms.Padding(2);
            this.Answer1.MinimumSize = new System.Drawing.Size(300, 102);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(350, 120);
            this.Answer1.TabIndex = 7;
            this.Answer1.Text = "B";
            this.Answer1.UseVisualStyleBackColor = false;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // Answer0
            // 
            this.Answer0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Answer0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer0.Location = new System.Drawing.Point(21, 278);
            this.Answer0.Margin = new System.Windows.Forms.Padding(2);
            this.Answer0.MinimumSize = new System.Drawing.Size(300, 102);
            this.Answer0.Name = "Answer0";
            this.Answer0.Size = new System.Drawing.Size(350, 120);
            this.Answer0.TabIndex = 6;
            this.Answer0.Text = "A";
            this.Answer0.UseVisualStyleBackColor = false;
            this.Answer0.Click += new System.EventHandler(this.Answer0_Click);
            // 
            // QuestionText
            // 
            this.QuestionText.Font = new System.Drawing.Font("Sans Serif Collection", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionText.Location = new System.Drawing.Point(0, 16);
            this.QuestionText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(795, 88);
            this.QuestionText.TabIndex = 5;
            this.QuestionText.Text = "QuestionText?\r\n";
            this.QuestionText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.settingsLabel);
            this.settingsGroupBox.Controls.Add(this.resLabel);
            this.settingsGroupBox.Controls.Add(this.Narration);
            this.settingsGroupBox.Controls.Add(this.soundEffects);
            this.settingsGroupBox.Controls.Add(this.comboBox1);
            this.settingsGroupBox.Controls.Add(this.DebugM);
            this.settingsGroupBox.Controls.Add(this.mainMenuSettings);
            this.settingsGroupBox.Location = new System.Drawing.Point(212, 771);
            this.settingsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.settingsGroupBox.Size = new System.Drawing.Size(800, 600);
            this.settingsGroupBox.TabIndex = 12;
            this.settingsGroupBox.TabStop = false;
            // 
            // settingsLabel
            // 
            this.settingsLabel.Font = new System.Drawing.Font("Sans Serif Collection", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(64, 19);
            this.settingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(668, 148);
            this.settingsLabel.TabIndex = 19;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resLabel
            // 
            this.resLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.resLabel.Location = new System.Drawing.Point(218, 180);
            this.resLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(204, 41);
            this.resLabel.TabIndex = 10;
            this.resLabel.Text = "Resolution";
            this.resLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Narration
            // 
            this.Narration.AutoSize = true;
            this.Narration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Narration.Location = new System.Drawing.Point(198, 322);
            this.Narration.Margin = new System.Windows.Forms.Padding(2);
            this.Narration.Name = "Narration";
            this.Narration.Size = new System.Drawing.Size(179, 43);
            this.Narration.TabIndex = 18;
            this.Narration.Text = "Narration";
            this.Narration.UseVisualStyleBackColor = true;
            // 
            // soundEffects
            // 
            this.soundEffects.AutoSize = true;
            this.soundEffects.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundEffects.Location = new System.Drawing.Point(198, 275);
            this.soundEffects.Margin = new System.Windows.Forms.Padding(2);
            this.soundEffects.Name = "soundEffects";
            this.soundEffects.Size = new System.Drawing.Size(250, 43);
            this.soundEffects.TabIndex = 17;
            this.soundEffects.Text = "Sound Effects";
            this.soundEffects.UseVisualStyleBackColor = true;
            this.soundEffects.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "800x600",
            "1280x720",
            "1920x1080"});
            this.comboBox1.Location = new System.Drawing.Point(64, 188);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "800x600";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DebugM
            // 
            this.DebugM.AutoSize = true;
            this.DebugM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugM.Location = new System.Drawing.Point(198, 228);
            this.DebugM.Margin = new System.Windows.Forms.Padding(2);
            this.DebugM.Name = "DebugM";
            this.DebugM.Size = new System.Drawing.Size(299, 43);
            this.DebugM.TabIndex = 15;
            this.DebugM.Text = "Debugging Mode";
            this.DebugM.UseVisualStyleBackColor = true;
            this.DebugM.CheckedChanged += new System.EventHandler(this.DebugM_CheckedChanged);
            // 
            // mainMenuSettings
            // 
            this.mainMenuSettings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainMenuSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuSettings.Location = new System.Drawing.Point(35, 429);
            this.mainMenuSettings.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenuSettings.MinimumSize = new System.Drawing.Size(300, 102);
            this.mainMenuSettings.Name = "mainMenuSettings";
            this.mainMenuSettings.Size = new System.Drawing.Size(451, 120);
            this.mainMenuSettings.TabIndex = 14;
            this.mainMenuSettings.Text = "Main Menu";
            this.mainMenuSettings.UseVisualStyleBackColor = false;
            this.mainMenuSettings.Click += new System.EventHandler(this.settingsFromMain);
            // 
            // endScreen
            // 
            this.endScreen.Controls.Add(this.enterNameLabel);
            this.endScreen.Controls.Add(this.notNewHighScore);
            this.endScreen.Controls.Add(this.youScored);
            this.endScreen.Controls.Add(this.nameTextBox);
            this.endScreen.Controls.Add(this.HS3_end);
            this.endScreen.Controls.Add(this.HS4_end);
            this.endScreen.Controls.Add(this.highScoreEnd);
            this.endScreen.Controls.Add(this.mainMenuEndScreen);
            this.endScreen.Controls.Add(this.HS0_end);
            this.endScreen.Controls.Add(this.HS2_end);
            this.endScreen.Controls.Add(this.HS1_end);
            this.endScreen.Location = new System.Drawing.Point(1094, 682);
            this.endScreen.Margin = new System.Windows.Forms.Padding(2);
            this.endScreen.Name = "endScreen";
            this.endScreen.Padding = new System.Windows.Forms.Padding(2);
            this.endScreen.Size = new System.Drawing.Size(800, 600);
            this.endScreen.TabIndex = 13;
            this.endScreen.TabStop = false;
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLabel.Location = new System.Drawing.Point(44, 264);
            this.enterNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(439, 46);
            this.enterNameLabel.TabIndex = 19;
            this.enterNameLabel.Text = "Enter Name:";
            this.enterNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notNewHighScore
            // 
            this.notNewHighScore.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notNewHighScore.Location = new System.Drawing.Point(44, 209);
            this.notNewHighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notNewHighScore.Name = "notNewHighScore";
            this.notNewHighScore.Size = new System.Drawing.Size(439, 46);
            this.notNewHighScore.TabIndex = 18;
            this.notNewHighScore.Text = "Try Again Next Time";
            this.notNewHighScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // youScored
            // 
            this.youScored.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youScored.Location = new System.Drawing.Point(145, 134);
            this.youScored.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.youScored.Name = "youScored";
            this.youScored.Size = new System.Drawing.Size(260, 46);
            this.youScored.TabIndex = 17;
            this.youScored.Text = "You Scored: 0";
            this.youScored.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(54, 322);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(400, 41);
            this.nameTextBox.TabIndex = 16;
            // 
            // HS3_end
            // 
            this.HS3_end.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS3_end.Location = new System.Drawing.Point(461, 269);
            this.HS3_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS3_end.Name = "HS3_end";
            this.HS3_end.Size = new System.Drawing.Size(334, 54);
            this.HS3_end.TabIndex = 13;
            this.HS3_end.Text = "Score4";
            this.HS3_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS4_end
            // 
            this.HS4_end.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS4_end.Location = new System.Drawing.Point(461, 328);
            this.HS4_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS4_end.Name = "HS4_end";
            this.HS4_end.Size = new System.Drawing.Size(334, 39);
            this.HS4_end.TabIndex = 14;
            this.HS4_end.Text = "Score5";
            this.HS4_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highScoreEnd
            // 
            this.highScoreEnd.Font = new System.Drawing.Font("Sans Serif Collection", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreEnd.Location = new System.Drawing.Point(214, 30);
            this.highScoreEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highScoreEnd.Name = "highScoreEnd";
            this.highScoreEnd.Size = new System.Drawing.Size(415, 88);
            this.highScoreEnd.TabIndex = 15;
            this.highScoreEnd.Text = "High Scores:";
            this.highScoreEnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.highScoreEnd.Click += new System.EventHandler(this.label6_Click);
            // 
            // mainMenuEndScreen
            // 
            this.mainMenuEndScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainMenuEndScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainMenuEndScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuEndScreen.Location = new System.Drawing.Point(178, 401);
            this.mainMenuEndScreen.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenuEndScreen.MinimumSize = new System.Drawing.Size(300, 102);
            this.mainMenuEndScreen.Name = "mainMenuEndScreen";
            this.mainMenuEndScreen.Size = new System.Drawing.Size(451, 120);
            this.mainMenuEndScreen.TabIndex = 13;
            this.mainMenuEndScreen.Text = "Main Menu";
            this.mainMenuEndScreen.UseVisualStyleBackColor = false;
            this.mainMenuEndScreen.Click += new System.EventHandler(this.returnToMainMenuEnd);
            // 
            // HS0_end
            // 
            this.HS0_end.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS0_end.Location = new System.Drawing.Point(471, 118);
            this.HS0_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS0_end.Name = "HS0_end";
            this.HS0_end.Size = new System.Drawing.Size(329, 46);
            this.HS0_end.TabIndex = 10;
            this.HS0_end.Text = "Score1";
            this.HS0_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS2_end
            // 
            this.HS2_end.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS2_end.Location = new System.Drawing.Point(461, 229);
            this.HS2_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS2_end.Name = "HS2_end";
            this.HS2_end.Size = new System.Drawing.Size(324, 54);
            this.HS2_end.TabIndex = 12;
            this.HS2_end.Text = "Score3";
            this.HS2_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS1_end
            // 
            this.HS1_end.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS1_end.Location = new System.Drawing.Point(471, 186);
            this.HS1_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS1_end.Name = "HS1_end";
            this.HS1_end.Size = new System.Drawing.Size(324, 42);
            this.HS1_end.TabIndex = 11;
            this.HS1_end.Text = "Score2";
            this.HS1_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(2108, 1218);
            this.Controls.Add(this.endScreen);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.questionForm);
            this.Controls.Add(this.MainMenuGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(799, 598);
            this.Name = "Form1";
            this.Text = "Quiz Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenuGroupBox.ResumeLayout(false);
            this.questionForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.endScreen.ResumeLayout(false);
            this.endScreen.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}

