extends RigidBody2D


# Declare member variables here. Examples:
var velocity = Vector2(0,-1)
var speed = 500
var direction
var Player
var alive = true
var _timer
var EnemyHolder

# Called when the node enters the scene tree for the first time.
func _ready():
	
	_timer = Timer.new()
	add_child(_timer)

	_timer.connect("timeout", self, "_on_Timer_timeout")
	_timer.set_wait_time(5.0)
	_timer.set_one_shot(false) # Make sure it loops
	_timer.start()
	
	gravity_scale = 0
	Player = get_node("/root/GameController/Player")
	get_node("CollisionShape2D").disabled = true
	#print(Vector2(cos(rotation), sin(rotation)))
	pass # Replace with function body.

func _on_Timer_timeout():
	queue_free()
	pass

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	
	if(!alive):
		queue_free()
		
	 #velocity = get_node("Sprite").up
	 #direction = Vector2(cos(rotation), sin(rotation))
	 
	collision()
	direction = Vector2(cos(rotation), sin(rotation))
	velocity = speed * -direction
	#velocity = move_and_slide(velocity)
	position += velocity/100
	#position += velocity

func collision():
	#print("distance to player")
	#print(position.distance_to(Player.position))
	
	if(position.distance_to(Player.position) < 50):
		Player.health -= 10;
		alive = false;
	#	
	#	}
	pass
