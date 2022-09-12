using Api.Application.Commands.User;
using Api.Application.Services.User;
using Api.Application.UserDto;
using ApiTests.Utilities;
using Moq;
//using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ApiTests.Application.Commands.User
{
	public class CreateUserHandlerTest
	{
        private readonly Mock<ICreateUserService> _createUserService;
        private readonly ObjectInitializer _objectInit;

        public CreateUserHandlerTest()
        {
            _createUserService = new Mock<ICreateUserService>();
            _objectInit = new ObjectInitializer();
        }

        [Fact]
        public async void HandleCreateUserTest()
        {
            var crtUser = new CreateUserResponse() { Id= 6 };
            //var tupletoReturn = Tuple.Create<CreateUserResponse>(crtUser);

            _createUserService.Setup(r => r.CreateUser(It.IsAny<CreateUserCommand>())).Returns(Task.FromResult(crtUser));

            var createUserRequest = _objectInit.GetCreateUser();

            var handler = new CreateUserHandler(_createUserService.Object);

            var createUserResponse = await handler.Handle(createUserRequest, new CancellationToken());

            Assert.NotNull(createUserResponse);
        }
    }
}
