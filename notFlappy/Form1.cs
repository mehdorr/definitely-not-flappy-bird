using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notFlappy
{
    public partial class Form1 : Form
    {
        bool started = false;
        int pipeSpeed = 5;
        int gravity = 3;
        int score = 0;
        bool debug = false;
        bool cheating = false;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            textEnd1.Visible = false;
            textEnd2.Visible = false;
        }



        private void time_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            textScore.Text = "Current Score: " + score;
            int randVal1 = rand.Next(800, 850) + 1;
            int randVal2 = rand.Next(800, 850) + 1;
            int randVal3 = rand.Next(10, 100) + 1;
            int randVal4 = rand.Next(10, 100) + 1;
            label1.Text = "top " + pipeTop.Top;
            label2.Text = "bottom " + pipeBottom.Top;
            label3.Text = "top shift " + pipeTop.Left;
            label4.Text = "bottom shift " + pipeBottom.Left;
            int top = -120;
            int bottom = 382;

            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(clouds.Bounds))
            {
                endGame();
            }


            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = randVal1;
                pipeBottom.Top = bottom + randVal3;
            }
            else if (pipeTop.Left < -80)
            {
                pipeTop.Left = randVal2;
                pipeTop.Top = top + randVal4;
            }

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -3;
            }
            if (e.KeyCode == Keys.Enter && !started)
            {
                time.Enabled = true;
                timeSlow.Enabled = true;
                textStart.Visible = false;
                started = true;
            }
            if (e.KeyCode == Keys.Z)
            {
                time.Enabled = true;
                timeSlow.Enabled = true;
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                if (!debug)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    debug = true;
                }
                else
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    debug = false;
                }
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                Form1 newForm = new Form1();
                newForm.Show();
                this.Dispose(false);
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                Application.Exit();
            }
            if (e.Control && e.KeyCode == Keys.H)
            {
                if (!cheating)
                {
                    cheats();
                    cheating = true;
                }
                else
                {
                    cheatsOff();
                    cheating = false;
                }
            }
        }

        private void cheats()
        {
            time.Stop();
            time.Enabled = false;
            timeCheat.Enabled = true;
            timeCheat.Start();
        }

        private void cheatsOff()
        {
            timeCheat.Stop();
            timeCheat.Enabled = false;
            time.Enabled = true;
            time.Start();
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 3;
            }
        }

        private void endGame()
        {
            textEnd1.Text = "You lost! Press CTRL+R to try again.";
            textEnd2.Text = "Your final score is: " + score;
            timeSlow.Enabled = false;
            time.Enabled = false;
            textEnd1.Visible = true;
            textEnd2.Visible = true;
        }

        private void timeSlow_Tick(object sender, EventArgs e)
        {
            score += 1;
        }

        private void timeCheat_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            textScore.Text = "Current Score: " + score;
            int randVal1 = rand.Next(800, 850) + 1;
            int randVal2 = rand.Next(800, 850) + 1;
            int randVal3 = rand.Next(10, 100) + 1;
            int randVal4 = rand.Next(10, 100) + 1;
            label1.Text = "top " + pipeTop.Top;
            label2.Text = "bottom " + pipeBottom.Top;
            label3.Text = "top shift " + pipeTop.Left;
            label4.Text = "bottom shift " + pipeBottom.Left;
            int top = -120;
            int bottom = 382;

            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                gravity = -3;
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                gravity = -3;
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                gravity = -3;
            }
            else if (flappyBird.Bounds.IntersectsWith(clouds.Bounds))
            {
                gravity = 3;
            }


            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = randVal1;
                pipeBottom.Top = bottom + randVal3;
            }
            else if (pipeTop.Left < -80)
            {
                pipeTop.Left = randVal2;
                pipeTop.Top = top + randVal4;
            }
        }
    }
}
