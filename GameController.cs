using Godot;
using System;

public class GameController : Node2D
{
    // Declare member variables here. Examples:
    Label IronLabel;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(this.GetPath());
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
