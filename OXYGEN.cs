using Godot;
using System;

public class OXYGEN : Label
{
    // Declare member variables here. Examples:
    Player Player;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Player = GetNode<Player>("/root/GameController/Player");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
       this.Text = "OXYGEN: " + (int)Player.oxygen;        
    }
}
