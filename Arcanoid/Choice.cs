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
    public partial class Choice : Form
    {
        static public string playerName;
        static public string selectedLevel = "";
        public string school = "Волк";
        public bool selectLevel = false;
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string filename);
        public Choice()
        {
            
            this.KeyPreview = true;
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Cursor mycursor = new Cursor(Cursor.Current.Handle);
            IntPtr colorcursorhandle = LoadCursorFromFile(@"Resources\newcursor.cur");
            mycursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, mycursor, new object[] { colorcursorhandle });
            this.Cursor = mycursor;
            DirectoryInfo d = new DirectoryInfo(currentPath + @"\Profiles");
            d.Create();
            InitializeComponent();
            //menu = new Arkanoid() { Visible = false };
            FileInfo[] files = d.GetFiles("*.dat");
            profileList.Items.Clear();
            foreach (FileInfo fi in files)
            {
               string s = Path.GetFileNameWithoutExtension(fi.ToString());

                profileList.Items.Add(s);
            }

            

            
        }

        private void Choice_Load(object sender, EventArgs e)
        {
            Choice form = new Choice();
            panelList.Left = form.Width / 3;
            panelList.Top = form.Height / 7;
            levelSelect.Left = form.Width / 55;
            levelSelect.Top = form.Height / 3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Check.Text = "Школа Змеи";
            Check.ForeColor = Color.DarkGreen;
            school = "Змея";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Check.Text = "Школа Волка";
            Check.ForeColor = Color.Maroon;
            school = "Волк";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Check.Text = "Школа Медведя";
            Check.ForeColor = Color.SaddleBrown;
            school = "Медведь";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Check.Text = "Школа Кота";
            Check.ForeColor = Color.Blue;
            school = "Кот";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Check.Text = "Школа Грифона";
            Check.ForeColor = Color.LightSeaGreen;
            school = "Грифон";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bestScor;
            string name = profileList.SelectedItem.ToString();
            playerName = name;
            StreamReader sr = new StreamReader(@"Profiles\" + name + ".dat");
            string school = sr.ReadLine();
            string progress = sr.ReadLine();
            BinaryReader br = new BinaryReader(File.Open(@"Profiles\Records\" + name + ".bin", FileMode.Open));
            bestScor = Convert.ToString(br.ReadInt32());
            schoolLabel.Text = school;
            progressCount.Text = progress + "/3";
            acceptProfile.Visible = true;
            deleteProfile.Visible = true;
            bestScore.Visible = true;
            bestScore.Text = bestScor;
            sr.Close();
            br.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playButton.Left = levelSelect.Width / 2;
            selectLevel = true;
            Choice form = new Choice();
            levelSelect.Top = form.Top;
            levelSelect.Width = form.Width;
            levelSelect.Left = form.Left;
            panelList.Visible = false;
            schoolSelect.Visible = false;
            enterPanel.Visible = false;
            levelSelect.Visible = true;
            string progress = File.ReadLines(@"Profiles\" + playerName + ".dat").Skip(1).First();
            if (Convert.ToInt32(progress) == 1)
            {
                novigradSelect.Enabled = true;
            }
            else if (Convert.ToInt32(progress) >= 2)
            {
                velenSelect.Enabled = true;
                novigradSelect.Enabled = true;
            }
            else
            {
                velenSelect.Enabled = false;
                novigradSelect.Enabled = false;
            }
            
            

        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            
            profileList.Enabled = false;
            acceptProfile.Enabled = false;
            deleteProfile.Enabled = false;
            plusProfile.Enabled = false;
            textBox1.Text = "";
            panelMes.Text = "Введите имя игрока (макс. 10 символов)";
            enterPanel.Visible = true;
            schoolSelect.Visible = true;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
           
            string name = textBox1.Text;
            if (name != "" && (profileList.Items.Contains(name) == false))
            {
                FileInfo f = new FileInfo(@"Profiles\" + name  + ".dat");
                f.Create().Close();
                FileInfo b = new FileInfo(@"Profiles\Records\" + name + ".bin");
                b.Create().Close();
                BinaryWriter bw = new BinaryWriter(File.Open(@"Profiles\Records\" + name + ".bin", FileMode.Open));
                bw.Write(0);
                bw.Close();
                StreamWriter sw = new StreamWriter(@"Profiles\" + name + ".dat");
                sw.WriteLine(school);
                sw.Write("0");
                sw.Close();
                profileList.Items.Add(name);
                enterPanel.Visible = false;
                acceptProfile.Enabled = true;
                deleteProfile.Enabled = true;
                plusProfile.Enabled = true;
                profileList.Enabled = true;
                schoolSelect.Visible = false;
               

            }
            else if (profileList.Items.Contains(name))
            {
                panelMes.Text = "Профиль с таким именем уже существует!";
            }
            else
            {
                panelMes.Text = "Имя должно содержать символы!";
            }
        }

        private void deleteProfile_Click(object sender, EventArgs e)
        {
            acceptProfile.Visible = false;
            deleteProfile.Visible = false;
            bestScore.Visible = false;
            FileInfo d = new FileInfo(@"Profiles\" + profileList.SelectedItem + ".dat");
            d.Delete();
            FileInfo b = new FileInfo(@"Profiles\Records\" + profileList.SelectedItem + ".bin");
            b.Delete();
            DirectoryInfo a = new DirectoryInfo(@"Profiles\");
            FileInfo[] files = a.GetFiles("*.dat");
            profileList.Items.Clear();
            foreach (FileInfo fi in files)
            {
                string s = Path.GetFileNameWithoutExtension(fi.ToString());
                
                profileList.Items.Add(s);
            }
            schoolLabel.Text = "";
            progressCount.Text = "";



        }

        private void cancelEnter_Click(object sender, EventArgs e)
        {
            enterPanel.Visible = false;
            acceptProfile.Enabled = true;
            deleteProfile.Enabled = true;
            plusProfile.Enabled = true;
            profileList.Enabled = true;
            schoolSelect.Visible = false;
            
        }

        

        private void schoolSelect_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        private void enterPanel_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        private void Choice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && selectLevel == false)
            {
                Arkanoid newForm = new Arkanoid();
                newForm.Visible=true;
                this.Visible = false;
                
                

            }
            if(e.KeyCode == Keys.Escape && selectLevel == true)
            {
                selectLevel = false;
                panelList.Visible = true;
                schoolSelect.Visible = false;
                enterPanel.Visible = false;
                levelSelect.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void profileList_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void kaerSelect_Click(object sender, EventArgs e)
        {
            levelName.Text = "Каер Морхен";
            playButton.Visible = true;
        }

        private void novigradSelect_Click(object sender, EventArgs e)
        {
            levelName.Text = "Новиград";
            playButton.Visible = true;
        }

        private void velenSelect_Click(object sender, EventArgs e)
        {
            levelName.Text = "Велен";
            playButton.Visible = true;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            selectedLevel = levelName.Text;
            GamePlay frm = new GamePlay();
            frm.Show();
            this.Hide();
            
        }
    }
}
