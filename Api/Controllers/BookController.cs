using Api.Application.Commands.Book;
using Api.Application.Queries.Book;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BookController : ControllerBase
	{
		private readonly IMediator _mediator;

		public BookController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpGet("getbooks")]
		public async Task<IActionResult> GetAllBooks()
		{
			var query = new GetAllBooksRequest();
			var books = await _mediator.Send(query);
			return Ok(books);
		}

		[HttpPost("deletecategory")]
		public async Task<IActionResult> DeleteCategory([FromBody] DeleteCategoryCommand request)
		{
			var books = await _mediator.Send(request);
			return Ok(books);
		}
	}
}
