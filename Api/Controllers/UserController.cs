using Microsoft.AspNetCore.Mvc;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Api.Application.UserDto;
using Api.Application.Commands.User;

namespace Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : ControllerBase
	{
		private readonly IMediator _mediator;
		//private readonly IMapper _mapper;

		public UserController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpPost("createuser")]
		[ProducesResponseType(typeof(CreateUserResponse), StatusCodes.Status200OK)]
		public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand createUser)
		{
			var user = await _mediator.Send(createUser);
			return Ok(user);
		}

		[HttpPost("updateuserrole")]
		[ProducesResponseType(typeof(UpdateUserRoleResponse), StatusCodes.Status200OK)]
		public async Task<IActionResult> UpdateUserRole([FromBody] UpdateUserRoleCommand updateUserRole)
		{
			var user = await _mediator.Send(updateUserRole);
			return Ok(user);
		}
	}
}
