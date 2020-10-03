using System;
using System.Collections.Generic;
using Sprout.Factory;
using Sprout.Model;
using Sprout.Model.Enums;
using Sprout.Model.Letters.Base;
using Xunit;

namespace Sprout.Tests
{
	public class BaseTests:AbstractTests
	{
		protected override RuleType RuleType => RuleType.Base;
		
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

		//K = D + (D * E / 10)
		[Theory]
		[InlineData(1000.0f, 1000, 1000, 101000.0f)]
		[InlineData(-1000.0f, -1000, -1000, 99000.0f)]
		public override void ShouldCalculateKForLetterM(float D, int E, int F, float expected)
		{
			base.ShouldCalculateKForLetterM(D, E, F, expected);
		}

		//K = D + (D * (E - F) / 25.5)
		[Theory]
		[InlineData(1000.0f, 3000, 450, 101000.0f)]
		[InlineData(-1000.0f, -3000, -450, 99000.0f)]
		public override void ShouldCalculateKForLetterP(float D, int E, int F, float expected)
		{
			base.ShouldCalculateKForLetterP(D, E, F, expected);
		}

		//K = D - (D * F / 30)
		[Theory]
		[InlineData(1000.0f, 3000, 3000, -99000.0f)]
		[InlineData(-1000.0f, -3000, -3000, -101000.0f)]
		public override void ShouldCalculateKForLetterT(float D, int E, int F, float expected)
		{
			base.ShouldCalculateKForLetterT(D, E, F, expected);
		}

	}
}
