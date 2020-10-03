using System;
using System.Collections.Generic;
using System.Text;
using Sprout.Factory;
using Sprout.Model;
using Sprout.Model.Enums;
using Xunit;

namespace Sprout.Tests
{
	public class Custom2Tests: AbstractTests
	{
		protected override RuleType RuleType => RuleType.Custom2;
		protected override Input GetInputForLetterM() => new Input { A = true, B = false, C = true };
		protected override Input GetInputForLetterT() => new Input { A = true, B = true, C = false };

		[Theory]
		[InlineData(true, true, false, HType.T)]
		[InlineData(true, false, true, HType.M)]
		public override void ShouldSelectCorrectLetter(bool A, bool B, bool C, HType expected)
		{
			base.ShouldSelectCorrectLetter(A, B, C, expected);
		}

		//K = D + (D * E / 10) or K = F + D + (D * E / 100)
		[Theory]
		[InlineData(0.0f, 0, 0, 0.0f)]
		[InlineData(1000.0f, 1000, 1000, 12000.0f)]
		[InlineData(-1000.0f, -1000, -1000, 8000.0f)]
		public override void ShouldCalculateKForLetterM(float D, int E, int F, float expected)
		{
			base.ShouldCalculateKForLetterM(D, E, F, expected);
		}
	}
}
