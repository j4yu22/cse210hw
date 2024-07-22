using System.Drawing;

namespace BrickBreakerGame
{
    public class UnbreakableBrick : Brick
    {
        public UnbreakableBrick(int x, int y, int width, int height) : base(x, y, width, height)
        {
        }

        public override void Hit()
        {

        }

        public override void Render(Graphics g)
        {
            Brush unbreakBrush = new SolidBrush(Color.FromArgb(45, 46, 45));
            g.FillRectangle(unbreakBrush, X, Y, Width, Height);
            g.DrawRectangle(Pens.Black, X, Y, Width, Height);
        }
    }
}
