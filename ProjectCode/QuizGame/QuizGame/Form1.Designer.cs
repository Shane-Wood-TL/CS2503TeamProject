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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MainMenuGroupBox.SuspendLayout();
            this.questionForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
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
            this.PlayButton.Click += new System.EventHandler(this.button1_Click);
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
            this.QuitButton.Click += new System.EventHandler(this.button3_Click);
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
            this.HSLabel.Click += new System.EventHandler(this.label2_Click);
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
            this.HS0.Click += new System.EventHandler(this.label3_Click);
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
            this.HS1.Click += new System.EventHandler(this.label4_Click);
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
            this.HS4.Click += new System.EventHandler(this.label7_Click);
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
            this.MainMenuGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // questionForm
            // 
            this.questionForm.Controls.Add(this.label3);
            this.questionForm.Controls.Add(this.label2);
            this.questionForm.Controls.Add(this.button5);
            this.questionForm.Controls.Add(this.pictureBox1);
            this.questionForm.Controls.Add(this.button4);
            this.questionForm.Controls.Add(this.button3);
            this.questionForm.Controls.Add(this.button2);
            this.questionForm.Controls.Add(this.button1);
            this.questionForm.Controls.Add(this.label1);
            this.questionForm.Location = new System.Drawing.Point(780, -5);
            this.questionForm.Name = "questionForm";
            this.questionForm.Size = new System.Drawing.Size(800, 600);
            this.questionForm.TabIndex = 11;
            this.questionForm.TabStop = false;
            this.questionForm.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 88);
            this.label1.TabIndex = 5;
            this.label1.Text = "QuestionText?\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.MinimumSize = new System.Drawing.Size(300, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 120);
            this.button1.TabIndex = 6;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(435, 281);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.MinimumSize = new System.Drawing.Size(300, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 120);
            this.button2.TabIndex = 7;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(21, 402);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.MinimumSize = new System.Drawing.Size(300, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 120);
            this.button3.TabIndex = 8;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(435, 402);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.MinimumSize = new System.Drawing.Size(300, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 120);
            this.button4.TabIndex = 9;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(78, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 183);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(5, 31);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.MinimumSize = new System.Drawing.Size(30, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 551);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "1/N";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 552);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 46);
            this.label3.TabIndex = 13;
            this.label3.Text = "Score";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1582, 1055);
            this.Controls.Add(this.questionForm);
            this.Controls.Add(this.MainMenuGroupBox);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Quiz Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenuGroupBox.ResumeLayout(false);
            this.questionForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

