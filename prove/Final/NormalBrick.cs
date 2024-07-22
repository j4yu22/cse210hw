using System.Drawing;

namespace BrickBreakerGame
{
    public class NormalBrick : Brick
    {
        public NormalBrick(int x, int y, int width, int height) : base(x, y, width, height)
        {
        }

        public override void Hit()
        {
            IsBroken = true;
        }

        public override void Render(Graphics g)
        {
            if (!IsBroken)
            {
                Brush normalBrush = new SolidBrush(Color.FromArgb(186, 167, 123));
                g.FillRectangle(normalBrush, X, Y, Width, Height);
                g.DrawRectangle(Pens.Black, X, Y, Width, Height);
            }
        }
    }
}
