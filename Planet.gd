extends Node


# Declare member variables here. Examples:

var resourceMap = load("res://Sprites/Maps/Map002.bmp")
var MapDisplay;

# Called when the node enters the scene tree for the first time.
func _ready():
	MapDisplay = get_node("PlanetButton/MapDisplay") as Sprite
	MapDisplay.visible = false;
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass


func _on_PlanetButton_mouse_entered():
	MapDisplay.visible = true;
	pass # Replace with function body.



func _on_PlanetButton_mouse_exited():
	MapDisplay.visible = false;
	pass # Replace with function body.
