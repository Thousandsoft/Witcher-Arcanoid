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
using System.Runtime.InteropServices;
using System.Reflection;

namespace Arcanoid
{
    public partial class GamePlay : Form
    {
        private Microsoft.VisualBasic.PowerPacks.RectangleShape[] vectRectShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape[100];
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string filename);
        public double speedLeft = 8, speedTop = 8;
        public int Points;
        System.Media.SoundPlayer splayer = new System.Media.SoundPlayer();
        System.Media.SoundPlayer dplayer = new System.Media.SoundPlayer();
        public bool paused = false;
        private Rectangle rectPlayer;
        private Rectangle[] vectRectangles = new Rectangle[100];
        private int j = 0;
        public string profileSelected = Choice.playerName;
        public int lives = 3;
        public bool shoot = false;
        public string selectedLevel = Choice.selectedLevel;
        public int rectCount;
        public string levelCount;
        public bool end = false;
        
        




        public GamePlay()
        {

            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            InitializeComponent();
            this.KeyPreview = true;
            Cursor mycursor = new Cursor(Cursor.Current.Handle);
            IntPtr colorcursorhandle = LoadCursorFromFile(@"Resources\newcursor.cur");
            mycursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, mycursor, new object[] { colorcursorhandle });
            this.Cursor = mycursor;
            Cursor.Hide();
            PlayGround1.Focus();
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            Racket.Top = PlayGround1.Bottom - (PlayGround1.Bottom / 15);
            rectPlayer = new Rectangle(Ball.Location.X, Ball.Location.Y, Ball.Width, Ball.Height); 
            StreamReader sw = new StreamReader(@"Profiles\" + profileSelected + ".dat");
            string school = sw.ReadLine();
            if (school == "Змея")
            {
                
                speedLeft = 10; speedTop = 10;
                Ball.Width = 25; Ball.Height = 25;
                Racket.BackColor = Color.Green;
            }
            else if (school == "Грифон")
            {
                speedLeft = 11; speedTop = 11;
                Racket.BackColor = Color.LightSeaGreen;
            }
            else if (school == "Медведь")
            {
                Ball.Width = 55; Ball.Height = 55;
                speedLeft = 6; speedTop = 6;
                Racket.BackColor = Color.SaddleBrown;
                Racket.Width += 14;
            }
            else if (school == "Кот")
            {
                Racket.Width -= 14;
                speedLeft = 10; speedTop = 10;
                Racket.BackColor = Color.Blue;
            }
            Ball.Top = Racket.Top - 40;
            Ball.Left = Racket.Left;
            
          



        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            LevelLoading();
            Config();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);
            if (lives == 0)
            {
                timer.Enabled = false;
                GOPanel.Visible = true;
                Cursor.Show();
                dplayer.SoundLocation = @"Resources\defeat.wav";
                dplayer.Play();
            }

            if (shoot == true)
            {
                rectPlayer.Location = Ball.Location;
                Ball.Left -= Convert.ToInt32(speedLeft);
                Ball.Top -= Convert.ToInt32(speedTop);
                if (Ball.Bottom >= Racket.Top &&
                    Ball.Bottom <= Racket.Bottom &&
                    Ball.Left >= Racket.Left &&
                    Ball.Right <= Racket.Right)
                {

                    speedTop = -speedTop;


                }
                else if (Ball.Bottom >= Racket.Top &&
                    Ball.Bottom <= Racket.Bottom &&
                    Ball.Left == Racket.Left &&
                    Ball.Right == Racket.Right)
                {
                    speedTop = -speedTop;
                    speedLeft = 0;

                }

                if (Ball.Left <= PlayGround1.Left)
                {
                    speedLeft = -speedLeft;
                }

                if (Ball.Right >= PlayGround1.Right)
                {
                    speedLeft = -speedLeft;
                }

                if (Ball.Top <= PlayGround1.Top)
                {
                    speedTop = -speedTop;
                }

                
                if (Ball.Bottom >= PlayGround1.Bottom)
                {   
                    lives -= 1;
                    livesNumber.Text = Convert.ToString(lives);
                    shoot = false;
                    Ball.Top = Racket.Top - 40;
                    Ball.Left = Racket.Left;
                    if (Points >= 10)
                    {
                        Points -= 10;
                        Point.Text = Convert.ToString(Points);
                    }
                   // firstShot = false;
                }



                for (int l = j; l > 0; l--)
                {
                    if (vectRectShape[l - 1].Visible == true && vectRectangles[l - 1].IntersectsWith(rectPlayer))
                    {
                        rectCount -= 1;
                        vectRectShape[l - 1].Visible = false;
                        Points += 1;
                        speedTop = -speedTop;
                        Point.Text = Points.ToString();
                        LabelScore.Text = Points.ToString();

                    }
                }
                
            }
            else
            {
                Ball.Left = Cursor.Position.X - (Ball.Width / 2);
            }
            if (rectCount == 0)
            {
                timer.Enabled = false;
                Cursor.Show();
                GOPanel.Visible = true;
                nextButton.Visible = true;
                GOtext.Text = "Уровень пройден";
                dplayer.SoundLocation = @"Resources\complete.wav";
                dplayer.Play();
                GameOver();
                HighScore();
                
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Arkanoid newForm = new Arkanoid(); 
            newForm.Show();
            
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GamePlay newForm = new GamePlay();
            newForm.Show();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            GOPanel.Visible = false;
            PausePanel.Visible = false;
            timer.Enabled = true;
            Cursor.Hide();
            paused = false;
            
        }

