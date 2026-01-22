using Godot;
using System;

public partial class MainMenu : Control
{
	public override void _Ready()
	{
		GetNode<Button>("CenterContainer/VBoxContainer/PlayButton")
			.Pressed += OnPlayPressed;

		GetNode<Button>("CenterContainer/VBoxContainer/QuitButton")
			.Pressed += OnQuitPressed;
	}

	private void OnPlayPressed()
	{
		
		GetTree().ChangeSceneToFile("res://Scenes/Game.tscn");
	}

	private void OnQuitPressed()
	{
		GetTree().Quit();
	}
}
