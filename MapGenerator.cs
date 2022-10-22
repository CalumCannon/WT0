using Godot;
using System;

public class MapGenerator : Node
{
	// Declare member variables here. Examples:
	[ExportAttribute(PropertyHint.Range,"10,100,5")]
	private int width = 10;
	[ExportAttribute(PropertyHint.Range,"10,100,5")]
	private int height = 10;

	[Export]
	public Godot.TileMap Ground;

	[Export]
	int GroundTile;

	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Grab ref to floor tile and place w*h
		Texture floorTile = GD.Load("res://Sprites/FloorSprites/tiletemplate_large.png") as Texture;
		//floorTile.DrawRect(floorTile,new Rect2(new Vector2(0,0),new Vector2(100,100)), true);
		//floorTile.SetPosition(new Vector2(0,0));
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
