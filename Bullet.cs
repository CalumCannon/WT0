using Godot;
using System;

public class Bullet : KinematicBody2D
{
    // Declare member variables here. Examples:
    Vector2 velocity = new Vector2(0,-1);
    float speed = 100;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        velocity = velocity.Normalized() * speed;
        velocity = MoveAndSlide(velocity);
    }
}
