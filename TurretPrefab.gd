extends StaticBody2D


# Declare member variables here. Examples:
var bulletHolder;
var _timer = null
var bulletPrefab = preload("res://Prefabs/Bullets/Bullet.tscn")
var enemyHolder
var direction;# = Vector2(cos(angle), sin(angle))
var target
var canShoot = true

# Called when the node enters the scene tree for the first time.
func _ready():
	enemyHolder  = get_node("/root/GameController/EnemyHolder")
	target = enemyHolder.get_node("EnemyPrefab") as Node

	bulletHolder = get_node("/root/GameController/SpriteHolder/Bullets")
	_timer = Timer.new()
	add_child(_timer)
	
	_timer.connect("timeout", self, "_on_Timer_timeout")
	_timer.set_wait_time(1.0)
	_timer.set_one_shot(false) # Make sure it loops
	_timer.start()

func _on_Timer_timeout():
	canShoot = true
	pass
	
func shoot():
	print("SHOOTING")
	print("Sprite position")
	print(get_node("Sprite").position)
	print("Sprite rot calculation")
	
	var newbullet = bulletPrefab.instance()
	
	
	bulletHolder.add_child(newbullet)
	newbullet.rotation = get_node("Sprite").rotation
	
	#print(fmod(newbullet.rotation,6.28319))
	#print((Vector2(-20,-20) * newbullet.rotation))
	newbullet.global_position = get_node("Sprite").global_position + (Vector2(-200,-200) * Vector2(cos(fmod(newbullet.rotation,6.28319)), sin(fmod(newbullet.rotation,6.28319))))
	pass

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	get_node("Sprite").look_at(target.position)
	rotate(3.28)
	
	if(canShoot):
		canShoot = false
		shoot()
		
	#direction = Vector2(cos(get_node("Sprite").rotation), sin(get_node("Sprite").rotation))
	#get_node("Sprite").rotate(0.01)
	#get_node("Sprite").look_at(/*nearest enemy within range*/)
	pass
