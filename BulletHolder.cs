using Godot;
using System;
using System.Collections.Generic;

public class BulletHolder : Node
{
    // Declare member variables here. Examples:


    [Export]
    PackedScene bullet = (PackedScene)GD.Load("res://Prefabs/Bullets/Bullet.tscn");

    public List<Bullet> BulletList;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
       
        
        //Populate List of bullets
        for(int i=0; i<50; i++){
           // Bullet newbullet = bullet.Instance<Bullet>();
           // BulletList.Add(newbullet);
           // newbullet.Position = new Vector2(0,0);
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        
    }
}
