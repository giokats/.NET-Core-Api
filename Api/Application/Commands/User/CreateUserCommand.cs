using Api.Application.UserDto;
using Api.Domain.Aggregates.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application.Commands.User
{
	public class CreateUserCommand : IRequest<CreateUserResponse>
	{
		public string Name { get; set; }
		public string Surename { get; set; }
		public int RoleId { get; set; }
	}
}
