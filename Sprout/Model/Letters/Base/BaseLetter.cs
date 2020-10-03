using Sprout.Model.Enums;

namespace Sprout.Model.Letters.Base
{
	public abstract class BaseLetter : ILetter
	{
		public Output GetOutput(Input input)
		{
			return new Output {H = GetLetterType(), K = GetK(input)};
		}

		protected abstract HType GetLetterType();
		protected abstract float GetK(Input input);
	}
}
