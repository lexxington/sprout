using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sprout.Exceptions;
using Sprout.Factory;
using Sprout.Model;
using Sprout.Model.Enums;

namespace Sprout.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	[ApiController]
	public class BaseController : ControllerBase
	{
		[HttpPost]
		[ProducesResponseType(typeof(Output), StatusCodes.Status200OK)]
		[ProducesResponseType(typeof(Error), StatusCodes.Status400BadRequest)]
		public ActionResult<object> Post([FromBody] Input input)
		{
			try
			{
				return BaseFactory.Create(GetRuleType()).GetOutput(input);
			}
			catch (NotSupportedCaseException exc)
			{
				return BadRequest(exc.ToError());
			}
		}

		protected virtual RuleType GetRuleType() => RuleType.Base;
	}
}
