using System.Drawing;

namespace BrickBreakerGame
{
    public class StrongBrick : Brick
    {
        private int hitsRemaining;

        public StrongBrick(int x, int y, int width, int height) : base(x, y, width, height)
        {
            hitsRemaining = 2;
        }

        public override void Hit()
        {
            hitsRemaining--;
            if (hitsRemaining <= 0)
            {
                IsBroken = true;
            }
        }

        public override void Render(Graphics g)
        {
            if (!IsBroken)
            {
                Brush strongBrush = new SolidBrush(Color.FromArgb(232, 121, 81));
                g.FillRectangle(strongBrush, X, Y, Width, Height);
                g.DrawRectangle(Pens.Black, X, Y, Width, Height);
            }
        }
    }
}
