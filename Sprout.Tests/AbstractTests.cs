using System;
using System.Collections.Generic;
using System.Text;
using Sprout.Exceptions;
using Sprout.Factory;
using Sprout.Model;
using Sprout.Model.Enums;
using Xunit;

namespace Sprout.Tests
{
	//sorry for this name, Base prefix is in use 
	public abstract class AbstractTests
	{
		protected abstract RuleType RuleType { get; }
		protected virtual Input GetInputForLetterM() => new Input {A = true, B = true, C = false};
		protected Input GetInputForLetterP() => new Input { A = true, B = true, C = true };
		protected virtual Input GetInputForLetterT() => new Input { A = false, B = true, C = true };


		[Theory]
		[InlineData(true, true, true, HType.P)]
		[InlineData(false, true, true, HType.T)]
		public virtual void ShouldSelectCorrectLetter(bool A, bool B, bool C, HType expected)
		{
			Input input = new Input { A = A, B = B, C = C };
			Output output = BaseFactory.Create(RuleType).GetOutput(input);

			Assert.Equal(expected, output.H);
		}

		[Theory]
		[InlineData(false, false, false)]
		[InlineData(true, false, false)]
		[InlineData(false, true, false)]
		[InlineData(false, false, true)]
		public virtual void ShouldFailWithNotSupportedCaseException(bool A, bool B, bool C)
		{
			Input input = new Input { A = A, B = B, C = C };

			Assert.Throws<NotSupportedCaseException>(() => BaseFactory.Create(RuleType).GetOutput(input));
		}

		protected void ShouldCalculateK(Func<Input> getInput, float D, int E, int F, float expected)
		{
			Input input = getInput.Invoke();
			input.D = D;
			input.E = E;
			input.F = F;

			Output output = BaseFactory.Create(RuleType).GetOutput(input);
			Assert.Equal(expected, output.K);
		}

		//K = D + (D * E / 10) or K = F + D + (D * E / 100)
		[Theory]
		[InlineData(0.0f, 0, 0, 0.0f)]
		[InlineData(100.0f, 100, 900, 1100.0f)]
		[InlineData(-100.0f, -100, 900, 900.0f)]
		public virtual void ShouldCalculateKForLetterM(float D, int E, int F, float expected)
		{
			ShouldCalculateK(GetInputForLetterM, D, E, F, expected);
		}

		//K = D + (D * (E - F) / 25.5) or K = 2 * D + (D * E / 100)
		[Theory]
		[InlineData(0.0f, 0, 0, 0.0f)]
		[InlineData(100.0f, 100, 49, 300.0f)]
		[InlineData(-100.0f, -100, -100, -100.0f)]
		public virtual void ShouldCalculateKForLetterP(float D, int E, int F, float expected)
		{
			ShouldCalculateK(GetInputForLetterP, D, E, F, expected);
		}

		//K = D - (D * F / 30)
		[Theory]
		[InlineData(0.0f, 0, 0, 0.0f)]
		[InlineData(100.0f, 0, 300, -900.0f)]
		[InlineData(-100.0f, 0, -30, -200.0f)]
		public virtual void ShouldCalculateKForLetterT(float D, int E, int F, float expected)
		{
			ShouldCalculateK(GetInputForLetterT, D, E, F, expected);
		}
	}
}
