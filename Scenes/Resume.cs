using Godot;

public partial class Resume : Button
{
	[Export] public NodePath PauseMenuPath;

	private PauseMenu pauseMenu;

	public override void _Ready()
	{
		pauseMenu = GetNode<PauseMenu>(PauseMenuPath);
	}
}
