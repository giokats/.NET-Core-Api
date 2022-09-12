using Api.Application.Commands.User;
using Api.Application.UserDto;
using Api.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application.Services.User
{
	public interface IUpdateUserRoleService
	{
		Task<UpdateUserRoleResponse> UpdateUserRole(UpdateUserRoleCommand request);
	}
	public class UpdateUserRoleService : IUpdateUserRoleService
	{
		private readonly ApiContext _context;

		public UpdateUserRoleService(ApiContext context)
		{
			
			   _context = context;
		}

		public async Task<UpdateUserRoleResponse> UpdateUserRole(UpdateUserRoleCommand request)
		{
			var userRole = _context.Users_Roles.Where(x => x.UserId == request.userId).FirstOrDefault();
			userRole.RoleId = request.roleId;
			_context.Users_Roles.Update(userRole);
			await _context.SaveChangesAsync();
			return new UpdateUserRoleResponse { status = true };
			

		}
	}
}
