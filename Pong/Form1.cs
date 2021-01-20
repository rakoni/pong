using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        const int movementSpeed = 7; 
        bool isUpPressedPlayer1, isDownPressedPlayer1, isUpPressedPlayer2, isDownPressedPlayer2,isBallMoving;
        Ball ball;
        private int xSpeedBall = 5;
        private int ySpeedBall = 1;
        private int countBallBounces = 0;
        int scorePlayer1, scorePlayer2;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form4 f4 = new Form4();
            lbl_player1Name.Text = f4.tb_player1Name.Text;
            lbl_player2Name.Text = f4.tb_player2Name.Text;
        }

        Random randy = new Random();
        

        public Form1()
        {
            InitializeComponent();

            ball = new Ball(ball);
        }

        //Sticks Movement and movement speed
        private void timer1_Tick(object sender, EventArgs e)
        {
            var bottom = PongWorldInfo.fimTabuleiro - pb_ball.Size.Height - 40;

            if (isUpPressedPlayer1)
            {
                pb_leftStick.Location = new Point(pb_leftStick.Location.X, Math.Max(PongWorldInfo.topoTabuleiro, pb_leftStick.Location.Y - movementSpeed));
            }

            if (isDownPressedPlayer1)
            {
                pb_leftStick.Location = new Point(pb_leftStick.Location.X, Math.Min(PongWorldInfo.fimTabuleiro - pb_leftStick.Size.Height - 40, pb_leftStick.Location.Y + movementSpeed));
            }

            
            if (isUpPressedPlayer2)
            {
                pb_rightStick.Location = new Point(pb_rightStick.Location.X, Math.Max(PongWorldInfo.topoTabuleiro, pb_rightStick.Location.Y - movementSpeed));
            }

            if (isDownPressedPlayer2)
            {
                pb_rightStick.Location = new Point(pb_rightStick.Location.X, Math.Min(PongWorldInfo.fimTabuleiro - pb_rightStick.Size.Height - 40, pb_rightStick.Location.Y + movementSpeed));
            } 

            pb_ball.Location = new Point(pb_ball.Location.X + xSpeedBall, Math.Max(PongWorldInfo.topoTabuleiro, Math.Min(bottom, pb_ball.Location.Y + ySpeedBall)));
          
            if(pb_ball.Location.Y == bottom || pb_ball.Location.Y == PongWorldInfo.topoTabuleiro)
            {
               ySpeedBall *= -1;
            }

            if (pb_ball.Location.X <= PongWorldInfo.esquerdaTabuleiro)
            {
                scorePlayer2 = Convert.ToInt32(lbl_player2Score.Text) + 1;
                lbl_player2Score.Text = scorePlayer2.ToString();
                pb_ball.Location = new Point((PongWorldInfo.esquerdaTabuleiro + PongWorldInfo.direitaTabuleiro) / 2, (PongWorldInfo.topoTabuleiro + PongWorldInfo.fimTabuleiro) / 2);
                xSpeedBall = randy.Next(-5, 5);
                ySpeedBall = randy.Next(-5, 5);
                if (xSpeedBall == randy.Next(0, 0))
                {
                    xSpeedBall = randy.Next(-5, 5);
                    ySpeedBall = randy.Next(-5, 5);
                }
                
                               
            }
            else if(pb_ball.Location.X >= PongWorldInfo.direitaTabuleiro - pb_ball.Height)
            {
                scorePlayer1 = Convert.ToInt32(lbl_player1Score.Text) + 1;
                lbl_player1Score.Text = scorePlayer1.ToString();
                pb_ball.Location = new Point((PongWorldInfo.esquerdaTabuleiro + PongWorldInfo.direitaTabuleiro) / 2, (PongWorldInfo.topoTabuleiro + PongWorldInfo.fimTabuleiro) / 2);
                xSpeedBall = randy.Next(-5, 5);
                ySpeedBall = randy.Next(-5, 5);
                if (xSpeedBall == randy.Next(0, 0))
                {
                    xSpeedBall = randy.Next(-5, 5);
                    ySpeedBall = randy.Next(-5, 5);
                }

            }

            if(pb_leftStick.Bounds.IntersectsWith(pb_ball.Bounds) || pb_rightStick.Bounds.IntersectsWith(pb_ball.Bounds))
            {
                xSpeedBall *= -1;
                countBallBounces++;

            }

            if(countBallBounces == 5)
            {
                xSpeedBall *= 2;
                countBallBounces = 0;
            }
        }
        
        //Keybindings
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            //player 1 keys pressed
            if(e.KeyCode == Keys.W)
            {
                isUpPressedPlayer1 = true;
            }

            if (e.KeyCode == Keys.S)
            {
                isDownPressedPlayer1 = true;
            }

            //player 2 keys pressed
            if (e.KeyCode == Keys.Up)
            {
                isUpPressedPlayer2 = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                isDownPressedPlayer2 = true;
            }
        }

        // Keys released
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 keys released
            if (e.KeyCode == Keys.W)
            {
                isUpPressedPlayer1 = false;
            }

            if (e.KeyCode == Keys.S)
            {
                isDownPressedPlayer1 = false;
            }

            //player 2 keys released
            if (e.KeyCode == Keys.Up)
            {
                isUpPressedPlayer2 = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                isDownPressedPlayer2 = false;
            }
        }
    }
    
}
