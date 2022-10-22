using Godot;
using System;

public class TimeOfDay : Node
{

    public float DayNightTime = 6.28319f;

    [Export]
    public float DayNightTick = 0.1f;
    float DayNightMax;
    Sprite DayNightImage;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        DayNightMax = DayNightTime;
        DayNightImage = GetNode<Sprite>("DayNight");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
 public override void _Process(float delta)
 {
    DayNightTime -= DayNightTick;
    if(DayNightTime < 0){
        DayNightTime = DayNightMax;
    }
    UpdateDayTimeImage();
 }

 public void UpdateDayTimeImage(){
    // 360 deg = 6.28319 radians?
    DayNightImage.Rotation = DayNightTime;
 }
}
