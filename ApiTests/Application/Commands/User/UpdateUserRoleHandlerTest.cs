using Api.Application.Commands.User;
using Api.Application.Services.User;
using Api.Application.UserDto;
using ApiTests.Utilities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ApiTests.Application.Commands.User
{
	public class UpdateUserRoleHandlerTest
	{
        private readonly Mock<IUpdateUserRoleService> _updateUserRoleService;
        private readonly ObjectInitializer _objectInit;

        public UpdateUserRoleHandlerTest()
        {
            _updateUserRoleService = new Mock<IUpdateUserRoleService>();
            _objectInit = new ObjectInitializer();
        }

        public async void HandleUpdateUserRoleTest()
        {
            var updRole = new UpdateUserRoleResponse() { status = true };
            //var tupletoReturn = Tuple.Create<CreateUserResponse>(crtUser);

            _updateUserRoleService.Setup(r => r.UpdateUserRole(It.IsAny<UpdateUserRoleCommand>())).Returns(Task.FromResult(updRole));

            var updateUserRoleRequest = _objectInit.GetUpdateUserRole();

            var handler = new UpdateUserRoleHandler(_updateUserRoleService.Object);

            var updateUserRoleResponse = await handler.Handle(updateUserRoleRequest, new CancellationToken());

            Assert.NotNull(updateUserRoleResponse);
        }
    }
}
