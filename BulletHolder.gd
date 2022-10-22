extends Node


# Declare member variables here. Examples:
var bulletPrefab = preload("res://Prefabs/Bullets/Bullet.tscn");
var bulletArray = []

# Called when the node enters the scene tree for the first time.
func _ready():

	
	for i in 50:
		var newbullet = bulletPrefab.instance();
		#bullet.set_process(false)
		#bullet.hide()
		newbullet.position = Vector2(0,0)
		bulletArray.push_back(newbullet)
		#add_child(bullet)
	

func returnBullet():
	var returnBullet = bulletArray.pop_back()
	return returnBullet

# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass
