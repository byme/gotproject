using Godot;
using System;

public partial class Main : Node2D
{
	private Vector2 _speed = new Vector2(0, 30);
	private Vector2 _ballSpeed = new Vector2(10, 0);

	private Vector2 limitUp = new Vector2(-6, -18);
	private Vector2 limitDown = new Vector2(-6, 12);
	private Sprite2D _pongPlayer;

	private Sprite2D _ball;

	public override void _Ready()
	{
		_pongPlayer = GetNode<Sprite2D>("PongPlayer");
		_ball = GetNode<Sprite2D>("Ball");
	}

	public override void _Process(double delta)
	{
		movementController(delta);
		movementBall(delta);
	}

	private void movementController(double delta)
	{
		// Move as long as the key/button is pressed.
		if (Input.IsActionPressed("move_up") && _pongPlayer.Position > limitUp)
		{
			_pongPlayer.Position += -_speed * (float)delta;
		}
		if (Input.IsActionPressed("move_down") && _pongPlayer.Position < limitDown)
		{
			_pongPlayer.Position += _speed * (float)delta;
		}
	}

	private void movementBall(double delta)
	{
		_ball.Position += -_ballSpeed * (float)delta;
		if (_ball.Position < new Vector2(-10, _ball.Position.Y))
		{
			_ball.Position = new Vector2(6, _ball.Position.Y);
		}
	}
}
