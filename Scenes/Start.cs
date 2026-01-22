using Godot;
using System;

public partial class Start : Control
{
	
	public void Begin(){
		GetTree().ChangeSceneToFile("res://Scenes/Level.tscn");
	}
	
	private void OnQuitPressed()
	{
		GetTree().Quit();
	}
	
}
