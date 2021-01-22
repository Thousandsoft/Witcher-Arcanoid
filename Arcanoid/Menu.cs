using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;

namespace Arcanoid
{
    public partial class Arkanoid : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string filename);
        public bool about = false;
        


        public Arkanoid()
        {
            this.KeyPreview = true;
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            InitializeComponent();
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Cursor mycursor = new Cursor(Cursor.Current.Handle);
            IntPtr colorcursorhandle = LoadCursorFromFile(@"Resources\newcursor.cur");
            mycursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, mycursor, new object[] { colorcursorhandle });
            this.Cursor = mycursor;
            DirectoryInfo d = new DirectoryInfo(currentPath + @"\Profiles\Records");
            d.Create();
            bool directory = Directory.Exists(@"Resources");
            if (!directory)
            {
                DialogResult result = MessageBox.Show("Папка Resources не найдена!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }

        }

        private void Arkanoid_Load(object sender, EventArgs e)
        {
            player.SoundLocation = @"Resources\MenuSong.wav";
            player.PlayLooping();
           Arkanoid form = new Arkanoid();
           form.Width = Screen.PrimaryScreen.WorkingArea.Width;
           form.Height = Screen.PrimaryScreen.WorkingArea.Height;
           

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            Choice newForm = new Choice();
            newForm.Visible = true;
            this.Visible = false;
            

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Records_Click(object sender, EventArgs e)
        {
          
        }

        private void About_Click(object sender, EventArgs e)
        {
            panelButton.Visible = true;
            aboutButton.PerformClick();
            
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://store.steampowered.com/app/292030/The_Witcher_3_Wild_Hunt/");
            this.WindowState = FormWindowState.Minimized;
        }

        private void Arkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && about == true)
            {
                about = false;
                About.Visible = true;
                ExitButton.Visible = true;
                StartGame.Visible = true;
                linkLabel1.Visible = false;
                labelAbout.Visible = false;
                witcherLogo.Visible = false;
                cdLogo.Visible = false;
                panelButton.Visible = false;
                
                
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            Arkanoid form = new Arkanoid();
            About.Visible = false;
            ExitButton.Visible = false;
            StartGame.Visible = false;
            linkLabel1.Visible = true;
            linkLabel1.Top = form.Bottom;
            linkLabel1.Left = form.Width / 2;
            about = true;
            StreamReader sw = new StreamReader(@"Resources\About.txt", Encoding.GetEncoding(1251));
            string text = sw.ReadToEnd();
            labelAbout.Text = text;
            labelAbout.Top = form.Bottom / 2 - 50;
            labelAbout.Left = form.Width / 4;
            labelAbout.Visible = true;
            cdLogo.Visible = true;
            cdLogo.Left = form.Width / 4;
            cdLogo.Top = form.Bottom - 300;
            witcherLogo.Visible = true;
            witcherLogo.Left = form.Width / 4 + 300;
            witcherLogo.Top = form.Bottom - 300;
            panelButton.Left = form.Width / 55;
            panelButton.Top = form.Bottom / 5;
            
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            StreamReader sw = new StreamReader(@"Resources\Controls.txt", Encoding.GetEncoding(1251));
            string text = sw.ReadToEnd();
            labelAbout.Text = text;
            
        }
    }
}
