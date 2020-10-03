using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sprout.Factory;
using Sprout.Model;
using Sprout.Model.Enums;

namespace Sprout.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	[ApiController]
	public class Custom1Controller : BaseController
	{
		protected override RuleType GetRuleType() => RuleType.Custom1;
	}
}
