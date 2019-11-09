using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class GameForm : Form
    {
        public Label pauselabel;
        public Label scorep1;
        public Label scorep2;
        public Panel left;
        public Panel right;
        public Panel ball;
        public bool[] movement = new bool[4];
        public int ballVel = 0;
        public bool game_start = false;
        public int statP1 = 0;
        public int statP2 = 0;
        public int _spd = 3;
        public int _spdinc = 0;
        public Random rand = new Random();
        public int max_spd = 10;
        public int min_spd = 3;
        public GameForm()
        {
            InitializeComponent();
            left = this.LeftPanel;
            right = this.RightPanel;
            pauselabel = this.pauseLabel;
            scorep1 = this.scorep1panel;
            scorep2 = this.scorep2panel;
            ball = this.ballPanel;
            timer1.Interval = 1000 / 60;
            timer1.Start();
        }

        private void goaled()
        {
            ball.Location = new Point(242, 71);
            ballVel = rand.Next(0, 4);
            _spd = min_spd;
        }

        private void incSpeed()
        {
            _spdinc += 1;
            if (_spdinc > 3)
            {
                _spdinc = 0;
                _spd += 1;
                if (_spd > max_spd)
                {
                    _spd = max_spd;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            Keys key = e.KeyCode;
            if (game_start)
            {
                if (key == Keys.W)
                {
                    movement[0] = true;
                    movement[1] = false;
                }
                else if (key == Keys.S)
                {
                    movement[1] = true;
                    movement[0] = false;
                }
                if (key == Keys.Up)
                {
                    movement[2] = true;
                    movement[3] = false;
                }
                else if (key == Keys.Down)
                {
                    movement[3] = true;
                    movement[2] = false;
                }
            }
            if (key == Keys.Enter)
            {
                if (!game_start)
                {
                    game_start = true;
                    pauselabel.Visible = false;
                    ball.Visible = true;
                    ballVel = rand.Next(0, 4);
                }
                else
                {
                    pauselabel.Text = "START GAME\nPRESS ENTER";
                    pauselabel.Visible = true;
                    game_start = false;
                    statP1 = 0;
                    statP2 = 0;
                    left.Location = new Point(left.Location.X, 10);
                    right.Location = new Point(right.Location.X, 10);
                    movement = new bool[4];
                    ball.Visible = false;
                    ball.Location = new Point(242, 71);
                    ballVel = 0;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyData;
            if (game_start)
            {
                if (key == Keys.W)
                {
                    movement[0] = false;
                }
                else if (key == Keys.S)
                {
                    movement[1] = false;
                }
                if (key == Keys.Up)
                {
                    movement[2] = false;
                }
                else if (key == Keys.Down)
                {
                    movement[3] = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game_start)
            {
                if (scorep1 != null && scorep2 != null)
                {
                    scorep1.Text = Convert.ToString(statP1);
                    scorep2.Text = Convert.ToString(statP2);
                }

                right.Location = new Point(right.Location.X, ball.Location.Y - 18);
                //left.Location = new Point(left.Location.X, ball.Location.Y - 18);

                //Strong "AI's" for both players (not unbeatable!).
                //QUESTION: Why aren't the "AI's" unbeatable?
                //HINT: Speed.
                //TASK: Make a game menu where you can choose between
                //player vs. player, player vs. computer and computer vs. computer.

                if (statP1 == 10)
                {
                    statP1 = 0;
                    statP2 = 0;
                    ball.Visible = false;
                    pauselabel.Text = " PLAYER 1\n WINS";
                    pauselabel.Visible = true;
                    left.Location = new Point(left.Location.X, 10);
                    right.Location = new Point(right.Location.X, 10);
                    game_start = false;
                }
                else if (statP2 == 10)
                {
                    statP1 = 0;
                    statP2 = 0;
                    ball.Visible = false;
                    pauselabel.Text = " PLAYER 2\n WINS";
                    pauselabel.Visible = true;
                    left.Location = new Point(left.Location.X, 10);
                    right.Location = new Point(right.Location.X, 10);
                    game_start = false;
                }
                if (movement[0])
                {
                    left.Location = new Point(left.Location.X, left.Location.Y - _spd);
                    if (left.Location.Y < 2)
                    {
                        left.Location = new Point(left.Location.X, 2);
                    }
                }
                else if (movement[1])
                {
                    left.Location = new Point(left.Location.X, left.Location.Y + _spd);
                    if (left.Location.Y + left.Size.Height > 198)
                    {
                        left.Location = new Point(left.Location.X, 198 - left.Size.Height);
                    }
                }
                if (movement[2])
                {
                    right.Location = new Point(right.Location.X, right.Location.Y - _spd);
                    if (right.Location.Y < 2)
                    {
                        right.Location = new Point(right.Location.X, 2);
                    }
                }
                else if (movement[3])
                {
                    right.Location = new Point(right.Location.X, right.Location.Y + _spd);
                    if (right.Location.Y + right.Size.Height > 198)
                    {
                        right.Location = new Point(right.Location.X, 198 - right.Size.Height);
                    }
                }
                int lx = ball.Location.X;
                int ly = ball.Location.Y;
                switch (ballVel)
                {
                    case 0:
                        ball.Location = new Point(lx + _spd, ly + _spd);
                        break;
                    case 1:
                        ball.Location = new Point(lx + _spd, ly - _spd);
                        break;
                    case 2:
                        ball.Location = new Point(lx - _spd, ly + _spd);
                        break;
                    case 3:
                        ball.Location = new Point(lx - _spd, ly - _spd);
                        break;
                }
                lx = ball.Location.X;
                ly = ball.Location.Y;
                if (ball.Location.X + ball.Size.Width > 495)
                {
                    statP1 += 1;
                    goaled();
                }
                else if (ball.Location.X < 1)
                {
                    statP2 += 1;
                    goaled();
                }
                else if (ball.Location.Y < 2)
                {
                    ball.Location = new Point(ball.Location.X, 2);
                    if (ballVel == 1)
                    {
                        ballVel = 0;
                    }
                    else if (ballVel == 3)
                    {
                        ballVel = 2;
                    }
                }
                else if (ball.Location.Y + ball.Size.Height > 198)
                {
                    ball.Location = new Point(ball.Location.X, 198 - ball.Size.Height);
                    if (ballVel == 0)
                    {
                        ballVel = 1;
                    }
                    else if (ballVel == 2)
                    {
                        ballVel = 3;
                    }
                }
                else if ((ball.Location.X >= left.Location.X && ball.Location.X <= left.Location.X + left.Size.Width)
                  && ((ball.Location.Y >= left.Location.Y && ball.Location.Y <= left.Location.Y + left.Size.Height)
                  || (ball.Location.Y + ball.Size.Height >= left.Location.Y && ball.Location.Y + ball.Size.Height <= left.Location.Y + left.Size.Height)))
                {
                    ball.Location = new Point(ball.Location.X + _spd, ball.Location.Y);
                    if (ballVel == 2)
                    {
                        ballVel = 0;
                    }
                    else if (ballVel == 3)
                    {
                        ballVel = 1;
                    }
                    incSpeed();
                }
                else if ((ball.Location.X + ball.Size.Width >= right.Location.X && ball.Location.X + ball.Size.Width <= right.Location.X + right.Size.Width)
                  && ((ball.Location.Y >= right.Location.Y && ball.Location.Y <= right.Location.Y + right.Size.Height)
                  || (ball.Location.Y + ball.Size.Height >= right.Location.Y && ball.Location.Y + ball.Size.Height <= right.Location.Y + right.Size.Height)))
                {
                    ball.Location = new Point(ball.Location.X - _spd, ball.Location.Y);
                    if (ballVel == 0)
                    {
                        ballVel = 5;
                    }
                    else if (ballVel == 1)
                    {
                        ballVel = 2;
                    }
                    incSpeed();
                }
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scorep1panel_Click(object sender, EventArgs e)
        {

        }
    }
}