using Api.Application.UserDto;
using MediatR;

namespace Api.Application.Commands.User
{
	public class UpdateUserRoleCommand : IRequest<UpdateUserRoleResponse>
	{
		public int userId { get; set; }
		public int roleId { get; set; }
	}
}
