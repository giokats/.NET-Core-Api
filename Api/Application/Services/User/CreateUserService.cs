using Api.Application.Commands.User;
using Api.Infrastructure.Context;
using Api.Application.UserDto;
using Api.Domain.Aggregates.Users;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application.Services.User
{
	public interface ICreateUserService
	{
		Task<CreateUserResponse> CreateUser(CreateUserCommand request);
	}
	class CreateUserService : ICreateUserService
	{
		private readonly ApiContext _context;

		public CreateUserService(ApiContext context)
		{
			_context = context;
		}
		public async Task<CreateUserResponse> CreateUser(CreateUserCommand request)
		{
			var user = new Api.Domain.Aggregates.Users.User();
			user.Name = request.Name;
			user.Surename = request.Surename;

			var role = _context.Roles.Where(a => a.Id == request.RoleId).FirstOrDefault();
			var user_role = new User_Role()
			{
				User = user,
				Role = role
			};

			await _context.Users.AddAsync(user);
			await _context.Users_Roles.AddAsync(user_role);
			await _context.SaveChangesAsync();
			return new CreateUserResponse { Id = user.Id };
		}

	}
}
