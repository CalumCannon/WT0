using Godot;
using System;

public class ResourceMap : TileMap
{
    [Export]
    int mapScale = 1;

    [Export]
    Image mapImage2;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        // Sprite mapSprite = new Sprite();
        // ImageTexture mapImageTexture = new ImageTexture();
        // Image mapImage = new Image();
        // mapSprite.Texture = (Texture)GD.Load("res://.import/Map001.bmp");
        // mapImage = mapSprite;
        //mapImageTexture.CreateFromImage(mapImage);

        Texture mapTexture = (Texture)GD.Load("res://Sprites/Maps/Map002.bmp"/*"res://.import/Map001.bmp-7461fce8ab7db8a9ced9e644e748d3bf.stex"/*"res://Sprites/Maps/Map001.png"*/);
        Image mapImage = mapTexture.GetData();
        mapImage.Lock();
        //Map is 30 x 30
        
        int xOffset = -(mapImage.GetWidth()/2)*mapScale;
        int yOffset = -(mapImage.GetWidth()/2)*mapScale;

        //The tilemap starts at middle and goes out
        for(int i=0; i<mapImage.GetWidth(); i++){
            for(int j=0; j<mapImage.GetHeight(); j++){
            Color sample = mapImage.GetPixel(i,j);
            // GD.Print(sample);

            int cell = 1;
            if(sample.r > 0.9f){
            cell = 2;
            }
             
            if(sample.g > 0.9f){
            cell = 2;
            } 

            this.SetCell(i + xOffset,j + yOffset,cell);
            
            // for(int k=0; k<mapScale; i++){
            //     this.SetCell(i + xOffset,j + yOffset,cell);
            // }
            
            }
        }
    }

    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
