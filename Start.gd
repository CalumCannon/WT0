extends Button


# Declare member variables here. Examples:
# var a = 2
# var b = "text"


# Called when the node enters the scene tree for the first time.
func _ready():
	#button = this;
	#button.connect("pressed", self, "_button_pressed")
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	
	pass


func _on_Start_button_up():
	print("CLICKED!")
	get_tree().change_scene("res://StarMap.tscn")
	pass # Replace with function body.
