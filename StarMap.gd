extends Node2D


# Declare member variables here. Examples:
# var a = 2
# var b = "text"
var numberOfPlanets = 10;
var planetPrefab = preload("res://Prefabs/StarMap/Planet.tscn");
var BG

# Called when the node enters the scene tree for the first time.
func _ready():
	BG = get_node("BG")

	#load planet prefab
	#rando distro planets 
	for n in numberOfPlanets:
		var new_planet = planetPrefab.instance()
		BG.add_child(new_planet)
		var newpos = Vector2(rand_range(0,1000), rand_range(0,500))
		 
		new_planet.get_child(0).set_global_position(newpos)
	pass


# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass
