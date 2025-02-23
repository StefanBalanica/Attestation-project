using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public static Form1 instanta;
        public static string[] allLines = File.ReadAllLines(@"E:\foldere\proiectul\Resources\Cuvinte.txt");
        public static Random rnd1 = new Random();
        public static string cuvant="";
        public Form1()
        {
            InitializeComponent();
            instanta= this;
            timerLitJ.Start();
        }
       // Random culoare;
      
        private void timerLitO_Tick_1(object sender, EventArgs e)
        {
            labelO.ForeColor = Color.Red;
            label1.ForeColor= Color.Blue;
            labelO.Font = new Font("Comic Sans MS", 30);
            label1.Font = new Font("Comic Sans MS", 26);
            timerLitO.Stop();
            timerLitC.Start();
        }

        private void timerLitC_Tick_1(object sender, EventArgs e)
        {
            labelC.ForeColor = Color.Yellow;
            labelO.ForeColor = Color.Green;
            labelC.Font = new Font("Comic Sans MS", 30);
            labelO.Font = new Font("Comic Sans MS", 26);
            timerLitC.Stop();
            timerLinie.Start();
        }

        private void timerLit_I_Tick_1(object sender, EventArgs e)
        {
            labelIimare.ForeColor = Color.Cyan;
            labelLinie.ForeColor = Color.Magenta;
            labelIimare.Font = new Font("Comic Sans MS", 30);
            labelLinie.Font = new Font("Comic Sans MS", 26);
            timerLit_I.Stop();
            timerLitN.Start();
        }

        private void timerLinie_Tick_1(object sender, EventArgs e)
        {
            labelLinie.ForeColor = Color.LightBlue;
            labelC.ForeColor = Color.Purple;
            labelLinie.Font = new Font("Comic Sans MS", 30);
            labelC.Font = new Font("Comic Sans MS", 26);
            timerLinie.Stop();
            timerLit_I.Start();
        }

        private void timerLitN_Tick_1(object sender, EventArgs e)
        {
            labelN.ForeColor = Color.Brown;
            labelIimare.ForeColor = Color.Orange;
            labelN.Font = new Font("Comic Sans MS", 30);
            labelIimare.Font = new Font("Comic Sans MS", 26);
            timerLitN.Stop();
            timerA.Start();
        }

        private void timerA_Tick_1(object sender, EventArgs e)
        {
            labelA.ForeColor = Color.Pink;
            labelN.ForeColor = Color.Indigo;
            labelA.Font = new Font("Comic Sans MS", 30);
            labelN.Font = new Font("Comic Sans MS", 26);
            timerA.Stop();
            timerLItT.Start();
        }

        private void timerLItT_Tick_1(object sender, EventArgs e)
        {
            labelT.ForeColor = Color.LightGreen;
            labelA.ForeColor = Color.Firebrick;
            labelT.Font = new Font("Comic Sans MS", 30);
            labelA.Font = new Font("Comic Sans MS", 26);
            timerLItT.Stop();
            timerLItO2.Start();
        }

        private void timerR_Tick_1(object sender, EventArgs e)
        {
            labelR.ForeColor = Color.BlueViolet;
            labelO2.ForeColor = Color.Teal;
            labelR.Font = new Font("Comic Sans MS", 30);
            labelO2.Font = new Font("Comic Sans MS", 26);
            timerR.Stop();
            timerLitU.Start();
        }

        private void timerLItO2_Tick_1(object sender, EventArgs e)
        {
            labelO2.ForeColor = Color.RoyalBlue;
            labelT.ForeColor = Color.Olive;
            labelO2.Font = new Font("Comic Sans MS", 30);
            labelT.Font = new Font("Comic Sans MS", 26);
            timerLItO2.Stop();
            timerR.Start();
        }

        private void timerLitU_Tick_1(object sender, EventArgs e)
        {
            labelU.ForeColor = Color.Khaki;
            labelR.ForeColor = Color.Peru;
            labelU.Font = new Font("Comic Sans MS", 30);
            labelR.Font = new Font("Comic Sans MS", 26);
            timerLitU.Stop();
            timerLItL.Start();
        }

        private void timerLItL_Tick_1(object sender, EventArgs e)
        {
            labelL.ForeColor = Color.Fuchsia;
            labelU.ForeColor = Color.Red;
            labelL.Font = new Font("Comic Sans MS", 30);
            labelU.Font = new Font("Comic Sans MS", 26);
            timerLItL.Stop();
            timerLitJ.Start();
        }

        private void timerLitJ_Tick_1(object sender, EventArgs e)
        {
            label1.ForeColor= Color.Red;
            label1.Font = new Font("Comic Sans MS", 30);
            labelL.Font = new Font("Comic Sans MS", 26);
            timerLitJ.Stop();
            timerLitO.Start();
        }

        private void SpzHov(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.PerryDrsus;
        }

        private void SpzLv(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Perry_fin1;
        }

        private void SnkHov(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.PerryDrJos;
        }

        private void SnkLv(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Perry_fin1;
        }

        private void Xsi0Hv(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.PerryStSus;
        }

        private void Xsi0Lv(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Perry_fin1;
        }

        private void PngHv(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.PerryStJos;
        }

        private void PngLv(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Perry_fin1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Snake snake = new Snake();
            snake.Show();
            this.Hide();
        }

        private void buttonSpz_Click(object sender, EventArgs e)
        {
            cuvant=Convert.ToString(allLines[rnd1.Next(allLines.Length)]);
            Spanzuratoare spz= new Spanzuratoare();
            spz.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pong pong = new Pong();
            pong.Show();
            this.Hide();
        }

        private void buttonXsi0_Click(object sender, EventArgs e)
        {
            Xsi0 xsi0 =new Xsi0();
            xsi0.Show();
            this.Hide();
        }

        private void MHovAdg(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Sad;
        }

        private void MLvAdg(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Perry_fin1;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
