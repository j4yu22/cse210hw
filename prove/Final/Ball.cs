using System;
using System.Drawing;
using System.Collections.Generic;

namespace BrickBreakerGame
{
    public class Ball
    {
        private float x;
        private float y;
        private float velocityX;
        private float velocityY;
        private readonly float radius = 10;

        public event Action BallHitBottom;

        public Ball(float x, float y)
        {
            this.x = x;
            this.y = y;
            velocityX = 5;
            velocityY = 5;
        }

        public void Update(Size clientSize)
        {
            x += velocityX;
            y += velocityY;

            // Ball collision with the walls
            if (x < 0 || x > clientSize.Width - radius * 2)
            {
                velocityX = -velocityX;
            }
            if (y < 0)
            {
                velocityY = -velocityY;
            }
            if (y > clientSize.Height)
            {
                BallHitBottom?.Invoke();
            }
        }

        public void Render(Graphics g)
        {
            g.FillEllipse(Brushes.White, x, y, radius * 2, radius * 2);
        }

        public void CheckCollision(Paddle paddle, List<Brick> bricks, float paddleVelocity)
        {
            if (x + radius > paddle.X && x - radius < paddle.X + paddle.Width && y + radius > paddle.Y && y - radius < paddle.Y + paddle.Height)
            {

                y = paddle.Y - radius * 2;
                velocityY = -Math.Abs(velocityY);

            }

            foreach (var brick in bricks)
            {
                if (!brick.IsBroken && x + radius > brick.X && x - radius < brick.X + brick.Width && y + radius > brick.Y && y - radius < brick.Y + brick.Height)
                {
                    bool hitFromLeft = x + radius > brick.X && x < brick.X;
                    bool hitFromRight = x - radius < brick.X + brick.Width && x > brick.X + brick.Width;
                    bool hitFromTop = y + radius > brick.Y && y < brick.Y;
                    bool hitFromBottom = y - radius < brick.Y + brick.Height && y > brick.Y + brick.Height;

                    if (hitFromLeft || hitFromRight)
                    {
                        velocityX = -velocityX;
                    }
                    if (hitFromTop || hitFromBottom)
                    {
                        velocityY = -velocityY;
                    }

                    brick.Hit();
                    break;
                }
            }
        }
    }
}
