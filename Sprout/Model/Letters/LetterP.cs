using Sprout.Model.Enums;
using Sprout.Model.Letters.Base;

namespace Sprout.Model.Letters
{
	public class LetterP : BaseLetter
	{
		protected override HType GetLetterType() => HType.P;
		protected override float GetK(Input input) => input.D + input.D * (input.E - input.F) / 25.5f;
	}
}
