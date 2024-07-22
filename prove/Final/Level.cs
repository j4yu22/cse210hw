using System.Collections.Generic;
using System.Drawing;

namespace BrickBreakerGame
{
    public class Level
    {
        public List<Brick> Bricks { get; private set; }

        public Level(int rows, int cols, int formWidth, int formHeight)
        {
            Bricks = new List<Brick>();
            GenerateLevel(rows, cols, formWidth, formHeight);
        }

        private void GenerateLevel(int rows, int cols, int formWidth, int formHeight)
        {
            int brickWidth = formWidth / cols;
            int brickHeight = (formHeight / 2) / rows;

            int[,] levelLayout = new int[,]
            {
                { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
                { 3, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 3 },
                { 3, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 1, 3 },
                { 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
                { 3, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 3 },
                { 3, 1, 1, 1, 1, 1, 2, 1, 3, 2, 2, 2, 2, 3, 1, 2, 1, 1, 1, 1, 1, 3 },
                { 3, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 3 },
                { 3, 2, 2, 2, 2, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 1, 1, 2, 2, 2, 2, 3 },
                { 3, 1, 1, 1, 1, 3, 3, 3, 3, 1, 1, 1, 1, 3, 3, 3, 3, 1, 1, 1, 1, 3 },
                { 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3 },
                { 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3 },
                { 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3 }
            };

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int brickType = levelLayout[row, col];
                    if (brickType == 1)
                    {
                        Bricks.Add(new NormalBrick(col * brickWidth, row * brickHeight, brickWidth, brickHeight));
                    }
                    else if (brickType == 2)
                    {
                        Bricks.Add(new StrongBrick(col * brickWidth, row * brickHeight, brickWidth, brickHeight));
                    }
                    else if (brickType == 3)
                    {
                        Bricks.Add(new UnbreakableBrick(col * brickWidth, row * brickHeight, brickWidth, brickHeight));
                    }
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Brick brick in Bricks)
            {
                brick.Render(g);
            }
        }
    }
}
