using Api.Application.Commands.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.Utilities
{
	public class ObjectInitializer
	{
		public ObjectInitializer()
		{

		}

		#region Commands

		public CreateUserCommand GetCreateUser()
		{

			CreateUserCommand createlUser = new CreateUserCommand() { Name = "Lisa", Surename = "Barr" };
			return createlUser;
		}

		public UpdateUserRoleCommand GetUpdateUserRole()
		{

			UpdateUserRoleCommand updateUserRole = new UpdateUserRoleCommand() { userId = 2, roleId = 3 };
			return updateUserRole;
		}
		#endregion
	}
}
