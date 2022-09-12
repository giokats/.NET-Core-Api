using Api.Application.BookDto;
using Api.Application.Services.Book;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Application.Queries.Book
{
	public class GetAllBooksHandler : IRequestHandler<GetAllBooksRequest, GetAllBooksResponse>
	{
		private readonly IBookService _bookService;

		public GetAllBooksHandler(IBookService bookService)
		{
			_bookService = bookService;
		}

		public async Task<GetAllBooksResponse> Handle(GetAllBooksRequest request, CancellationToken cancellationToken)
		{
			var allBooks = await _bookService.GetAllBooks(request);
			return allBooks;
		}
	}
}
