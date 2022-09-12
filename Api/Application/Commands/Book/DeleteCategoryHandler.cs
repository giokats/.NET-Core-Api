using Api.Application.BookDto;
using Api.Application.Services.Book;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Application.Commands.Book
{
	public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, DeleteCategoryResponse>
	{
		private readonly IBookService _bookService;

		public DeleteCategoryHandler(IBookService bookService)
		{
			_bookService = bookService;
		}

		public async Task<DeleteCategoryResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
		{
			var deleteCat = await _bookService.DeleteCategory(request);
			return deleteCat;
		}
	}
}
