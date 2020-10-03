using Sprout.Model;
using Sprout.Model.Letters;
using Sprout.Model.Letters.Base;

namespace Sprout.Factory
{
	public class Custom2Factory:BaseFactory
	{
		protected override ILetter GetLetterH(Input input)
		{
			if (input.A && input.B && !input.C)
				return CreateLetterT();

			if (input.A && !input.B && input.C)
				return CreateLetterM();

			return base.GetLetterH(input);
		}

		protected override ILetter CreateLetterM() => new Custom2LetterM();
	}
}
