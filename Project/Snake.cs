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
    public partial class Snake : Form
    {
        private List<Circle> snake = new List<Circle>();
        private Circle Food = new Circle();

        int maxWidth;
        int maxHeight;
        int score = 0, HighScore = 0;
        Random r = new Random();

        bool goUp, goLeft, goRight, goDown, pauza;

        private void MoveTimerEvent(object sender, EventArgs e)
        {

            if (goLeft==true)
            {
                Settings.directie= "st";
            }

            if (goRight==true)
            {
                Settings.directie= "dr";
            }

            if (goUp==true)
            {
                Settings.directie= "sus";
            }

            if (goDown==true)
            {
                Settings.directie= "jos";
            }


            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i==0)
                {
                    switch (Settings.directie)
                    {
                        case "st":
                            snake[i].x--;
                            break;
                        case "dr":
                            snake[i].x++;
                            break;
                        case "jos":
                            snake[i].y++;
                            break;
                        case "sus":
                            snake[i].y--;
                            break;

                    }

                    if (snake[i].x<0)
                    {
                        snake[i].x=maxWidth;
                    }
                    if (snake[i].x>maxWidth)
                    {
                        snake[i].x=0;
                    }
                    if (snake[i].y<0)
                    {
                        snake[i].y=maxHeight;
                    }
                    if (snake[i].y>maxHeight)
                    {
                        snake[i].y=0;
                    }

                    if (snake[i].x== Food.x && snake[i].y==Food.y)
                    {
                        Eat();
                    }
                    for (int j = 1; j<snake.Count; j++)
                    {

                        if (snake[0].x==snake[j].x && snake[0].y==snake[j].y)
                        {
                            moveTimer.Stop();
                            MessageBox.Show(" Ai pierdut :(");
                            labelSc.Text= "Scor: "+0;
                            labelSC2.Visible= true;
                            buttonSart.Visible=true;
                            buttonSart.Enabled=true;
                            buttonStop.Enabled=true;
                            buttonStop.Visible=true;
                            score=0;
                        }


                        if (score>HighScore)
                        {
                            HighScore=score;
                            labelSC2.Text= "Scor maxim: "+ HighScore;
                        }
                        else { labelSC2.Text= "Scor maxim: " + HighScore; }

                        if (score<5)
                            moveTimer.Interval=250;
                        else if (score<10)
                            moveTimer.Interval=200;
                        else if (score<15)
                            moveTimer.Interval=150;
                        else if (score<20)
                            moveTimer.Interval=100;
                        else if (score<25)
                            moveTimer.Interval=50;
                        else if (score>30)
                            moveTimer.Interval=20;


                    }
                }
                else
                {

                    snake[i].x= snake[i-1].x;
                    snake[i].y= snake[i-1].y;

                }
                if(pauza==true)
                {
                    buttonSart.Visible=true;
                    buttonSart.Enabled=true;
                    buttonStop.Enabled=true;
                    buttonStop.Visible=true;
                    labelPauza.Visible=true;
                    moveTimer.Stop();
                }


            }
            pictureArena.Invalidate();

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && Settings.directie != "dr")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D && Settings.directie != "st")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.W && Settings.directie != "jos")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S  &&  Settings.directie != "sus")
            {
                goDown = true;
            }
            if(e.KeyCode== Keys.P)
            {
                pauza=true;
            }
            if(e.KeyCode == Keys.Escape)
            {
                buttonSart.Visible=false;
                buttonSart.Enabled=false;
                buttonStop.Visible=false;
                buttonStop.Enabled =false;
                labelPauza.Visible=false;
                moveTimer.Start();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft= false;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight= false;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp= false;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown= false;
            }
            if (e.KeyCode== Keys.P)
            {
                pauza=false;
            }
        }

        private void buttonSart_Click(object sender, EventArgs e)
        {
            RestrartJoc();
        }

        private void Design(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush snakeColor;

            for (int i = 0; i< snake.Count; i++)
            {
                if (i==0)
                {
                    snakeColor= Brushes.Black;
                }

                else
                {
                    snakeColor = Brushes.RoyalBlue;
                }

                g.FillEllipse(snakeColor, new Rectangle
                    (
                    snake[i].x * Settings.width,
                    snake[i].y * Settings.height,
                    Settings.width, Settings.height));


            }

            g.FillEllipse(Brushes.RosyBrown, new Rectangle
                   (
                   Food.x * Settings.width,
                   Food.y * Settings.height,
                   Settings.width, Settings.height));
        }

        public Snake()
        {
            InitializeComponent();
            new Settings();
            if (score>HighScore)
            {
                HighScore=score;
                labelSC2.Text= "Scor maxim: "+ HighScore;
            }
            labelSC2.Visible=false;
        }

        private void pictureArena_Click(object sender, EventArgs e)
        {

        }

        private void Snake_Load(object sender, EventArgs e)
        {
            labelPauza.Visible=false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.instanta.Show();
        }
        private void RestrartJoc()
        {
            maxHeight = pictureArena.Height / Settings.height-1;
            maxWidth  = pictureArena.Width / Settings.width-1;

            snake.Clear();

            Circle head = new Circle { x=10, y=10 };
            snake.Add(head);

            for (int i = 0; i<1; i++)
            {
                Circle body = new Circle();
                snake.Add(body);

            }

            Food= new Circle { x= r.Next(2, maxWidth), y= r.Next(2, maxHeight) };

            buttonSart.Visible=false;
            buttonSart.Enabled=false;
            buttonStop.Visible=false;   
            buttonStop.Enabled =false;
            labelPauza.Visible=false;



            moveTimer.Start();

        }

        private void Eat()
        {
            score++;
            labelSc.Text= "Scor: "+score;
            Circle body = new Circle()
            {
                x= snake[snake.Count-1].x,
                y= snake[snake.Count-1].y,
            };
            snake.Add(body);
            Food= new Circle { x= r.Next(2, maxWidth), y= r.Next(2, maxHeight) };

        }
    }
}
