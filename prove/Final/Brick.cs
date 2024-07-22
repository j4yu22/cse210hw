using System.Drawing;

namespace BrickBreakerGame
{
    public abstract class Brick
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsBroken { get; protected set; }

        protected Brick(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            IsBroken = false;
        }

        public abstract void Hit();
        public abstract void Render(Graphics g);
    }
}