        private void Retry_Click(object sender, EventArgs e)
        {
            this.Close();
            GamePlay newForm = new GamePlay();
            newForm.Show();
        }

        private void menuBut_Click(object sender, EventArgs e)
        {
            this.Close();
            Arkanoid newForm = new Arkanoid();
            newForm.Show();
        }

        private void Ball_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void GamePlay_KeyDown(object sender, KeyEventArgs e)
        {



            if (GOPanel.Visible == false)
            {
                if (e.KeyCode == Keys.Escape && paused == false)
                {
                    paused = true;
                    GOPanel.Visible = true;
                    PausePanel.Visible = true;
                    timer.Enabled = false;
                    Cursor.Show();

                }
                else if (e.KeyCode == Keys.Escape && paused == true)
                {
                    paused = false;
                    GOPanel.Visible = false;
                    PausePanel.Visible = false;
                    timer.Enabled = true;
                    Cursor.Hide();
                }
                if ((e.KeyCode == Keys.Space) && paused == false && shoot == false)
                {

                    shoot = true;
                    
                }
                if (e.KeyCode == Keys.Escape && end == true)
                {
                    this.Close();
                    Arkanoid newForm = new Arkanoid();
                    newForm.Show();
                    Cursor.Show();
                }
            }
        }

        private void PlayGround_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            int i = 0;

            for (int fila = PlayGround1.Height / 30; fila < PlayGround1.Height / 3; fila += PlayGround1.Height / 20) 
            {

                for (double plataforma = (PlayGround1.Width / 100); plataforma < PlayGround1.Width; plataforma += PlayGround1.Width / 9) 
                {

                    int widthRect = Convert.ToInt32(PlayGround1.Width / 15);
                    int predict = Convert.ToInt32(plataforma) + (PlayGround1.Width / 10);

                    if (predict < PlayGround1.Width)
                    {
                        vectRectangles[i] = new Rectangle(Convert.ToInt32(plataforma), 70 + fila, widthRect, 30);
                    }

                    i++;
                }

            }




            Graphics objGraph = e.Graphics;


