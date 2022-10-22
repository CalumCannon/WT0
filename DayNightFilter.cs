using Godot;
using System;

public class DayNightFilter : Camera2D
{
    Light2D _LightFilter;
    [ExportAttribute]
    Color Day = new Color(0.20f,0.50f,0.55f,0.74f);
    [Export]
    Color Night = new Color(0f,0f,0f,0.62f);
    

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _LightFilter = GetNode<Light2D>("Light2D");
        SetFilter(Day);
    }

    public void SetFilter(Color newcol){
        _LightFilter.Color = (newcol);
    }
}
