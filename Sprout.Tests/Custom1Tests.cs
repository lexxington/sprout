using System;
using System.Collections.Generic;
using System.Text;
using Sprout.Factory;
using Sprout.Model;
using Sprout.Model.Enums;
using Xunit;

namespace Sprout.Tests
{
	public class Custom1Tests: AbstractTests
	{
		protected override RuleType RuleType => RuleType.Custom1;

		[Theory]
		[InlineData(true, true, false, HType.M)]
		public override void ShouldSelectCorrectLetter(bool A, bool B, bool C, HType expected)
		{
			base.ShouldSelectCorrectLetter(A, B, C, expected);
		}

		[Theory]
		[InlineData(true, false, true)]
		public override void ShouldFailWithNotSupportedCaseException(bool A, bool B, bool C)
		{
			base.ShouldFailWithNotSupportedCaseException(A, B, C);
		}

		//K = 2 * D + (D * E / 100)
		[Theory]
		[InlineData(0.0f, 0, 0, 0.0f)]
		[InlineData(1000.0f, 1000, 1000, 12000.0f)]
		[InlineData(-1000.0f, -1000, -1000, 8000.0f)]
		public override void ShouldCalculateKForLetterP(float D, int E, int F, float expected)
		{
			base.ShouldCalculateKForLetterP(D, E, F, expected);
		}
	}
}
