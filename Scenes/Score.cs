using Godot;
using System;




public partial class Score : AnimatedSprite2D
{
	
	private AnimatedSprite2D _score;
	
	public override void _Ready()
	{
		
		
		
		
		
	}
	
	public void UpdatePoints(int points) {
		
		Frame = Frame + 1;   
		
	}
	
}
