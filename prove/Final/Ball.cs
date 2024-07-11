using System;

public class Ball
{
    private int x;
    private int y;
    private int speedX;
    private int speedY;
    private int radius;

    public Ball(int x, int y)
    {
        this.x = x;
        this.y = y;
        this.speedX = 1; // Adjust speed for smoother movement
        this.speedY = 1; // Adjust speed for smoother movement
        this.radius = 1;
    }

    public void Update()
    {
        // Update ball position
        x += speedX;
        y += speedY;

        // Ensure ball stays within console bounds
        if (x < 0 || x >= Console.WindowWidth) speedX = -speedX;
        if (y < 0 || y >= Console.WindowHeight) speedY = -speedY;
    }

    public void Render()
    {
        // Ensure x and y are within console bounds
        x = Math.Max(0, Math.Min(Console.WindowWidth - 1, x));
        y = Math.Max(0, Math.Min(Console.WindowHeight - 1, y));

        Console.SetCursorPosition(x, y);
        Console.Write('O');
    }
}
