using System;
using System.Drawing;

namespace BrickBreakerGame
{
    public class Paddle
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public bool MoveLeft { get; set; }
        public bool MoveRight { get; set; }
        public int Velocity { get; private set; }

        // increased paddle speed, orinally 15
        public Paddle(int x, int y, int width = 250, int height = 15, int velocity = 30)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Velocity = velocity;
        }

        public void Update(Size clientSize, int speed)
        {

            if (MoveLeft && X > 0)
            {
                X -= speed;
            }
            if (MoveRight && X + Width < clientSize.Width)
            {
                X += speed;
            }
        }

        public void Render(Graphics g)
        {
            Brush lightBlueBrush = new SolidBrush(Color.FromArgb(45, 46, 45));
            g.FillRectangle(lightBlueBrush, X, Y, Width, Height);
            g.DrawRectangle(Pens.Black, X, Y, Width, Height);
        }
    }
}
