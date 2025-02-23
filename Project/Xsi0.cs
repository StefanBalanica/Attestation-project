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
    public partial class Xsi0 : Form
    {
        public Xsi0()
        {
            InitializeComponent();
            buttonRes.Visible = false;
        }
        Button[,] matButton = new Button[3, 3];
        int nr = 0;
        private void disable()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matButton[i, j].Enabled = false;
            buttonRes.Visible = true;
        }
        private void Xsi0_Load(object sender, EventArgs e)
        {
            int x = this.Width / 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matButton[i, j] = new Button();
                    matButton[i, j].Size = new Size(70, 70);
                    matButton[i, j].Location = new Point(x + j * 75, 100 + i * 75);
                    matButton[i, j].Text = "";
                    matButton[i, j].BackColor = Color.LightGray;
                    matButton[i, j].Font = new Font("Arial", 12);
                    this.Controls.Add(matButton[i, j]);
                    matButton[i, j].Visible = false;
                    matButton[i, j].Click += new EventHandler(buttonJoc_Click);
                }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matButton[i, j].Visible = true;
            labelPlayer.Text = "Turn X";
        }
        private void buttonJoc_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (labelPlayer.Text == "Turn X")
            {
                btn.ForeColor = Color.Blue;
                btn.Text = "X";
                labelPlayer.Text = "Turn 0";
                btn.Enabled = false;
            }
            else
                 if (labelPlayer.Text == "Turn 0")
            {
                btn.ForeColor = Color.Red;
                btn.Text = "0";
                labelPlayer.Text = "Turn X";
                btn.Enabled = false;
            }
            nr++;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (matButton[i, j] == btn)
                    {
                        if (matButton[i, 0].Text == matButton[i, 1].Text && matButton[i, 0].Text == matButton[i, 2].Text)
                        {
                            if (labelPlayer.Text == "Turn 0")
                            {
                                MessageBox.Show("Player X has won!");
                                disable();

                            }

                            else
                            {
                                MessageBox.Show("Player 0 has won!");
                                disable();

                            }
                            return;
                        }
                        if (matButton[0, j].Text == matButton[1, j].Text && matButton[0, j].Text == matButton[2, j].Text)
                        {
                            if (labelPlayer.Text == "Turn 0")
                            {
                                MessageBox.Show("Player X has won!");
                                disable();
                            }

                            else
                            {
                                MessageBox.Show("Player 0 has won!");
                                disable();
                            }
                            return;
                        }
                        if (i == j)
                            if (matButton[0, 0].Text == matButton[1, 1].Text && matButton[0, 0].Text == matButton[2, 2].Text)
                            {
                                if (labelPlayer.Text == "Turn 0")
                                {
                                    MessageBox.Show("Player X has won!");
                                    disable();
                                }
                                else
                                {
                                    MessageBox.Show("Player 0 has won!");
                                    disable();
                                }

                                return;
                            }
                        if (i + j == 2)
                            if (matButton[0, 2].Text == matButton[1, 1].Text && matButton[0, 2].Text == matButton[2, 0].Text)
                            {
                                if (labelPlayer.Text == "Turn 0")
                                {
                                    MessageBox.Show("Player X has won!");
                                    disable();
                                }
                                else
                                {
                                    MessageBox.Show("Player 0 has won!");
                                    disable();
                                }

                                return;
                            }
                    }
            if (nr == 9)
            {
                MessageBox.Show("Egalitate");
                disable();
                return;
            }

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matButton[i, j].Text = " ";
                    matButton[i, j].Enabled = true;
                }
            nr = 0;
            labelPlayer.Text = "Turn X";
            buttonRes.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.instanta.Show();
        }
    }
}
