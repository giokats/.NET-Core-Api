using Api.Domain.Aggregates.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application.BookDto
{
	public class GetAllBooksResponse
	{
		public List<Book> allBooks { get; set; }
	}
}
