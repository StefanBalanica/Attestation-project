using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Pong : Form
    {
        bool goup1, godown1, goup2, godown2, pauza, pauza2;
        int minge_x = 4, minge_y = 4, scor1 = 0, scor2 = 0;
        public Stopwatch timer = new Stopwatch();
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goup1 = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup2 = true;
            }
            if (e.KeyCode == Keys.S)
            {
                godown1 = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown2 = true;
            }
            if(e.KeyCode == Keys.P)
            {
                pauza2=true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                pauza=true;
               
                    buttonStart.Visible=false;
                    buttonStart.Enabled=false;
                    buttonStop.Enabled=false;
                    buttonStop.Visible=false;
                    labelScor.Visible=false;
                    timer1.Start();
                
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goup1 = false;

            }
            if (e.KeyCode == Keys.Up)
            {

                goup2 = false;
            }


            if (e.KeyCode == Keys.S)
            {
                godown1 = false;
            }
            if (e.KeyCode == Keys.Down)
                godown2 = false;
            if (e.KeyCode == Keys.P)
            {
                pauza2=false;
            }
            if (e.KeyCode == Keys.Escape)
            {
                pauza=false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.instanta.Show();
        }

        private void Pong_Load(object sender, EventArgs e)
        {
            buttonStart.Visible=false;
            buttonStop.Visible=false;
            buttonStop.Enabled=false;
            labelScor.Visible=false;
        }

        private void TImerJoc(object sender, EventArgs e)
        {
            Minge.Top-= minge_y;
            Minge.Left-= minge_x;
            LinieCentru.Location= new Point(ClientSize.Width/2, ClientSize.Height/2);
            LinieCentru.Top= 0;
            LinieCentru.Height= ClientSize.Height;

             
            if(pauza2==true)
            {
                buttonStart.Visible=true;
                buttonStart.Enabled=true;
                buttonStop.Enabled=true;
                buttonStop.Visible=true;
                labelScor.Visible=true;
                timer1.Stop();
            }
           
            if (scor1>=10)
            {
                timer1.Stop();
                MessageBox.Show("Jucatorul 1 a castigat!");
                buttonStart.Visible=true;
                buttonStart.Enabled=true;
                buttonStop.Enabled=true;
                buttonStop.Visible=true;

            }
            if (scor2>=10)
            {
                timer1.Stop();
                MessageBox.Show("Jucatorul 2 a castigat!");
                buttonStart.Visible=true;
                buttonStart.Enabled=true;
                buttonStop.Enabled=true;
                buttonStop.Visible=true;

            }

            if (Minge.Left < 0)
            {

                Minge.Left = ClientSize.Width/2;
                minge_x = -minge_x;
                minge_x -= 2;
                scor2++;
                labelScor2.Text = ""+scor2;

            }

            if (Minge.Left + Minge.Width > ClientSize.Width)
            {
                Minge.Left = ClientSize.Width/2;
                minge_x = -minge_x;
                minge_x += 2;
                scor1++;
                labelScor1.Text =""+scor1;
            }


            if (Minge.Top<0 || Minge.Bottom >ClientSize.Height)
            {
                minge_y = -minge_y;
            }

            if (Minge.Bounds.IntersectsWith(Jucator1.Bounds) || Minge.Bounds.IntersectsWith(Jucator2.Bounds))
            {
                minge_x= -minge_x;
            }

            if (goup1==true && Jucator1.Top>0)
            {
                Jucator1.Top-=8;

            }
            if (goup2==true && Jucator2.Top>0)
            {
                Jucator2.Top-=8;

            }

            if (godown1==true && Jucator1.Bottom < ClientSize.Height)
            {
                Jucator1.Top+=8;
            }
            if (godown2==true && Jucator2.Bottom < ClientSize.Height)
            {
                Jucator2.Top+=8;
            }
        }

        public Pong()
        {
            InitializeComponent();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            resetare();
        }

        private void labelScor1_Click(object sender, EventArgs e)
        {

        }
        private void resetare()
        {
            buttonStart.Visible=false;
            buttonStart.Enabled=false;
            buttonStop.Visible=false;
            buttonStop.Enabled=false;
            minge_x = 4;
            minge_y = 4;
            scor1=0;
            scor2=0;
            labelScor2.Text = ""+scor2;
            labelScor1.Text = ""+scor1;
            timer1.Start();
        }

    }
}
