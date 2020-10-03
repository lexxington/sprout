using System;
using System.Diagnostics;
using Sprout.Exceptions;
using Sprout.Model;
using Sprout.Model.Enums;
using Sprout.Model.Letters;
using Sprout.Model.Letters.Base;

namespace Sprout.Factory
{
	public class BaseFactory
	{
		public static BaseFactory Create(RuleType ruleType)
		{
			switch (ruleType)
			{
				case RuleType.Base:
					return new BaseFactory();
				case RuleType.Custom1:
					return new Custom1Factory();
				case RuleType.Custom2:
					return new Custom2Factory();
				default:
					throw new NotImplementedException();
			}
		}

		public Output GetOutput(Input input)
		{
			ILetter letter = GetLetterH(input);
			return letter.GetOutput(input);
		}

		protected virtual ILetter GetLetterH(Input input)
		{
			if (input.A && input.B && !input.C)
				return CreateLetterM();

			if (input.A && input.B && input.C)
				return CreateLetterP();

			if (!input.A && input.B && input.C)
				return CreateLetterT();


			throw new NotSupportedCaseException();
		}

		protected virtual ILetter CreateLetterM() => new LetterM();
		protected virtual ILetter CreateLetterP() => new LetterP();
		protected virtual ILetter CreateLetterT() => new LetterT();
	}
}
