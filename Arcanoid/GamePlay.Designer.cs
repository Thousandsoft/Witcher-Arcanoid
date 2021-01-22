namespace Arcanoid
{
    partial class GamePlay
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PlayGround1 = new System.Windows.Forms.Panel();
            this.Racket = new System.Windows.Forms.PictureBox();
            this.livesNumber = new System.Windows.Forms.Label();
            this.livesText = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.GOPanel = new System.Windows.Forms.Panel();
            this.PausePanel = new System.Windows.Forms.Panel();
            this.Continue = new System.Windows.Forms.Button();
            this.menuBut = new System.Windows.Forms.Button();
            this.Retry = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.LabelScore = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GOtext = new System.Windows.Forms.Label();
            this.Point = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.PlayGround = new System.Windows.Forms.PictureBox();
            this.credits = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ArkanoidImg = new System.Windows.Forms.PictureBox();
            this.BestScore = new System.Windows.Forms.Label();
            this.PlayGround1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.GOPanel.SuspendLayout();
            this.PausePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArkanoidImg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PlayGround1
            // 
            this.PlayGround1.BackColor = System.Drawing.Color.DarkGray;
            this.PlayGround1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayGround1.Controls.Add(this.PausePanel);
            this.PlayGround1.Controls.Add(this.ArkanoidImg);
            this.PlayGround1.Controls.Add(this.credits);
            this.PlayGround1.Controls.Add(this.Racket);
            this.PlayGround1.Controls.Add(this.livesNumber);
            this.PlayGround1.Controls.Add(this.livesText);
            this.PlayGround1.Controls.Add(this.Ball);
            this.PlayGround1.Controls.Add(this.GOPanel);
            this.PlayGround1.Controls.Add(this.Point);
            this.PlayGround1.Controls.Add(this.Score);
            this.PlayGround1.Controls.Add(this.PlayGround);
            this.PlayGround1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayGround1.Location = new System.Drawing.Point(0, 0);
            this.PlayGround1.Name = "PlayGround1";
            this.PlayGround1.Size = new System.Drawing.Size(1920, 1080);
            this.PlayGround1.TabIndex = 0;
            this.PlayGround1.TabStop = true;
            this.PlayGround1.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayGround_Paint);
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.Color.Maroon;
            this.Racket.Location = new System.Drawing.Point(962, 1033);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(250, 35);
            this.Racket.TabIndex = 0;
            this.Racket.TabStop = false;
            // 
            // livesNumber
            // 
            this.livesNumber.AutoSize = true;
            this.livesNumber.BackColor = System.Drawing.Color.Transparent;
            this.livesNumber.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.livesNumber.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.livesNumber.Location = new System.Drawing.Point(1868, 32);
            this.livesNumber.Name = "livesNumber";
            this.livesNumber.Size = new System.Drawing.Size(65, 74);
            this.livesNumber.TabIndex = 7;
            this.livesNumber.Text = "3";
            // 
            // livesText
            // 
            this.livesText.AutoSize = true;
            this.livesText.BackColor = System.Drawing.Color.Transparent;
            this.livesText.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.livesText.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.livesText.Location = new System.Drawing.Point(1623, 32);
            this.livesText.Name = "livesText";
            this.livesText.Size = new System.Drawing.Size(239, 74);
            this.livesText.TabIndex = 6;
            this.livesText.Text = "Жизни:";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.BackgroundImage = global::Arcanoid.Properties.Resources.ball;
            this.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ball.Location = new System.Drawing.Point(807, 687);
            this.Ball.Margin = new System.Windows.Forms.Padding(4);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(40, 40);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            this.Ball.Click += new System.EventHandler(this.Ball_Click);
            // 
            // GOPanel
            // 
            this.GOPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GOPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GOPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GOPanel.Controls.Add(this.BestScore);
            this.GOPanel.Controls.Add(this.nextButton);
            this.GOPanel.Controls.Add(this.LabelScore);
            this.GOPanel.Controls.Add(this.ExitButton);
            this.GOPanel.Controls.Add(this.AcceptButton);
            this.GOPanel.Controls.Add(this.label3);
            this.GOPanel.Controls.Add(this.label2);
            this.GOPanel.Controls.Add(this.GOtext);
            this.GOPanel.Location = new System.Drawing.Point(763, 383);
            this.GOPanel.Name = "GOPanel";
            this.GOPanel.Size = new System.Drawing.Size(478, 278);
            this.GOPanel.TabIndex = 4;
            this.GOPanel.Visible = false;
            // 
            // PausePanel
            // 
            this.PausePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PausePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PausePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PausePanel.Controls.Add(this.Continue);
            this.PausePanel.Controls.Add(this.menuBut);
            this.PausePanel.Controls.Add(this.Retry);
            this.PausePanel.Controls.Add(this.label7);
            this.PausePanel.Location = new System.Drawing.Point(759, 383);
            this.PausePanel.Name = "PausePanel";
            this.PausePanel.Size = new System.Drawing.Size(478, 278);
            this.PausePanel.TabIndex = 6;
            this.PausePanel.Visible = false;
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.White;
            this.Continue.Cursor = System.Windows.Forms.Cursors.Default;
            this.Continue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Continue.Location = new System.Drawing.Point(173, 82);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(135, 36);
            this.Continue.TabIndex = 5;
            this.Continue.Text = "Продолжить";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // menuBut
            // 
            this.menuBut.BackColor = System.Drawing.Color.White;
            this.menuBut.ForeColor = System.Drawing.Color.Maroon;
            this.menuBut.Location = new System.Drawing.Point(173, 169);
            this.menuBut.Name = "menuBut";
            this.menuBut.Size = new System.Drawing.Size(135, 36);
            this.menuBut.TabIndex = 4;
            this.menuBut.Text = "В меню";
            this.menuBut.UseVisualStyleBackColor = false;
            this.menuBut.Click += new System.EventHandler(this.menuBut_Click);
            // 
            // Retry
            // 
            this.Retry.BackColor = System.Drawing.Color.White;
            this.Retry.ForeColor = System.Drawing.Color.Green;
            this.Retry.Location = new System.Drawing.Point(173, 124);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(135, 36);
            this.Retry.TabIndex = 3;
            this.Retry.Text = "Заново";
            this.Retry.UseVisualStyleBackColor = false;
            this.Retry.Click += new System.EventHandler(this.Retry_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(178, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Пауза";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.White;
            this.nextButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.nextButton.Location = new System.Drawing.Point(168, 209);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(139, 36);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelScore.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LabelScore.Location = new System.Drawing.Point(135, 82);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(32, 36);
            this.LabelScore.TabIndex = 5;
            this.LabelScore.Text = "0";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.ForeColor = System.Drawing.Color.Maroon;
            this.ExitButton.Location = new System.Drawing.Point(323, 209);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(139, 36);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "В меню";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.White;
            this.AcceptButton.ForeColor = System.Drawing.Color.Green;
            this.AcceptButton.Location = new System.Drawing.Point(14, 209);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(135, 36);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "Заново";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(37, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Лучший результат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Счет:";
            // 
            // GOtext
            // 
            this.GOtext.AutoSize = true;
            this.GOtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GOtext.ForeColor = System.Drawing.Color.Maroon;
            this.GOtext.Location = new System.Drawing.Point(104, 18);
            this.GOtext.Name = "GOtext";
            this.GOtext.Size = new System.Drawing.Size(297, 46);
            this.GOtext.TabIndex = 0;
            this.GOtext.Text = "Игра окончена";
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.BackColor = System.Drawing.Color.Transparent;
            this.Point.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Point.Location = new System.Drawing.Point(243, 32);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(65, 74);
            this.Point.TabIndex = 3;
            this.Point.Text = "0";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Score.Location = new System.Drawing.Point(21, 32);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(194, 74);
            this.Score.TabIndex = 2;
            this.Score.Text = "Очки:";
            // 
            // PlayGround
            // 
            this.PlayGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayGround.Image = global::Arcanoid.Properties.Resources.Kaer1;
            this.PlayGround.Location = new System.Drawing.Point(0, 0);
            this.PlayGround.Name = "PlayGround";
            this.PlayGround.Size = new System.Drawing.Size(1920, 1080);
            this.PlayGround.TabIndex = 5;
            this.PlayGround.TabStop = false;
            this.PlayGround.Visible = false;
            this.PlayGround.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.BackColor = System.Drawing.Color.Transparent;
            this.credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.credits.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.credits.Location = new System.Drawing.Point(427, 431);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(130, 46);
            this.credits.TabIndex = 6;
            this.credits.Text = "Пауза";
            this.credits.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ArkanoidImg
            // 
            this.ArkanoidImg.BackColor = System.Drawing.Color.Transparent;
            this.ArkanoidImg.BackgroundImage = global::Arcanoid.Properties.Resources.ef3gsamqp7wse;
            this.ArkanoidImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ArkanoidImg.Location = new System.Drawing.Point(159, 254);
            this.ArkanoidImg.Name = "ArkanoidImg";
            this.ArkanoidImg.Size = new System.Drawing.Size(398, 73);
            this.ArkanoidImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ArkanoidImg.TabIndex = 8;
            this.ArkanoidImg.TabStop = false;
            this.ArkanoidImg.Visible = false;
            // 
            // BestScore
            // 
            this.BestScore.AutoSize = true;
            this.BestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestScore.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BestScore.Location = new System.Drawing.Point(334, 130);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(32, 36);
            this.BestScore.TabIndex = 7;
            this.BestScore.Text = "0";
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.PlayGround1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePlay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePlay_KeyDown);
            this.PlayGround1.ResumeLayout(false);
            this.PlayGround1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.GOPanel.ResumeLayout(false);
            this.GOPanel.PerformLayout();
            this.PausePanel.ResumeLayout(false);
            this.PausePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArkanoidImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayGround1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Panel GOPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GOtext;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Panel PausePanel;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button menuBut;
        private System.Windows.Forms.Button Retry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox PlayGround;
        private System.Windows.Forms.Label livesNumber;
        private System.Windows.Forms.Label livesText;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ArkanoidImg;
        private System.Windows.Forms.Label BestScore;
    }
}