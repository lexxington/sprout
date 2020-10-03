using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sprout.Model;

namespace Sprout.Exceptions
{
	public class NotSupportedCaseException:Exception
	{
		public NotSupportedCaseException(string message = "This case is not supported") : base(message)
		{
		}

		public Error ToError() => new Error {ErrorMessage = Message};

	}
}
