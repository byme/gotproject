using Godot;
using System;

public partial class Main : Node2D
{
	private Vector2 _speed = new Vector2(0, 6);

	private Vector2 limitUp = new Vector2(-6, -12);
	private Vector2 limitDown = new Vector2(-6, 6);
	private Sprite2D _sprite;

	public override void _Ready()
	{
		_sprite = GetNode<Sprite2D>("PongPlayer");
	}

	public override void _Process(double delta)
	{
		movementController(delta);
	}

	private void movementController(double delta)
	{
		// Move as long as the key/button is pressed.
		if (Input.IsActionPressed("move_up") && _sprite.Position > limitUp)
		{
			_sprite.Position += -_speed * (float)delta;
		}
		if (Input.IsActionPressed("move_down") && _sprite.Position < limitDown)
		{
			_sprite.Position += _speed * (float)delta;
		}
	}
}
