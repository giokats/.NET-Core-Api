using Api.Application.BookDto;
using Api.Application.Commands.Book;
using Api.Application.Queries.Book;
using Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application.Services.Book
{
	public interface IBookService
	{
		Task<GetAllBooksResponse> GetAllBooks(GetAllBooksRequest request);
		Task<DeleteCategoryResponse> DeleteCategory(DeleteCategoryCommand request);
	}
	public class BookService : IBookService
	{
		private readonly ApiContext _context;

		public BookService(ApiContext context)
		{
			_context = context;
		}

		public async Task<GetAllBooksResponse> GetAllBooks(GetAllBooksRequest request)
		{
			var books = _context.Books.Include(x => x.Category).ToList();
			return new GetAllBooksResponse() { allBooks = books };
		}

		public async Task<DeleteCategoryResponse> DeleteCategory(DeleteCategoryCommand request)
		{
			var category = await _context.Categories.FindAsync(request.catId);
			if (category == null)
				return new DeleteCategoryResponse() { status = false };

			 _context.Categories.Remove(category);
			await _context.SaveChangesAsync();
			return new DeleteCategoryResponse() { status = true };
		}
	}
}
