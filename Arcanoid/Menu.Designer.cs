namespace Arcanoid
{
    partial class Arkanoid
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arkanoid));
            this.StartGame = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelAbout = new System.Windows.Forms.Label();
            this.cdLogo = new System.Windows.Forms.PictureBox();
            this.witcherLogo = new System.Windows.Forms.PictureBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.controlButton = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.Records = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.witcherLogo)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartGame.BackColor = System.Drawing.Color.Transparent;
            this.StartGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartGame.BackgroundImage")));
            this.StartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartGame.Location = new System.Drawing.Point(792, 552);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(267, 61);
            this.StartGame.TabIndex = 0;
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Location = new System.Drawing.Point(792, 720);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(267, 61);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Arcanoid.Properties.Resources.ef3gsamqp7wse;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(23, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.About.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.BackgroundImage = global::Arcanoid.Properties.Resources.button_ob_igre;
            this.About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.About.Location = new System.Drawing.Point(792, 633);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(267, 61);
            this.About.TabIndex = 3;
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(805, 919);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(254, 24);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Официальная игра в Steam";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.BackColor = System.Drawing.Color.Transparent;
            this.labelAbout.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelAbout.Location = new System.Drawing.Point(1187, 614);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(74, 37);
            this.labelAbout.TabIndex = 7;
            this.labelAbout.Text = "Тест";
            this.labelAbout.Visible = false;
            // 
            // cdLogo
            // 
            this.cdLogo.BackgroundImage = global::Arcanoid.Properties.Resources.cdprojekt;
            this.cdLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cdLogo.Location = new System.Drawing.Point(457, 643);
            this.cdLogo.Name = "cdLogo";
            this.cdLogo.Size = new System.Drawing.Size(300, 300);
            this.cdLogo.TabIndex = 8;
            this.cdLogo.TabStop = false;
            this.cdLogo.Visible = false;
            // 
            // witcherLogo
            // 
            this.witcherLogo.BackColor = System.Drawing.Color.Transparent;
            this.witcherLogo.BackgroundImage = global::Arcanoid.Properties.Resources.Лого_Ведьмак;
            this.witcherLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.witcherLogo.Location = new System.Drawing.Point(1065, 633);
            this.witcherLogo.Name = "witcherLogo";
            this.witcherLogo.Size = new System.Drawing.Size(800, 300);
            this.witcherLogo.TabIndex = 9;
            this.witcherLogo.TabStop = false;
            this.witcherLogo.Visible = false;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutButton.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.aboutButton.Image = global::Arcanoid.Properties.Resources.button_ob_igre__1_;
            this.aboutButton.Location = new System.Drawing.Point(0, 0);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(267, 60);
            this.aboutButton.TabIndex = 10;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // controlButton
            // 
            this.controlButton.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.controlButton.Image = global::Arcanoid.Properties.Resources.button_upravlenie;
            this.controlButton.Location = new System.Drawing.Point(0, 66);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(267, 60);
            this.controlButton.TabIndex = 11;
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // panelButton
            // 
            this.panelButton.AutoSize = true;
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.aboutButton);
            this.panelButton.Controls.Add(this.controlButton);
            this.panelButton.Location = new System.Drawing.Point(62, 403);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(297, 132);
            this.panelButton.TabIndex = 12;
            this.panelButton.Visible = false;
            // 
            // Records
            // 
            this.Records.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Records.BackColor = System.Drawing.Color.Transparent;
            this.Records.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Records.BackgroundImage")));
            this.Records.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Records.Location = new System.Drawing.Point(12, 846);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(267, 61);
            this.Records.TabIndex = 2;
            this.Records.UseVisualStyleBackColor = false;
            this.Records.Visible = false;
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // Arkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arcanoid.Properties.Resources.AqFdQUOWW6w9VBx_M0e_M19cuoIk9By0UXtB0GQWWEw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1029);
            this.ControlBox = false;
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.witcherLogo);
            this.Controls.Add(this.cdLogo);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.Records);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arkanoid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Arkanoid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Arkanoid_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.witcherLogo)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.PictureBox cdLogo;
        private System.Windows.Forms.PictureBox witcherLogo;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button Records;
    }
}

