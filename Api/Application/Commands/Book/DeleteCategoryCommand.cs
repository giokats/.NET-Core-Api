using Api.Application.BookDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application.Commands.Book
{
	public class DeleteCategoryCommand : IRequest<DeleteCategoryResponse>
	{
		public int catId { get; set; }
	}
}
