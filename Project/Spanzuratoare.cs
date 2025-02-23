using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Spanzuratoare : Form
    {
        private char Primlit = Form1.cuvant[1];
        public static string V = " ";
        public static string V2 = " ";
        int greseli = 0;
        public Spanzuratoare()
        {
            InitializeComponent();
        }

        private void Spanzuratoare_Load(object sender, EventArgs e)
        {
            lucru();
            
        }
        void lucru()
        {
            for (int i = 1; i<Form1.cuvant.Length; i++)
            {
                V = V.Insert(i, "*");
            }
            char[] cuvAsChar = V.ToCharArray();
            string copie = Form1.cuvant.ToString();
            char[] cuv2 = copie.ToCharArray();
            cuvAsChar[0]= cuv2[0];
            cuvAsChar[Form1.cuvant.Length-1] = cuv2[Form1.cuvant.Length-1];
            V= new string(cuvAsChar);
            labelAfisare.Text= V;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] cuvAsChar = V.ToCharArray();
            int n = 0;
            for (int i = 1; i<Form1.cuvant.Length-1; i++)
            {
                char litera = Convert.ToChar(textBox2.Text);
                string copie = Form1.cuvant.ToString();
                char[] cuv2 = copie.ToCharArray();
                if (cuv2[i]== litera)
                {
                    cuvAsChar[i]= litera;
                    n=1;
                }
                V= new string(cuvAsChar);
                labelAfisare.Text= V;
            }
            textBox2.Clear();
            if (n!=1)
            {
                greseli++;
                n=0;
                if (greseli==1)
                { this.pictureBox1.Image= Properties.Resources.Des2; }
                else if (greseli==2)
                { this.pictureBox1.Image= Properties.Resources.Des3; }
                else if (greseli==3)
                { this.pictureBox1.Image= Properties.Resources.Des4; }
                else if (greseli==4)
                { this.pictureBox1.Image= Properties.Resources.Des5; }
                else if (greseli==5)
                { this.pictureBox1.Image= Properties.Resources.Des6; }
                else if (greseli==6)
                { this.pictureBox1.Image= Properties.Resources.Des7; }
      
            labelScor.Text = greseli.ToString();
            }
            if (greseli==6)
            {
                string AcestCuvant = "Ai pierdut :(\n         Cuvantu era "+Form1.cuvant;
                MessageBox.Show(AcestCuvant);
                
                button2.Visible = true;
                V= V2;
            }
            if (V == Form1.cuvant.ToString())
            {
                MessageBox.Show("     Felicitari!\n     Ai castigat :)");
                V= V2;
                button2.Visible = true;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.cuvant =Convert.ToString(Form1.allLines[Form1.rnd1.Next(Form1.allLines.Length)]);
            Primlit = Form1.cuvant[1];
            greseli= 0;
            labelScor.Text="0";
            this.pictureBox1.Image= Properties.Resources.Des1;
            lucru();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.instanta.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
