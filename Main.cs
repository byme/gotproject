using Godot;
using System;

public partial class Main : Node2D
{
	private Vector2 _speed = new Vector2(0,6);

	private Sprite2D _sprite;
	public override void _Ready()
	{
		_sprite = GetNode<Sprite2D>("PongPlayer");
	}

	public override void _Process(double delta)
	{
		_sprite.Position += _speed * (float)delta;
		if(_sprite.Position.Y > 6)
		{
			_sprite.Position = new Vector2(-6,-12);
		}
	}
}
