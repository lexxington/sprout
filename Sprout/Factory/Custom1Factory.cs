using Sprout.Model.Letters;
using Sprout.Model.Letters.Base;

namespace Sprout.Factory
{
	public class Custom1Factory:BaseFactory
	{
		protected override ILetter CreateLetterP() => new Custom1LetterP();
	}
}