            Pen p = new Pen(Brushes.Green);
        }
        
        public void LevelLoading()
        {
            
            if (selectedLevel == "Каер Морхен")
            {
                PlayGround1.BackColor = Color.Silver;
                splayer.SoundLocation = @"Resources\Kaer.wav";
                splayer.PlayLooping();
            }
            else if (selectedLevel == "Новиград")
            {
                PlayGround1.BackColor = Color.Peru;
                splayer.SoundLocation = @"Resources\Novigrad.wav";
                splayer.PlayLooping();
            }
            else if (selectedLevel == "Велен")
            {
                PlayGround1.BackColor = Color.DarkOliveGreen;
                splayer.SoundLocation = @"Resources\velen.wav";
                splayer.PlayLooping();
            }
            else if (selectedLevel == "Концовка")
            {
                
                PlayGround1.BackColor = Color.DarkOliveGreen;
                splayer.SoundLocation = @"Resources\velen.wav";
                splayer.PlayLooping();
            }
        }
       

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            if (selectedLevel == "Каер Морхен")
            {
                Choice.selectedLevel = "Новиград";
                this.Close();
                GamePlay newForm = new GamePlay();
                newForm.Show();
                
            }
            else if (selectedLevel == "Новиград")
            {
                Choice.selectedLevel = "Велен";
                this.Close();
                GamePlay newForm = new GamePlay();
                newForm.Show();
            }
            else if (selectedLevel == "Велен")
            {
                Ending();
                Credits();
               
            }
           
        }

        public void GameOver()
        {
            levelCount = File.ReadLines(@"Profiles\" + profileSelected + ".dat").Skip(1).First();
            if (Convert.ToInt32(levelCount) == 0 && selectedLevel == "Каер Морхен")
            {
                levelCount = Convert.ToString(Convert.ToInt32(levelCount) + 1);
                string[] rows = File.ReadAllLines(@"Profiles\" + profileSelected + ".dat");//Открываем

                if (rows.Length >= 1)
                {
                    rows[1] = levelCount;
                }

                File.WriteAllLines(@"Profiles\" + profileSelected + ".dat", rows);//Сохраняем
            }
            else if (Convert.ToInt32(levelCount) == 1 && selectedLevel == "Новиград")
            {
                levelCount = Convert.ToString(Convert.ToInt32(levelCount) + 1);
                string[] rows = File.ReadAllLines(@"Profiles\" + profileSelected + ".dat");//Открываем

                if (rows.Length >= 1)
                {
                    rows[1] = levelCount;
                }

                File.WriteAllLines(@"Profiles\" + profileSelected + ".dat", rows);//Сохраняем
            }
            else if (Convert.ToInt32(levelCount) == 2 && selectedLevel == "Велен")
            {
                levelCount = Convert.ToString(Convert.ToInt32(levelCount) + 1);
                string[] rows = File.ReadAllLines(@"Profiles\" + profileSelected + ".dat");//Открываем

                if (rows.Length >= 1)
                {
                    rows[1] = levelCount;
                }

                File.WriteAllLines(@"Profiles\" + profileSelected + ".dat", rows);//Сохраняем
            }

        }
        public void Ending()
        {
            PlayGround1.BackColor = Color.Black;
            splayer.SoundLocation = @"Resources\credits.wav";
            splayer.Play();
            GOPanel.Visible = false;
            Racket.Visible = false;
            Ball.Visible = false;
            Point.Visible = false;
            Score.Visible = false;
            livesText.Visible = false;
            livesNumber.Visible = false;
            end = true;
            Cursor.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            credits.Top -= 1; 
        }

        public void Credits()
        {
            StreamReader sr = new StreamReader(@"Resources\Credits.txt", Encoding.GetEncoding(1251));
            credits.Text = sr.ReadToEnd();
            GamePlay form = new GamePlay();
            credits.Top = form.Bottom;
            credits.Left = form.Width / 2;
            timer1.Enabled = true;
            credits.Visible = true;
            ArkanoidImg.Top = form.Top;
            ArkanoidImg.Left = form.Left;
            ArkanoidImg.Visible = true;
            

        }
        public void HighScore()
        {
            int score = 0;
            BinaryReader br = new BinaryReader(File.Open(@"Profiles\Records\" + profileSelected + ".bin", FileMode.Open));
            
                score = br.ReadInt32();
                br.Close();
                if (score < Points)
                {
                    score = Points;
                    BestScore.Text = Convert.ToString(Points);
                    BinaryWriter bw = new BinaryWriter(File.Open(@"Profiles\Records\" + profileSelected + ".bin", FileMode.Open));
                    bw.Write(score);
                    bw.Close();
                }
                else
                {
                    BestScore.Text = Convert.ToString(score);
                }
            
            
            
            
            
        }
        public void Config()
        {
            if (selectedLevel == "Каер Морхен")
            {
                for (int row = PlayGround1.Height / 100; row < PlayGround1.Height / 10; row += PlayGround1.Height / 20) 
                {

                    for (double platform = (PlayGround1.Width / 100); platform < PlayGround1.Width; platform += PlayGround1.Width / 9) 
                    {

                        int widthRect = Convert.ToInt32(PlayGround1.Width / 10); 
                        int predictable = Convert.ToInt32(platform) + (PlayGround1.Width / 10); 

                        if (predictable < PlayGround1.Width) 
                        {
                            
                            vectRectShape[j] = new Microsoft.VisualBasic.PowerPacks.RectangleShape(Convert.ToInt32(platform), 100 + row, widthRect, 30);
                            vectRectShape[j].FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
                            vectRectShape[j].FillColor = Color.Orange;
                            vectRectShape[j].BringToFront();


                        }

                        j++;
                    }

                }
                
                this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
                this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
                this.shapeContainer1.Name = "shapeContainer2";
                rectCount = j;
                for (int k = j; k > 0; k--)
                {
                    this.shapeContainer1.Shapes.Add(vectRectShape[k - 1]);  
                }

                this.shapeContainer1.Size = new System.Drawing.Size(663, 329);
                this.shapeContainer1.TabIndex = 13;
                this.shapeContainer1.TabStop = false;

                this.PlayGround1.Controls.Add(this.shapeContainer1);
            }
            else if (selectedLevel == "Новиград")
            {
                for (int row = PlayGround1.Height / 60; row < PlayGround1.Height / 6; row += PlayGround1.Height / 20)
                {

                    for (double platform = (PlayGround1.Width / 100); platform < PlayGround1.Width; platform += PlayGround1.Width / 9) {  

                        int widthRect = Convert.ToInt32(PlayGround1.Width / 12); 
                        int predictable = Convert.ToInt32(platform) + (PlayGround1.Width / 10); 

                        if (predictable < PlayGround1.Width) 
                        {
                            
                            vectRectShape[j] = new Microsoft.VisualBasic.PowerPacks.RectangleShape(Convert.ToInt32(platform), 100 + row, widthRect, 30);
                            vectRectShape[j].FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
                            vectRectShape[j].FillColor = Color.OrangeRed;
                            vectRectShape[j].BringToFront();


                        }

                        j++;
                    }

                }
                // 
                // shapeContainer1
                // 
                this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
                this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
                this.shapeContainer1.Name = "shapeContainer2";
                rectCount = j;
                for (int k = j; k > 0; k--)
                {
                    this.shapeContainer1.Shapes.Add(vectRectShape[k - 1]);   
                }

                this.shapeContainer1.Size = new System.Drawing.Size(663, 329);
                this.shapeContainer1.TabIndex = 13;
                this.shapeContainer1.TabStop = false;

                this.PlayGround1.Controls.Add(this.shapeContainer1);
            }
            else if (selectedLevel == "Велен")
            {
                for (int row = PlayGround1.Height / 40; row < PlayGround1.Height / 4; row += PlayGround1.Height / 20) 
                {

                    for (double platform = (PlayGround1.Width / 100); platform < PlayGround1.Width; platform += PlayGround1.Width / 9) 
                    {

                        int widthRect = Convert.ToInt32(PlayGround1.Width / 15); 
                        int predictable = Convert.ToInt32(platform) + (PlayGround1.Width / 10); 

                        if (predictable < PlayGround1.Width) 
                        {
                            
                            vectRectShape[j] = new Microsoft.VisualBasic.PowerPacks.RectangleShape(Convert.ToInt32(platform), 100 + row, widthRect, 30);
                            vectRectShape[j].FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
                            vectRectShape[j].FillColor = Color.LightBlue;
                            vectRectShape[j].BringToFront();


                        }

                        j++;
                    }

                }
                
                
                 
                this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
                this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
                this.shapeContainer1.Name = "shapeContainer2";
                rectCount = j;
                for (int k = j; k > 0; k--)
                {
                    this.shapeContainer1.Shapes.Add(vectRectShape[k - 1]);   
                }

                this.shapeContainer1.Size = new System.Drawing.Size(663, 329);
                this.shapeContainer1.TabIndex = 13;
                this.shapeContainer1.TabStop = false;

                this.PlayGround1.Controls.Add(this.shapeContainer1);
            }

        }
    }
}
