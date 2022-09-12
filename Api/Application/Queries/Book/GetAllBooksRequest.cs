using Api.Application.BookDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application.Queries.Book
{
	public class GetAllBooksRequest : IRequest<GetAllBooksResponse>
	{

	}
}
