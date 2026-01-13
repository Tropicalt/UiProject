using Godot;

public partial class HUD : CanvasLayer
{
	private TextureProgressBar _healthBar;
	private TextureProgressBar _staminaBar;
	private Label _scoreLabel;

	public override void _Ready()
	{
		_healthBar = GetNode<TextureProgressBar>("Control/HealthBar");
		_staminaBar = GetNode<TextureProgressBar>("Control/StaminaBar");
		_scoreLabel = GetNode<Label>("Control/ScoreLabel");
	}

	public void SetHealth(float value)
	{
		_healthBar.Value = value;
	}

	public void SetStamina(float value)
	{
		_staminaBar.Value = value;
	}

	public void SetScore(int score)
	{
		_scoreLabel.Text = $"Score: {score}";
	}
	
	public void UpdateLives(int lives) {
		
	}

}
