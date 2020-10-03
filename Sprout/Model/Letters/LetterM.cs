using Sprout.Model.Enums;
using Sprout.Model.Letters.Base;

namespace Sprout.Model.Letters
{
	public class LetterM : BaseLetter
	{
		protected override HType GetLetterType() => HType.M;
		protected override float GetK(Input input) => input.D + input.D * input.E / 10.0f;
	}
}
