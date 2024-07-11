using System;

public class Paddle
{
    private int x;
    private int y;
    private int width;
    private int height;
    private int speed;

    public Paddle(int x, int y)
    {
        this.x = x;
        this.y = y;
        this.width = 20; // Adjust width to fit console better
        this.height = 1; // Adjust height to fit console better
        this.speed = 10;
    }

    public void Update()
    {
        // Update paddle position based on user input
    }

    public void Render()
    {
        // Ensure x and y are within console bounds
        x = Math.Max(0, Math.Min(Console.WindowWidth - width, x));
        y = Math.Max(0, Math.Min(Console.WindowHeight - height, y));

        Console.SetCursorPosition(x, y);
        Console.Write(new string('=', width));
    }
    public void MoveLeft()
    {
        x -= speed;
    }

    public void MoveRight()
    {
        x += speed;
    }

}
