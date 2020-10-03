using Sprout.Model.Enums;
using Sprout.Model.Letters.Base;

namespace Sprout.Model.Letters
{
	public class LetterT: BaseLetter
	{
		protected override HType GetLetterType() => HType.T;
		protected override float GetK(Input input) => input.D - input.D * input.F / 30.0f;
	}
}
