using System;
using System.Collections.Generic;

public class Level
{
    private List<Brick> bricks;

    public Level()
    {
        bricks = new List<Brick>();
        // Initialize bricks
    }

    public void CheckCollisions(Ball ball)
    {
        // Check for collisions between the ball and bricks
    }

    public void Render()
    {
        foreach (var brick in bricks)
        {
            brick.Render();
        }
    }
}
