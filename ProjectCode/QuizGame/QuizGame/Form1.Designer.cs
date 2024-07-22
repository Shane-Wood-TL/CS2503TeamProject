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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.mainMenuSettings = new System.Windows.Forms.Button();
            this.endScreen = new System.Windows.Forms.GroupBox();
            this.mainMenuEndScreen = new System.Windows.Forms.Button();
            this.DebugM = new System.Windows.Forms.CheckBox();
            this.MainMenuGroupBox.SuspendLayout();
            this.questionForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            this.endScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Sans Serif Collection", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(5, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(779, 148);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Quiz Game";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(10, 165);
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
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SettingsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(10, 296);
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
            this.QuitButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(10, 428);
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
            this.HSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HSLabel.Font = new System.Drawing.Font("Sans Serif Collection", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSLabel.Location = new System.Drawing.Point(382, 157);
            this.HSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HSLabel.Name = "HSLabel";
            this.HSLabel.Size = new System.Drawing.Size(393, 88);
            this.HSLabel.TabIndex = 4;
            this.HSLabel.Text = "High Scores";
            this.HSLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS0
            // 
            this.HS0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HS0.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS0.Location = new System.Drawing.Point(367, 237);
            this.HS0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS0.Name = "HS0";
            this.HS0.Size = new System.Drawing.Size(422, 78);
            this.HS0.TabIndex = 5;
            this.HS0.Text = "Score1";
            this.HS0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS1
            // 
            this.HS1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HS1.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS1.Location = new System.Drawing.Point(367, 297);
            this.HS1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS1.Name = "HS1";
            this.HS1.Size = new System.Drawing.Size(422, 78);
            this.HS1.TabIndex = 6;
            this.HS1.Text = "Score2";
            this.HS1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS3
            // 
            this.HS3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HS3.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS3.Location = new System.Drawing.Point(367, 425);
            this.HS3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS3.Name = "HS3";
            this.HS3.Size = new System.Drawing.Size(422, 78);
            this.HS3.TabIndex = 8;
            this.HS3.Text = "Score4";
            this.HS3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS2
            // 
            this.HS2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HS2.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS2.Location = new System.Drawing.Point(367, 356);
            this.HS2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS2.Name = "HS2";
            this.HS2.Size = new System.Drawing.Size(422, 78);
            this.HS2.TabIndex = 7;
            this.HS2.Text = "Score3";
            this.HS2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HS4
            // 
            this.HS4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HS4.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HS4.Location = new System.Drawing.Point(367, 493);
            this.HS4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HS4.Name = "HS4";
            this.HS4.Size = new System.Drawing.Size(422, 78);
            this.HS4.TabIndex = 9;
            this.HS4.Text = "Score5";
            this.HS4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenuGroupBox
            // 
            this.MainMenuGroupBox.Controls.Add(this.groupBox2);
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
            this.MainMenuGroupBox.Location = new System.Drawing.Point(1, -3);
            this.MainMenuGroupBox.Name = "MainMenuGroupBox";
            this.MainMenuGroupBox.Size = new System.Drawing.Size(800, 600);
            this.MainMenuGroupBox.TabIndex = 10;
            this.MainMenuGroupBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(398, 598);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 600);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            this.questionForm.Location = new System.Drawing.Point(780, -5);
            this.questionForm.Name = "questionForm";
            this.questionForm.Size = new System.Drawing.Size(800, 600);
            this.questionForm.TabIndex = 11;
            this.questionForm.TabStop = false;
            // 
            // nextQuestion
            // 
            this.nextQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestion.Location = new System.Drawing.Point(334, 526);
            this.nextQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(137, 69);
            this.nextQuestion.TabIndex = 14;
            this.nextQuestion.Text = "Next";
            this.nextQuestion.UseVisualStyleBackColor = false;
            this.nextQuestion.Click += new System.EventHandler(this.nextQ);
            // 
            // scoreAmount
            // 
            this.scoreAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.questionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pictureBox1.Location = new System.Drawing.Point(78, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 183);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Answer3
            // 
            this.Answer3.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.Answer2.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.Answer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.Answer0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Answer0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.QuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.settingsGroupBox.Controls.Add(this.DebugM);
            this.settingsGroupBox.Controls.Add(this.mainMenuSettings);
            this.settingsGroupBox.Location = new System.Drawing.Point(1, 603);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(800, 600);
            this.settingsGroupBox.TabIndex = 12;
            this.settingsGroupBox.TabStop = false;
            // 
            // mainMenuSettings
            // 
            this.mainMenuSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainMenuSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.endScreen.Controls.Add(this.mainMenuEndScreen);
            this.endScreen.Location = new System.Drawing.Point(807, 616);
            this.endScreen.Name = "endScreen";
            this.endScreen.Size = new System.Drawing.Size(800, 600);
            this.endScreen.TabIndex = 13;
            this.endScreen.TabStop = false;
            // 
            // mainMenuEndScreen
            // 
            this.mainMenuEndScreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainMenuEndScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainMenuEndScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainMenuEndScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuEndScreen.Location = new System.Drawing.Point(41, 416);
            this.mainMenuEndScreen.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenuEndScreen.MinimumSize = new System.Drawing.Size(300, 102);
            this.mainMenuEndScreen.Name = "mainMenuEndScreen";
            this.mainMenuEndScreen.Size = new System.Drawing.Size(451, 120);
            this.mainMenuEndScreen.TabIndex = 13;
            this.mainMenuEndScreen.Text = "Main Menu";
            this.mainMenuEndScreen.UseVisualStyleBackColor = false;
            this.mainMenuEndScreen.Click += new System.EventHandler(this.returnToMainMenuEnd);
            // 
            // DebugM
            // 
            this.DebugM.AutoSize = true;
            this.DebugM.Location = new System.Drawing.Point(173, 131);
            this.DebugM.Name = "DebugM";
            this.DebugM.Size = new System.Drawing.Size(168, 25);
            this.DebugM.TabIndex = 15;
            this.DebugM.Text = "Debugging Mode";
            this.DebugM.UseVisualStyleBackColor = true;
            this.DebugM.CheckedChanged += new System.EventHandler(this.DebugM_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(2107, 1325);
            this.Controls.Add(this.endScreen);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.questionForm);
            this.Controls.Add(this.MainMenuGroupBox);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Quiz Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenuGroupBox.ResumeLayout(false);
            this.questionForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.endScreen.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.GroupBox endScreen;
        private System.Windows.Forms.Button mainMenuEndScreen;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button mainMenuSettings;
        private System.Windows.Forms.CheckBox DebugM;
    }
}

