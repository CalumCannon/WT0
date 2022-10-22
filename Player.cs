using Godot;
using System;

public class Player : KinematicBody2D
{
	private AnimationPlayer _animationPlayer;
	
	Label IronLabel;

	Node2D GC;

	[Export] public int speed = 200;
	public Vector2 velocity = new Vector2();

	[Export]
	int walkspeed = 1;

	int iron = 0;
	int techbits = 0;
	int water = 0;

	public float health = 100;
	public float oxygen = 100;

	[Export]
	float oxygenDrainFactor = 0.01f;

	TileMap _structuresMap;

	public override void _Ready()
	{
		GC = GetNode<Node2D>("/root/GameController");
		_animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
		_structuresMap = GetNode<TileMap>("/root/GameController/Structures");
		IronLabel = GetNode<Label>("/root/GameController/Player/UI/IRON");
		addIron(4);
	}

	public void addIron(int value){
		iron += value;
		IronLabel.Text = "IRON: " + iron.ToString();
	}
	
	public void addTechbits(int value){
		techbits += value;
	}

	public void addWater(int value){
		water += value;
	}

	void OxygenUpdate(){
		if(oxygen>0)
		oxygen -= oxygenDrainFactor;

		if(oxygen < 0){
			health -= oxygenDrainFactor;
		}
	}

	public void GetInput()
	{
		velocity = new Vector2();

		if (Input.IsActionPressed("ui_right")){
			velocity.x += walkspeed;
		}

		if (Input.IsActionPressed("ui_left")){
			velocity.x -= walkspeed;
		}

		if (Input.IsActionPressed("ui_down")){
			velocity.y += walkspeed;
		}
			
		if (Input.IsActionPressed("ui_up")){
			velocity.y -= walkspeed;
		}

		velocity = velocity.Normalized() * speed;
	}

	void UpdateAnimation(){


		if (Input.IsActionJustReleased("ui_right") && Input.IsActionJustReleased("ui_up")){
			_animationPlayer.Play("UpRight_S");
			return;
		}

		if (Input.IsActionJustReleased("ui_right") && Input.IsActionJustReleased("ui_down")){
			_animationPlayer.Play("DownRight_S");
			return;
		}

		if (Input.IsActionJustReleased("ui_left") && Input.IsActionJustReleased("ui_up")){
			_animationPlayer.Play("UpLeft_S");
			return;
		}

		if (Input.IsActionJustReleased("ui_left") && Input.IsActionJustReleased("ui_down")){
			_animationPlayer.Play("DownLeft_S");
			return;
		}

		if (Input.IsActionPressed("ui_right") && Input.IsActionPressed("ui_up")){
			_animationPlayer.Play("UpRight");
			return;
		}

		if (Input.IsActionPressed("ui_right") && Input.IsActionPressed("ui_down")){
			_animationPlayer.Play("DownRight");
			return;
		}

		if (Input.IsActionPressed("ui_left") && Input.IsActionPressed("ui_up")){
			_animationPlayer.Play("UpLeft");
			return;
		}

		if (Input.IsActionPressed("ui_left") && Input.IsActionPressed("ui_down")){
			_animationPlayer.Play("DownLeft");
			return;
		}

		if (Input.IsActionPressed("ui_right")){
			_animationPlayer.Play("Right");
		}

		if (Input.IsActionPressed("ui_left")){
			_animationPlayer.Play("Left");
		}

		if (Input.IsActionPressed("ui_down")){
			_animationPlayer.Play("Down");
		}
			
		if (Input.IsActionPressed("ui_up")){
			_animationPlayer.Play("Up");
		}


		if (Input.IsActionJustReleased("ui_up")){
			_animationPlayer.Play("Up_S");
		}

		if (Input.IsActionJustReleased("ui_down")){
			_animationPlayer.Play("Down_S");
		}

		if (Input.IsActionJustReleased("ui_left")){
			_animationPlayer.Play("Left_S");
		}

		if (Input.IsActionJustReleased("ui_right")){
			_animationPlayer.Play("Right_S");
		}
	
	}

	public override void _PhysicsProcess(float delta)
	{
		TileCollisionUpdate();
		OxygenUpdate();
		GetInput();
		UpdateAnimation();
		velocity = MoveAndSlide(velocity);
	}

	public void TileCollisionUpdate(){
		//if(_structuresMap.GetCellv(this.Position) != -1)
		if(_structuresMap.GetCellv(_structuresMap.WorldToMap(this.Position)) == 1){
			//AT HOME
			oxygen = 100;
		}

		//this.ZIndex = //Position.x;
		//GD.Print(_structuresMap.GetCellv(_structuresMap.WorldToMap(this.Position)).ToString() + " FOUND");
	}

}
