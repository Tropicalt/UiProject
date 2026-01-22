using Godot;
using System;

public partial class PauseMenu : Control
{

	public override void _Process(double delta){
		if (Input.IsActionJustPressed("Pause"))
		{
			GetTree().Paused=!GetTree().Paused;
			Visible=GetTree().Paused;
		}
	}
	
	public void Resume(){
		GetTree().Paused=false;
		Visible=false;
	}
	
	public void Quit(){
		GetTree().ChangeSceneToFile("res://Scenes/MainMenu.tscn");
	}

}
