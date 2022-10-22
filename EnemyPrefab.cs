using Godot;
using System;

public class EnemyPrefab : Node2D
{

    public bool alive = true;
    Player Player;
    float speed = 150;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Player = GetNode<Player>("/root/GameController/Player");
    }

    void moveTowardsPlayer(float delta){
        this.Position = this.Position.MoveToward(Player.Position, delta*speed);
        if(this.Position.DistanceTo(Player.Position) < 50){
            alive = false;
            Player.health -= 10;
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        //GD.Print(alive.ToString() + "    "  + this.Position.DistanceTo(Player.Position));
        if(alive){
            moveTowardsPlayer(delta);
        }        
    }
}
