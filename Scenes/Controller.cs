using Godot;

public partial class Controller : Control
{
	public override void _Ready()
	{
		Visible = false;
	}

	public void Open()
	{
		GetTree().Paused = true;
		Visible = true;
	}

	public void Close()
	{
		GetTree().Paused = false;
		Visible = false;
	}

	private void _on_resume_pressed()
	{
		Close();
	}
}
