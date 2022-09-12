using Api.Application.Services.User;
using Api.Application.UserDto;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Application.Commands.User
{
	public class UpdateUserRoleHandler : IRequestHandler<UpdateUserRoleCommand, UpdateUserRoleResponse>
	{
		private readonly IUpdateUserRoleService _updateUserRoleService;

		public UpdateUserRoleHandler(IUpdateUserRoleService updateUserRoleService)
		{
			_updateUserRoleService = updateUserRoleService;
		}

		public async Task<UpdateUserRoleResponse> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
		{
			var updateUser = await _updateUserRoleService.UpdateUserRole(request);
			return updateUser;
		}
	}
}
