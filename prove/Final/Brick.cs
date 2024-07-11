using System;

public class Brick
{
    private int x;
    private int y;
    private int width;
    private int height;
    private bool isDestroyed;

    public Brick(int x, int y)
    {
        this.x = x;
        this.y = y;
        this.width = 10; // Adjust width to fit console better
        this.height = 1; // Adjust height to fit console better
        this.isDestroyed = false;
    }

    public void HandleHit(Ball ball)
    {
        // Handle the ball hitting the brick
    }

    public void Render()
    {
        if (!isDestroyed)
        {
            // Ensure x and y are within console bounds
            x = Math.Max(0, Math.Min(Console.WindowWidth - width, x));
            y = Math.Max(0, Math.Min(Console.WindowHeight - height, y));

            Console.SetCursorPosition(x, y);
            Console.Write(new string('#', width));
        }
    }
}
