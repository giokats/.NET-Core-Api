using Api.Application.Services.User;
using Api.Application.UserDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Application.Commands.User
{
	public class CreateUserHandler : IRequestHandler<CreateUserCommand, CreateUserResponse>
	{
		private readonly ICreateUserService _createOrderService;

		public CreateUserHandler(ICreateUserService createUserService)
		{
			_createOrderService = createUserService;
		}

		public async Task<CreateUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
		{
			var newUser = await _createOrderService.CreateUser(request);
			return newUser;
		}
	}
}
