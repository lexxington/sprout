namespace Sprout.Model.Letters
{
	public class Custom1LetterP: LetterP
	{
		protected override float GetK(Input input) => 2 * input.D + input.D * input.E / 100.0f; 
	}
}
