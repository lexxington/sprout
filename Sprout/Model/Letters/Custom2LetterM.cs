namespace Sprout.Model.Letters
{
	public class Custom2LetterM: LetterM
	{
		protected override float GetK(Input input) => input.F + input.D + input.D * input.E / 100.0f;
	}
}
