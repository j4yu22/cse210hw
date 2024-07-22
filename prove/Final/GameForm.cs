// GameForm.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BrickBreakerGame
{
    public partial class GameForm : Form
    {
        private Ball ball;
        private Paddle paddle;
        private Level level;
        private System.Windows.Forms.Timer timer;

        public GameForm()
        {
            InitializeComponent();

            this.ClientSize = new Size(1000, 800);

            int rows = 12;
            int cols = 22;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            level = new Level(rows, cols, formWidth, formHeight);
            ball = new Ball(formWidth / 2, formHeight / 2);
            paddle = new Paddle(formWidth / 2 - 50, formHeight - 100);

            ball.BallHitBottom += OnBallHitBottom;

            timer = new System.Windows.Forms.Timer();
            // lower means faster game
            timer.Interval = 6;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.UpdateStyles();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ball.Update(this.ClientSize);
            paddle.Update(this.ClientSize, 10);
            ball.CheckCollision(paddle, level.Bricks, paddle.Velocity);
            this.Invalidate();

            CheckWinCondition();
        }

        private void CheckWinCondition()
        {
            if (level.Bricks.All(b => b.IsBroken || b is UnbreakableBrick))
            {
                timer.Stop();
                MessageBox.Show("You win!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void OnBallHitBottom()
        {
            timer.Stop();
            DialogResult result = MessageBox.Show("You lose! Do you want to restart?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                this.Close();
            }
        }

        private void RestartGame()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            ball = new Ball(formWidth / 2, formHeight / 2);
            paddle = new Paddle(formWidth / 2 - 50, formHeight - 100);
            level = new Level(12, 22, formWidth, formHeight);

            ball.BallHitBottom += OnBallHitBottom;

            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.FromArgb(166, 158, 157));

            ball.Render(g);
            paddle.Render(g);
            level.Draw(g);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle.MoveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                paddle.MoveRight = true;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle.MoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                paddle.MoveRight = false;
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
        }
    }
}
